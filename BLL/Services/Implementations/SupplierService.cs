using AutoMapper;
using BLL.Common;
using BLL.Requests;
using BLL.Responses;
using BLL.Services.Constracts;
using DAL.Dtos;
using Repository.DbContexts;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Implementations
{
	public class SupplierService : ISupplierService
	{
		private readonly IMapper _mapper;
		private readonly IRepository<DtoSupplier> repository;
		private VNVCContext _context;

		public SupplierService(IMapper mapper, VNVCContext context, IRepository<DtoSupplier> repository)
		{
			_mapper = mapper;
			_context = context;
			this.repository = repository;
		}

		public async Task<ApiResponse<string>> CreateSupplier(CreateSupplierRequest createSupplierRequest)
		{
			try
			{
				var supplier = _mapper.Map<DtoSupplier>(createSupplierRequest);
				repository.Insert(supplier);
				return ApiResponse<string>.ApiResponseSuccess("Thêm thành công", "Thêm thành công");
			}
			catch (Exception ec)
			{
				return ApiResponse<string>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<string>> DeleteSupplier(string idSupplier)
		{
			try
			{
				var entity = repository.GetAll().FirstOrDefault(x => x.Id == idSupplier);
				if (entity == null)
				{
					return ApiResponse<string>.ApiResponseFail("Nhà cung cấp này không tồn tại", "Nhà cung cấp này không tồn tại");
				}
				entity.IsDeleted = true;
				repository.Update(entity);
				return ApiResponse<string>.ApiResponseSuccess("Xóa thành công", "Xóa thành công");
			}
			catch (Exception ec)
			{
				return ApiResponse<string>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<SupplierResponse>> GetSupplier(string idSupplier)
		{
			try
			{
				var entity = repository.GetAll().FirstOrDefault(x => x.Id == idSupplier && !x.IsDeleted);
				if (entity == null)
				{
					return ApiResponse<SupplierResponse>.ApiResponseFail("Nhà cung cấp này không tồn tại");
				}
				var response = _mapper.Map<SupplierResponse>(entity);
				return ApiResponse<SupplierResponse>.ApiResponseSuccess(response);
			}
			catch (Exception ec)
			{
				return ApiResponse<SupplierResponse>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<List<SupplierResponse>>> GetSuppliers()
		{
			try
			{
				var entity = repository.GetAll().Where(x => !x.IsDeleted).ToList();
				if (entity.Count() == 0)
				{
					return ApiResponse<List<SupplierResponse>>.ApiResponseFail("Chưa có dữ liệu");
				}
				var response = entity.Select(_mapper.Map<DtoSupplier, SupplierResponse>).ToList();
				return ApiResponse<List<SupplierResponse>>.ApiResponseSuccess(response);
			}
			catch (Exception ec)
			{
				return ApiResponse<List<SupplierResponse>>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<string>> UpdateSupplier(UpdateSupplierRequest updateSupplierRequest)
		{
			try
			{
				var entity = repository.GetAll().FirstOrDefault(x => x.Id == updateSupplierRequest.Id);
				if (entity == null)
				{
					return ApiResponse<string>.ApiResponseFail("Nhà cung cấp này không tồn tại", "Nhà cung cấp này không tồn tại");
				}
				if (!string.IsNullOrEmpty(updateSupplierRequest.Address))
				{
					entity.Address = updateSupplierRequest.Address;
				}
				if (!string.IsNullOrEmpty(updateSupplierRequest.NameSupplier))
				{
					entity.NameSupplier = updateSupplierRequest.NameSupplier;
				}
				if (!string.IsNullOrEmpty(updateSupplierRequest.Phone))
				{
					entity.Phone = updateSupplierRequest.Phone;
				}
				if (!string.IsNullOrEmpty(updateSupplierRequest.Email))
				{
					entity.Email = updateSupplierRequest.Email;
				}
				entity.UpdatedTime = DateTime.Now;
				repository.Update(entity);
				return ApiResponse<string>.ApiResponseSuccess("Cập nhật thành công", "Cập nhật thành công");
			}
			catch (Exception ec)
			{
				return ApiResponse<string>.ApiResponseFail(ec.Message);
			}
		}
	}
}