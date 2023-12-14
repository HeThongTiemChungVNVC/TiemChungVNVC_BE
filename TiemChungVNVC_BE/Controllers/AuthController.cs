using BLL.Common;
using BLL.Requests;
using BLL.Services.Constracts;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace TiemChungVNVC_BE.Controllers
{
	[Route("api/auth")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private readonly IAuthService _authService;

		public AuthController(IAuthService authService)
		{
			_authService = authService;
		}

		[HttpPost("login")]
		[ProducesResponseType(typeof(LoginRequest), (int)HttpStatusCode.OK)]
		public async Task<IActionResult> Login(LoginRequest loginRequest)
		{
			try
			{
				var response = await _authService.Login(loginRequest);
				if (!response.IsSuccess)
				{
					return NotFound(response);
				}
				return Ok(response);
			}
			catch (Exception ec)
			{
				return BadRequest(new ApiResponse<string>(false, "call api fail", ec.Message));
			}
		}

		[HttpPost("register")]
		[ProducesResponseType(typeof(RegisterRequest), (int)HttpStatusCode.OK)]
		public async Task<IActionResult> Register(RegisterRequest registerRequest)
		{
			try
			{
				var response = await _authService.Register(registerRequest);
				if (!response.IsSuccess)
				{
					return NotFound(response);
				}
				return Ok(response);
			}
			catch (Exception ec)
			{
				return BadRequest(new ApiResponse<string>(false, "call api fail", ec.Message));
			}
		}

		[HttpPost("register/confirm")]
		public async Task<IActionResult> ConfirmRegister(ConfirmPinCodeRequest confirmPinCodeRequest)
		{
			try
			{
				var response = await _authService.ConfirmRegister(confirmPinCodeRequest);

				return Ok(response);
			}
			catch (Exception ec)
			{
				return BadRequest(new ApiResponse<string>(false, "call api fail", ec.Message));
			}
		}

		[HttpPost("forget-password")]
		public async Task<IActionResult> ForgetPassword(ForgetPasswordRequest forgetPasswordRequest)
		{
			try
			{
				var response = await _authService.ForgetPassword(forgetPasswordRequest);
				if (!response.IsSuccess)
				{
					return NotFound(response);
				}
				return Ok(response);
			}
			catch (Exception ec)
			{
				return BadRequest(new ApiResponse<string>(false, "call api fail", ec.Message));
			}
		}

		[HttpPost("forget-password/confirm")]
		public async Task<IActionResult> ConfirmPincode(ConfirmPinCodeRequest confirmPinCodeRequest)
		{
			try
			{
				var response = await _authService.ConfirmPincode(confirmPinCodeRequest);

				return Ok(response);
			}
			catch (Exception ec)
			{
				return BadRequest(new ApiResponse<string>(false, "Call api fail", ec.Message));
			}
		}

		[HttpPost("refesh-token")]
		public async Task<IActionResult> RefeshToken(string refeshToken)
		{
			try
			{
				var response = await _authService.RefeshToken(refeshToken);
				if (!response.IsSuccess)
				{
					return NotFound(response);
				}
				return Ok(response);
			}
			catch (Exception ec)
			{
				return BadRequest(new ApiResponse<string>(false, "Call api fail", ec.Message));
			}
		}
	}
}