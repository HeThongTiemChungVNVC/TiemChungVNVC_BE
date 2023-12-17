using AutoMapper;
using BLL.Common;
using BLL.Requests;
using BLL.Responses;
using BLL.Services.Constracts;
using DAL.Dtos;
using Repository.DbContexts;
using Repository.Repository;

namespace BLL.Services.Implementations
{
	public class CustomerService : ICustomerService
	{
		private readonly IMapper _mapper;
		private readonly IRepository<DtoCustomer> repository;
		private VNVCContext _context;

		public CustomerService(IMapper mapper, VNVCContext context, IRepository<DtoCustomer> repository)
		{
			_mapper = mapper;
			_context = context;
			this.repository = repository;
		}

		public static string GetNumericPart(Guid guid)
		{
			// Convert the GUID to a string and remove non-numeric characters
			string numericPart = new string(guid.ToString().Where(char.IsDigit).ToArray());

			// Ensure the length is 8 by taking the first 8 characters
			numericPart = numericPart.Length >= 6 ? numericPart.Substring(0, 6) : numericPart;

			return numericPart;
		}

		public async Task<ApiResponse<string>> CreateCustomer(CreateCustomerRequest createCustomerRequest)
		{
			try
			{
				var customer = _mapper.Map<DtoCustomer>(createCustomerRequest);
				while (true)
				{
					var codeCustomer = "KH" + GetNumericPart(Guid.NewGuid());
					if (repository.GetAll().FirstOrDefault(x => x.CodeCustomer == codeCustomer) == null)
					{
						customer.CodeCustomer = codeCustomer;
						break;
					}
				}
				repository.Insert(customer);
				return ApiResponse<string>.ApiResponseSuccess("Thêm thành công");
			}
			catch (Exception ec)
			{
				return ApiResponse<string>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<string>> DeleteCustomer(string idCustomer)
		{
			try
			{
				var entity = repository.GetAll().FirstOrDefault(x => x.Id == idCustomer);
				if (entity == null)
				{
					return ApiResponse<string>.ApiResponseFail("Khách hàng này không tồn tại");
				}
				entity.IsDeleted = true;
				repository.Update(entity);
				return ApiResponse<string>.ApiResponseSuccess("Xóa thành công");
			}
			catch (Exception ec)
			{
				return ApiResponse<string>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<CustomerResponse>> GetCustomer(string idCustomer)
		{
			try
			{
				var entity = repository.GetAll().FirstOrDefault(x => x.Id == idCustomer && !x.IsDeleted);
				if (entity == null)
				{
					return ApiResponse<CustomerResponse>.ApiResponseFail("Khách hàng này không tồn tại");
				}
				var response = _mapper.Map<CustomerResponse>(entity);
				return ApiResponse<CustomerResponse>.ApiResponseSuccess(response);
			}
			catch (Exception ec)
			{
				return ApiResponse<CustomerResponse>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<List<CustomerResponse>>> GetCustomers()
		{
			try
			{
				var entity = repository.GetAll().Where(x => !x.IsDeleted).ToList();
				if (entity.Count() == 0)
				{
					return ApiResponse<List<CustomerResponse>>.ApiResponseFail("Chưa có dữ liệu");
				}
				var response = entity.Select(_mapper.Map<DtoCustomer, CustomerResponse>).ToList();
				return ApiResponse<List<CustomerResponse>>.ApiResponseSuccess(response);
			}
			catch (Exception ec)
			{
				return ApiResponse<List<CustomerResponse>>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<string>> UpdateCustomer(UpdateCustomerRequest updateCustomerRequest)
		{
			try
			{
				var entity = repository.GetAll().FirstOrDefault(x => x.Id == updateCustomerRequest.Id);
				if (entity == null)
				{
					return ApiResponse<string>.ApiResponseFail("Khách hàng này không tồn tại");
				}
				if (!string.IsNullOrEmpty(updateCustomerRequest.FullName))
				{
					entity.FullName = updateCustomerRequest.FullName;
				}

				entity.DateOfBirth = updateCustomerRequest.DateOfBirth;
				entity.Gender = updateCustomerRequest.Gender;
				if (!string.IsNullOrEmpty(updateCustomerRequest.Address))
				{
					entity.Address = updateCustomerRequest.Address;
				}
				if (!string.IsNullOrEmpty(updateCustomerRequest.Phone))
				{
					entity.Phone = updateCustomerRequest.Phone;
				}
				if (!string.IsNullOrEmpty(updateCustomerRequest.Email))
				{
					entity.Email = updateCustomerRequest.Email;
				}
				entity.UpdatedTime = DateTime.Now;
				repository.Update(entity);
				return ApiResponse<string>.ApiResponseSuccess("Cập nhật thành công");
			}
			catch (Exception ec)
			{
				return ApiResponse<string>.ApiResponseFail(ec.Message);
			}
		}
	}
}