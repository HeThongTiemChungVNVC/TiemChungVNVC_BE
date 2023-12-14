using BLL.Common;
using BLL.Requests;
using BLL.Responses;

namespace BLL.Services.Constracts
{
	public interface IAuthService
	{
		Task<ApiResponse<UserResponse>> Login(LoginRequest loginRequest);

		Task<ApiResponse<PasswordRecoveryTokenResponse>> Register(RegisterRequest registerRequest);

		Task<ApiResponse<UserResponse>> RefeshToken(string refeshToken);

		Task<ApiResponse<InformationResponse>> Information(string userId);

		Task<ApiResponse<string>> UpdateInformation(UpdateInformationRequest updateInformationRequest);

		Task<ApiResponse<PasswordRecoveryTokenResponse>> ForgetPassword(ForgetPasswordRequest forgetPasswordRequest);

		Task<ApiResponse<string>> ConfirmPincode(ConfirmPinCodeRequest confirmPinCodeRequest);

		Task<ApiResponse<string>> ChangePassword(ChangePasswordRequest changePasswordRequest);

		Task<ApiResponse<string>> ConfirmRegister(ConfirmPinCodeRequest confirmPinCodeRequest);
	}
}