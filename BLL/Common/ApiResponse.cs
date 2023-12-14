namespace BLL.Common
{
	public class ApiResponse<T>
	{
		public ApiResponse(bool isSuccess, string message, T data)
		{
			IsSuccess = isSuccess;
			Message = message;
			Data = data;
		}

		public static ApiResponse<T> ApiResponseFail(string? message)
		{
			return new ApiResponse<T>(false, message ?? "Fail", default(T));
		}

		public static ApiResponse<T> ApiResponseFail(string? message, T data)
		{
			return new ApiResponse<T>(false, message ?? "Fail", default(T));
		}

		public static ApiResponse<T> ApiResponseFail()
		{
			return new ApiResponse<T>(false, "Fail", default(T));
		}

		public static ApiResponse<T> ApiResponseSuccess(string? message, T data)
		{
			return new ApiResponse<T>(true, message ?? "Success", data);
		}

		public static ApiResponse<T> ApiResponseSuccess(T data)
		{
			return new ApiResponse<T>(true, "Success", data);
		}

		public bool IsSuccess { get; set; }
		public string Message { get; set; }
		public T Data { get; set; }
	}
}