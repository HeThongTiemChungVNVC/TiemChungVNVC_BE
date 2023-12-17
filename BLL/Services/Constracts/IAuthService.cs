﻿using BLL.Common;
using BLL.Requests;
using BLL.Responses;
using DAL.Dtos;

namespace BLL.Services.Constracts
{
	public interface IAuthService
	{
		Task<ApiResponse<UserResponse>> Login(LoginRequest loginRequest);

		Task<ApiResponse<UserResponse>> RefeshToken(string refeshToken);

		Task<ApiResponse<PasswordRecoveryTokenResponse>> ForgetPassword(ForgetPasswordRequest forgetPasswordRequest);

		Task<ApiResponse<string>> ConfirmPincode(ConfirmPinCodeRequest confirmPinCodeRequest);

		Task<ApiResponse<string>> ChangePassword(ChangePasswordRequest changePasswordRequest);

		Task<ApiResponse<DtoUser>> CreateAccountForEmployee(DtoEmployee employee);
	}
}