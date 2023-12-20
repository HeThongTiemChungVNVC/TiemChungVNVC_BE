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
	public interface ICustomerService
	{
		Task<ApiResponse<string>> CreateCustomer(CreateCustomerRequest createCustomerRequest);

		Task<ApiResponse<List<CustomerResponse>>> GetCustomers();

		Task<ApiResponse<CustomerResponse>> GetCustomer(string idCustomer);

		Task<ApiResponse<CustomerResponse>> GetCustomerByCodeCustomer(string CodeCustomer);

		Task<ApiResponse<string>> UpdateCustomer(UpdateCustomerRequest updateCustomerRequest);

		Task<ApiResponse<string>> DeleteCustomer(string idCustomer);
	}
}