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
        private readonly InformationRepository _repositoryInformation;
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
            InformationRepository repositoryInformation,
            RefeshTokenRepository repositoryRefeshToken,
            RecoveryTokenRepository repositoryRecovery,
            IEmailService emailService)
        {
            _configuration = configuration;
            _context = context;
            _mapper = mapper;
            _logger = logger;
            _repositoryUser = repositoryUser;
            _repositoryInformation = repositoryInformation;
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
                    var information = _repositoryInformation.GetInformationByEmail(loginRequest.Username);
                    if (information == null)
                    {
                        // case 3: use phonenumber
                        information = _repositoryInformation.GetInformationByPhoneNumber(loginRequest.Username);
                        if (information == null)
                        {
                            return ApiResponse<UserResponse>.ApiResponseFail("Tài khoản hoặc mật khẩu không chính xác!");
                        }
                        else
                        {
                            user = information.User;
                        }
                    }
                    else
                    {
                        user = information.User;
                    }
                }
                if (VerifyPassword(loginRequest.Password, user.PasswordHash))
                {
                    var information = _repositoryInformation.GetInformationByUserId(user.Id);
                    var userResponse = _mapper.Map<UserResponse>(information);
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

                var information = _repositoryInformation.GetInformationByUserId(user.Id);
                var userResponse = _mapper.Map<UserResponse>(information);
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
                var informationDb = _repositoryInformation.GetInformationByEmail(registerRequest.Email);
                if (informationDb != null)
                {
                    return ApiResponse<PasswordRecoveryTokenResponse>.ApiResponseFail("Email này đã được sửa dụng!");
                }
                // case 3: check phonenumber
                informationDb = _repositoryInformation.GetInformationByPhoneNumber(registerRequest.PhoneNumber);
                if (informationDb != null)
                {
                    return ApiResponse<PasswordRecoveryTokenResponse>.ApiResponseFail("Số điện thoại này đã được sử dụng!");
                }
                var user = _mapper.Map<DtoUser>(registerRequest);
                user.IsDeleted = true; // Confirm pin code change to false
                var passwordHash = HashPasword(registerRequest.Password);
                user.PasswordHash = passwordHash;
                // insert to table user
                var userAfterInsert = _repositoryUser.InsertUser(user);
                // insert to table information
                var information = _mapper.Map<DtoInformation>(registerRequest);
                information.UserId = user.Id;
                information.IsDeleted = true; // confirm pin code change to false
                _repositoryInformation.InsertInformation(information);
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
                var link = "<a href=[LINK]>Nhấp vào link</a>".Replace("[LINK]", $"'http://{registerRequest.UrlRequest}/Auth/ConfirmRegister?userId={information.UserId}&email={registerRequest.Email}'");
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

        public async Task<ApiResponse<InformationResponse>> Information(string userId)
        {
            try
            {
                if (!IsAuthorize(userId))
                {
                    throw new Exception("Not authorize access token");
                }
                var information = _repositoryInformation.GetInformationByUserId(userId);
                var informationResponse = _mapper.Map<InformationResponse>(information);
                return ApiResponse<InformationResponse>.ApiResponseSuccess(informationResponse);
            }
            catch (Exception ec)
            {
                _logger.LogError($"|{DateTime.Now}|:  Exception error: {ec.Message}");
                return ApiResponse<InformationResponse>.ApiResponseFail(ec.Message);
            }
        }

        public async Task<ApiResponse<string>> UpdateInformation(UpdateInformationRequest updateInformationRequest)
        {
            try
            {
                if (!IsAuthorize(updateInformationRequest.UserId))
                {
                    throw new Exception("Not authorize access token");
                }
                //  check phonenumber
                if (!_repositoryInformation.UpdateInformation(
                    updateInformationRequest.UserId,
                    updateInformationRequest.FullName,
                    updateInformationRequest.Gender,
                    updateInformationRequest.Email,
                    updateInformationRequest.PhoneNumber,
                    updateInformationRequest.Address,
                    updateInformationRequest.Dob
                    ))
                {
                    return ApiResponse<string>.ApiResponseFail("Không thể cập nhật thông tin ngay lúc này, vui lòng thử lại.");
                }
                return ApiResponse<string>.ApiResponseSuccess("Cập nhật thành công");
            }
            catch (Exception ec)
            {
                _logger.LogError($"|{DateTime.Now}|:  Exception error: {ec.Message}");
                return ApiResponse<string>.ApiResponseFail(ec.Message);
            }
        }

        public async Task<ApiResponse<PasswordRecoveryTokenResponse>> ForgetPassword(ForgetPasswordRequest forgetPasswordRequest)
        {
            try
            {
                var information = _repositoryInformation.GetInformationByEmail(forgetPasswordRequest.Email);
                if (information == null)
                {
                    return ApiResponse<PasswordRecoveryTokenResponse>.ApiResponseFail("Email này không tồn tại");
                }
                var obj = new DtoPasswordRecoveryToken()
                {
                    CreatedBy = information.UserId,
                    PinCode = GeneratePinCode(),
                    Expires = DateTime.Now.AddMinutes(2),
                    UserId = information.UserId
                };
                // send pin code for information
                var passwordRecoveryToken = _repositoryRecovery.InsertPasswordRecoveryToken(obj);
                var passwordRecoveryTokenResponse = _mapper.Map<PasswordRecoveryTokenResponse>(passwordRecoveryToken);
                var link = "<a href=[LINK]>Nhấp vào link</a>".Replace("[LINK]", $"'http://{forgetPasswordRequest.UrlRequest}/Auth/ConfirmPinCode?userId={information.UserId}&email={forgetPasswordRequest.Email}'");
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
                var information = _repositoryInformation.GetInformationByUserId(obj.UserId);
                var responseMail = await _emailService.SendEmail(information.Email, body, "Shopee food - Cập nhật mật khẩu mới");
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

        public async Task<ApiResponse<string>> ConfirmRegister(ConfirmPinCodeRequest confirmPinCodeRequest)
        {
            try
            {
                var obj = _repositoryRecovery.CheckPincodeRegister(confirmPinCodeRequest.Pincode, confirmPinCodeRequest.UserId);
                if (obj == null)
                {
                    return ApiResponse<string>.ApiResponseFail("Mã xác nhận sai", null);
                }
                if (obj.Expires < DateTime.Now)
                {
                    _repositoryRecovery.DeletePincode(obj);
                    return ApiResponse<string>.ApiResponseFail("Mã xác nhận đã hết hạn", null);
                }
                // allow user use account
                var user = _repositoryUser.GetUserByUserIdIncludeDeleted(obj.UserId);
                if (user == null)
                {
                    return ApiResponse<string>.ApiResponseFail("Người dùng không tồn tại", null);
                }
                user.IsDeleted = false;
                var information = _repositoryInformation.GetInformationByUserIdInludeDeleted(obj.UserId);
                if (information == null)
                {
                    return ApiResponse<string>.ApiResponseFail("Người dùng không tồn tại", null);
                }
                information.IsDeleted = false;
                user.PasswordHash = user.PasswordHash;
                _repositoryUser.UpdateUser(user);
                _repositoryRecovery.DeletePincode(obj);
                return ApiResponse<string>.ApiResponseSuccess("Tạo tài khoản thành công, đăng nhập ngay.", null);
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

        #endregion Private
    }
}