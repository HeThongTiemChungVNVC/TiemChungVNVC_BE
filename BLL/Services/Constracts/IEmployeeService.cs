using BLL.Common;
using BLL.Requests;
using BLL.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Constracts
{
	public interface IEmployeeService
	{
		Task<ApiResponse<string>> CreateEmployee(CreateEmployeeRequest createEmployeeRequest);

		Task<ApiResponse<List<EmployeeResponse>>> GetEmployees();

		Task<ApiResponse<EmployeeResponse>> GetEmployee(string idEmployee);

		Task<ApiResponse<EmployeeResponse>> GetEmployeeByUserId(string userId);

		Task<ApiResponse<string>> UpdateEmployee(UpdateEmployeeRequest updateEmployeeRequest);

		Task<ApiResponse<string>> DeleteEmployee(string idEmployee);
	}
}