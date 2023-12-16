using AutoMapper;
using BLL.Common;
using BLL.Requests;
using BLL.Responses;
using BLL.Services.Constracts;
using DAL.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Repository.Repositories;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace BLL.Services.Implementations
{
	public class AuthService : IAuthService
	{
		private readonly UserRepository _repositoryUser;
		private readonly InformationRepository _repositoryEmployee;
		private readonly RefeshTokenRepository _repositoryRefeshToken;
		private readonly RecoveryTokenRepository _repositoryRecovery;
		private readonly IHttpContextAccessor _context;
		private readonly IEmailService _emailService;
		private readonly IConfiguration _configuration;
		private readonly IMapper _mapper;
		private readonly ILogger<AuthService> _logger;

		public AuthService(
			IConfiguration configuration,
			IHttpContextAccessor context,
			IMapper mapper,
			ILogger<AuthService> logger,
			UserRepository repositoryUser,
			InformationRepository repositoryEmployee,
			RefeshTokenRepository repositoryRefeshToken,
			RecoveryTokenRepository repositoryRecovery,
			IEmailService emailService)
		{
			_configuration = configuration;
			_context = context;
			_mapper = mapper;
			_logger = logger;
			_repositoryUser = repositoryUser;
			_repositoryEmployee = repositoryEmployee;
			_repositoryRefeshToken = repositoryRefeshToken;
			_repositoryRecovery = repositoryRecovery;
			_emailService = emailService;
		}

		public async Task<ApiResponse<UserResponse>> Login(LoginRequest loginRequest)
		{
			try
			{
				// Case 1: username
				var user = _repositoryUser.GetUserByUsername(loginRequest.Username);
				if (user == null)
				{
					// case 2: use email
					var Employee = _repositoryEmployee.GetEmployeeByEmail(loginRequest.Username);
					if (Employee == null)
					{
						// case 3: use phonenumber
						Employee = _repositoryEmployee.GetEmployeeByPhoneNumber(loginRequest.Username);
						if (Employee == null)
						{
							return ApiResponse<UserResponse>.ApiResponseFail("Tài khoản hoặc mật khẩu không chính xác!");
						}
						else
						{
							user = Employee.User;
						}
					}
					else
					{
						user = Employee.User;
					}
				}
				if (VerifyPassword(loginRequest.Password, user.PasswordHash))
				{
					var Employee = _repositoryEmployee.GetEmployeeByUserId(user.Id);
					var userResponse = _mapper.Map<UserResponse>(Employee);
					userResponse.Username = user.Username;
					userResponse.AccessToken = GenerateAccessToken(user);
					userResponse.RefeshToken = GenerateRefeshToken(user);
					userResponse.Role = user.Role;
					return ApiResponse<UserResponse>.ApiResponseSuccess("Đăng nhập thành công", userResponse);
				}
				return ApiResponse<UserResponse>.ApiResponseFail("Tài khoản hoặc mật khẩu không chính xác!");
			}
			catch (Exception ec)
			{
				_logger.LogError($"|{DateTime.Now}|:  Exception error: {ec.Message}");
				return ApiResponse<UserResponse>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<UserResponse>> RefeshToken(string refeshToken)
		{
			try
			{
				var refeshTokenOnDb = _repositoryRefeshToken.GetRefeshTokenByRefeshToken(refeshToken);
				if (refeshTokenOnDb == null)
				{
					throw new Exception("Refesh token invalid");
				}
				// check refesh token expire
				if (refeshTokenOnDb.Expires < DateTime.UtcNow)
				{
					throw new Exception("Refesh token have expired");
				}
				var jwtTokenHandler = new JwtSecurityTokenHandler();
				var secretKey = Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]);
				var tokenValidateParam = new TokenValidationParameters
				{
					ValidateIssuer = false,
					ValidateAudience = false,
					ValidateIssuerSigningKey = true,
					IssuerSigningKey = new SymmetricSecurityKey(secretKey),
					ClockSkew = TimeSpan.Zero,
					ValidateLifetime = false
				};
				// get access token in cookies
				var accessToken = _context.HttpContext.Request.Cookies["X-Access-Token"];
				var tokenInVerification = jwtTokenHandler.ValidateToken(accessToken, tokenValidateParam, out var validatedToken);
				// get user id from db
				var userIdInRefeshToken = refeshTokenOnDb.UserId;
				// get user id from jwt
				var userIdInAccessToken = tokenInVerification.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
				if (userIdInRefeshToken != userIdInAccessToken) // check user id current same refesh token on db
				{
					throw new Exception("Do not match user current");
				}
				// check access token expired
				var utcExpireDate = long.Parse(tokenInVerification.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Exp).Value);
				var expireDate = ConvertUnixTimeToDateTime(utcExpireDate);
				var user = _repositoryUser.GetUserByUserId(userIdInAccessToken);
				if (user == null)
				{
					throw new Exception("User not found");
				}
				string mess = "Refesh token success";
				// 15:15+ 5 > 15:19
				if (DateTime.UtcNow.AddMinutes(5) > expireDate) // expired
				{
					// generate access and refesh token
					accessToken = GenerateAccessToken(user);
					refeshToken = GenerateRefeshToken(user);
				}
				else // still use
				{
					// DO NOT THING
					mess = "AccessToken still usable";
				}

				var Employee = _repositoryEmployee.GetEmployeeByUserId(user.Id);
				var userResponse = _mapper.Map<UserResponse>(Employee);
				userResponse.Username = user.Username;
				userResponse.RefeshToken = refeshToken;
				userResponse.AccessToken = accessToken;
				return ApiResponse<UserResponse>.ApiResponseSuccess(mess, userResponse);
			}
			catch (Exception ec)
			{
				_logger.LogError($"|{DateTime.Now}|:  Exception error: {ec.Message}");
				return ApiResponse<UserResponse>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<PasswordRecoveryTokenResponse>> Register(RegisterRequest registerRequest)
		{
			try
			{
				// check passord && confirm password
				if (registerRequest.Password != registerRequest.PasswordConfirm)
				{
					return ApiResponse<PasswordRecoveryTokenResponse>.ApiResponseFail("Mật khẩu xác nhận không trùng nhau");
				}
				// case 1: check username
				var userDb = _repositoryUser.GetUserByUsername(registerRequest.Username);
				if (userDb != null)
				{
					return ApiResponse<PasswordRecoveryTokenResponse>.ApiResponseFail("Tên tài khoản này đã được sử dụng!");
				}
				// case 2: check email
				var EmployeeDb = _repositoryEmployee.GetEmployeeByEmail(registerRequest.Email);
				if (EmployeeDb != null)
				{
					return ApiResponse<PasswordRecoveryTokenResponse>.ApiResponseFail("Email này đã được sửa dụng!");
				}
				// case 3: check phonenumber
				EmployeeDb = _repositoryEmployee.GetEmployeeByPhoneNumber(registerRequest.PhoneNumber);
				if (EmployeeDb != null)
				{
					return ApiResponse<PasswordRecoveryTokenResponse>.ApiResponseFail("Số điện thoại này đã được sử dụng!");
				}
				var user = _mapper.Map<DtoUser>(registerRequest);
				user.IsDeleted = true; // Confirm pin code change to false
				var passwordHash = HashPasword(registerRequest.Password);
				user.PasswordHash = passwordHash;
				// insert to table user
				var userAfterInsert = _repositoryUser.InsertUser(user);
				// insert to table Employee
				var Employee = _mapper.Map<DtoEmployee>(registerRequest);
				Employee.UserId = user.Id;
				Employee.IsDeleted = true; // confirm pin code change to false
				_repositoryEmployee.InsertEmployee(Employee);
				// handle send email
				var obj = new DtoPasswordRecoveryToken()
				{
					CreatedBy = userAfterInsert.Id,
					PinCode = GeneratePinCode(),
					Expires = DateTime.Now.AddMinutes(2),
					UserId = userAfterInsert.Id
				};
				// send pin code for user
				var passwordRecoveryToken = _repositoryRecovery.InsertPasswordRecoveryToken(obj);
				var passwordRecoveryTokenResponse = _mapper.Map<PasswordRecoveryTokenResponse>(passwordRecoveryToken);
				var link = "<a href=[LINK]>Nhấp vào link</a>".Replace("[LINK]", $"'http://{registerRequest.UrlRequest}/Auth/ConfirmRegister?userId={Employee.UserId}&email={registerRequest.Email}'");
				string body = $"Mã xác nhận để tạo tài khoản mới của bạn là là: <b>{passwordRecoveryToken.PinCode}</b><br/>" + link;
				var responseMail = await _emailService.SendEmail(registerRequest.Email, body, "Xác nhận tạo tài khoản mới từ Tiêm chủng VNVC");
				if (responseMail == false)
				{
					return ApiResponse<PasswordRecoveryTokenResponse>.ApiResponseFail("Không thể gửi email được");
				}
				return ApiResponse<PasswordRecoveryTokenResponse>.ApiResponseSuccess(passwordRecoveryTokenResponse);
			}
			catch (Exception ec)
			{
				_logger.LogError($"|{DateTime.Now}|:  Exception error: {ec.Message}");
				throw ec;
			}
		}

		public async Task<ApiResponse<PasswordRecoveryTokenResponse>> ForgetPassword(ForgetPasswordRequest forgetPasswordRequest)
		{
			try
			{
				var Employee = _repositoryEmployee.GetEmployeeByEmail(forgetPasswordRequest.Email);
				if (Employee == null)
				{
					return ApiResponse<PasswordRecoveryTokenResponse>.ApiResponseFail("Email này không tồn tại");
				}
				var obj = new DtoPasswordRecoveryToken()
				{
					CreatedBy = Employee.UserId,
					PinCode = GeneratePinCode(),
					Expires = DateTime.Now.AddMinutes(2),
					UserId = Employee.UserId
				};
				// send pin code for Employee
				var passwordRecoveryToken = _repositoryRecovery.InsertPasswordRecoveryToken(obj);
				var passwordRecoveryTokenResponse = _mapper.Map<PasswordRecoveryTokenResponse>(passwordRecoveryToken);
				var link = "<a href=[LINK]>Nhấp vào link</a>".Replace("[LINK]", $"'http://{forgetPasswordRequest.UrlRequest}/Auth/ConfirmPinCode?userId={Employee.UserId}&email={forgetPasswordRequest.Email}'");
				string body = $"Mã xác nhận để lấy mật khẩu mới của bạn là: <b>{passwordRecoveryToken.PinCode}</b><br/>" + link;
				var responseMail = await _emailService.SendEmail(forgetPasswordRequest.Email, body, "Mã xác thực từ Tiêm chủng VNVC - cập nhật mật khẩu mới từ Tiêm chủng VNVC");
				if (responseMail == false)
				{
					return ApiResponse<PasswordRecoveryTokenResponse>.ApiResponseFail("Can not send email");
				}
				return ApiResponse<PasswordRecoveryTokenResponse>.ApiResponseSuccess(passwordRecoveryTokenResponse);
			}
			catch (Exception ec)
			{
				_logger.LogError($"|{DateTime.Now}|:  Exception error: {ec.Message}");

				throw ec;
			}
		}

		public async Task<ApiResponse<string>> ConfirmPincode(ConfirmPinCodeRequest confirmPinCodeRequest)
		{
			try
			{
				var obj = _repositoryRecovery.CheckPincode(confirmPinCodeRequest.Pincode, confirmPinCodeRequest.UserId);
				if (obj == null)
				{
					return ApiResponse<string>.ApiResponseFail("Mã xác nhận không hợp lệ", null);
				}
				if (obj.Expires < DateTime.Now)
				{
					_repositoryRecovery.DeletePincode(obj);
					return ApiResponse<string>.ApiResponseFail("Mã xác nhận này đã hết hạn", null);
				}

				//TODO: send email new password for usser
				var newPassword = Convert.ToBase64String(RandomNumberGenerator.GetBytes(12)).Substring(10);
				var passwordHash = HashPasword(newPassword);
				var user = _repositoryUser.GetUserByUserId(obj.UserId);
				user.PasswordHash = passwordHash;
				string body = $"Mật khẩu mới của bạn là: <b>{newPassword}</b><br/>" +
					$"Hãy đăng nhập và đổi mật khẩu";
				var Employee = _repositoryEmployee.GetEmployeeByUserId(obj.UserId);
				var responseMail = await _emailService.SendEmail(Employee.Email, body, "Tiêm chủng VNVC - Cập nhật mật khẩu mới");
				if (responseMail == false)
				{
					return ApiResponse<string>.ApiResponseFail("Can not send email", null);
				}
				//
				_repositoryUser.UpdateUser(user);
				_repositoryRecovery.DeletePincode(obj);
				return ApiResponse<string>.ApiResponseSuccess("Đã gửi mật khẩu vào email của bạn, vui lòng kiểm tra email", null);
			}
			catch (Exception ec)
			{
				_logger.LogError($"|{DateTime.Now}|:  Exception error: {ec.Message}");

				throw ec;
			}
		}

		public async Task<ApiResponse<string>> ChangePassword(ChangePasswordRequest changePasswordRequest)
		{
			try
			{
				if (!IsAuthorize(changePasswordRequest.UserId))
				{
					return ApiResponse<string>.ApiResponseFail("Not authorize access token", null);
				}
				var user = _repositoryUser.GetUserByUserId(changePasswordRequest.UserId);
				if (user == null)
				{
					return ApiResponse<string>.ApiResponseFail("Không tìm thấy tài khỏan", null);
				}

				var checkPass = VerifyPassword(changePasswordRequest.OldPassword, user.PasswordHash);
				if (!checkPass)
				{
					return ApiResponse<string>.ApiResponseFail("Mật khẩu cũ sai", null);
				}
				var passwordHash = HashPasword(changePasswordRequest.NewPassword);
				user.PasswordHash = passwordHash;
				user.UpdatedTime = DateTime.Now;

				_repositoryUser.UpdateUser(user);

				return ApiResponse<string>.ApiResponseSuccess("Cập nhật mật khẩu thành công!", null);
			}
			catch (Exception ec)
			{
				_logger.LogError($"|{DateTime.Now}|:  Exception error: {ec.Message}");

				throw ec;
			}
		}

		#region Private

		private bool IsAuthorize(string userId)
		{
			var jwtTokenHandler = new JwtSecurityTokenHandler();
			var secretKey = Encoding.UTF8.GetBytes(_configuration["Jwt:Key"] ?? throw new Exception("Jwt key null"));
			var tokenValidateParam = new TokenValidationParameters
			{
				ValidateIssuer = false,
				ValidateAudience = false,
				ValidateIssuerSigningKey = true,
				IssuerSigningKey = new SymmetricSecurityKey(secretKey),
				ClockSkew = TimeSpan.Zero,
				ValidateLifetime = false
			};
			// get access token in cookies
			var accessToken = _context.HttpContext.Request.Cookies["X-Access-Token"] ?? throw new Exception("AccessToken null");
			var tokenInVerification = jwtTokenHandler.ValidateToken(accessToken, tokenValidateParam, out var validatedToken);
			// get user id from jwt
			var userIdInAccessToken = tokenInVerification.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
			if (userIdInAccessToken != userId)
			{
				return false;
			}
			return true;
		}

		private string GeneratePinCode()
		{
			Random random = new Random();
			int randomNumber = random.Next(100000, 1000000); // Tạo số ngẫu nhiên từ 100000 đến 999999 (bao gồm cả 100000 và 999999)
			return randomNumber.ToString();
		}

		private DateTime ConvertUnixTimeToDateTime(long utcExpireDate)
		{
			var dateTimeInterval = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
			dateTimeInterval = dateTimeInterval.AddSeconds(utcExpireDate).ToUniversalTime();
			return dateTimeInterval;
		}

		private string HashPasword(string password)
		{
			return BCrypt.Net.BCrypt.HashPassword(password);
		}

		private bool VerifyPassword(string password, string hash)
		{
			return BCrypt.Net.BCrypt.Verify(password, hash);
		}

		private string GenerateAccessToken(DtoUser user)
		{
			var key = Encoding.UTF8.GetBytes(_configuration["Jwt:Key"] ?? throw new Exception("Jwt key null"));
			var claims = new List<Claim>
			{
				new Claim(ClaimTypes.Name, user.Username),
				new Claim("UserId", user.Id),
				new Claim(ClaimTypes.Role, user.Role)
			};
			var expires = DateTime.UtcNow.AddHours(1);
			SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor()
			{
				Subject = new ClaimsIdentity(claims),
				Expires = expires,
				SigningCredentials = new SigningCredentials(
					new SymmetricSecurityKey(key),
					SecurityAlgorithms.HmacSha512Signature),
			};
			JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
			var token = tokenHandler.CreateToken(tokenDescriptor);
			var accessToken = tokenHandler.WriteToken(token);
			var cookieOption = new CookieOptions()
			{
				HttpOnly = true,
				IsEssential = true,
				Secure = false,
				SameSite = SameSiteMode.Strict,
				Expires = DateTime.UtcNow.AddDays(15)
			};
			_context.HttpContext.Response.Cookies.Append("X-Access-Token", accessToken, cookieOption);
			_context.HttpContext.Response.Cookies.Append("X-User-Id", user.Id, cookieOption);
			return accessToken;
		}

		private string GenerateRefeshToken(DtoUser user)
		{
			var refeshToken = new DtoRefeshToken()
			{
				RefeshToken = Convert.ToBase64String(RandomNumberGenerator.GetBytes(64)).Replace('+', '_').Replace('/', '_'),
				Expires = DateTime.UtcNow.AddHours(3),
				UserId = user.Id,
				CreatedBy = user.Id
			};
			// Delete old refesh token in db
			var oldRefeshToken = _repositoryRefeshToken.GetRefeshTokenByUserId(user.Id);
			if (oldRefeshToken != null)
			{
				_repositoryRefeshToken.RemoveRefeshToken(oldRefeshToken);
			}
			// Add new refesh token
			_repositoryRefeshToken.InsertRefeshToken(refeshToken);

			var cookieOption = new CookieOptions()
			{
				Expires = DateTime.UtcNow.AddDays(1),
				SameSite = SameSiteMode.Strict
			};
			_context.HttpContext.Response.Cookies.Append("X-RefeshToken", refeshToken.RefeshToken, cookieOption);
			return refeshToken.RefeshToken;
		}

		public async Task<ApiResponse<DtoUser>> CreateAccountForEmployee(DtoEmployee employee)
		{
			try
			{
			
				// case 2: check email
				var EmployeeDb = _repositoryEmployee.GetEmployeeByEmail(employee.Email);
				if (EmployeeDb != null)
				{
					return ApiResponse<DtoUser>.ApiResponseFail("Email này đã được sửa dụng!");
				}
				// case 3: check phonenumber
				EmployeeDb = _repositoryEmployee.GetEmployeeByPhoneNumber(employee.Phone);
				if (EmployeeDb != null)
				{
					return ApiResponse<DtoUser>.ApiResponseFail("Số điện thoại này đã được sử dụng!");
				}
				var dtoUser = new DtoUser();
				string email = employee.Email;
				int atIndex = email.IndexOf('@');
				string userName = email.Substring(0, atIndex);
				dtoUser.Username = userName;
				var newPassword = Convert.ToBase64String(RandomNumberGenerator.GetBytes(12)).Substring(10);
				var passwordHash = HashPasword(newPassword);
				dtoUser.PasswordHash = passwordHash;
				dtoUser.Role = employee.IdCategoryPosition;
				//TODO: send email new password for usser
				string body = $"Xin chào bạn: {employee.FullName}, chào mừng bạn đến với hệ thống tiêm chủng VNVC <br/>" +
					$"Tài khoản của bạn là: <b>{userName}</b><br/>" +
					$"Mật khẩu của bạn là: <b>{newPassword}</b><br/>" +
					$"Hãy đăng nhập và đổi mật khẩu nhé";
				var responseMail = await _emailService.SendEmail(email, body, "Tiêm chủng VNVC - Cung cấp tài khoản nhân viên");
				if (responseMail == false)
				{
					return ApiResponse<DtoUser>.ApiResponseFail("Can not send email", null);
				}
				//
				var user = _repositoryUser.InsertUser(dtoUser);
				return ApiResponse<DtoUser>.ApiResponseSuccess("Tạo tài khoản cho nhân viên thành công", user);
			}
			catch (Exception ec)
			{
				throw ec;
			}
		}

		#endregion Private
	}
}