using AutoMapper;
using BLL.Common;
using BLL.Requests;
using BLL.Responses;
using BLL.Services.Constracts;
using DAL.Dtos;
using Microsoft.EntityFrameworkCore;
using Repository.DbContexts;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Implementations
{
	public class PriceVaccineService : IPriceVaccineService
	{
		private readonly IMapper _mapper;
		private readonly IRepository<DtoPriceVaccine> repository;
		private VNVCContext _context;

		public PriceVaccineService(IMapper mapper, VNVCContext context, IRepository<DtoPriceVaccine> repository)
		{
			_mapper = mapper;
			_context = context;
			this.repository = repository;
		}

		public async Task<ApiResponse<string>> CreatePriceVaccine(CreatePriceVaccineRequest createPriceVaccineRequest)
		{
			try
			{
				var price = _context.PriceVaccines.FirstOrDefault(x => x.IdVaccineBacth == createPriceVaccineRequest.IdVaccineBacth);
				if (price == null)
				{
					var dtoPrice = _mapper.Map<DtoPriceVaccine>(createPriceVaccineRequest);
					repository.Insert(dtoPrice);
				}
				else
				{
					price.CostPrice = createPriceVaccineRequest.CostPrice;
					price.PreOrderPrice = createPriceVaccineRequest.PreOrderPrice;
					price.RetailPrice = createPriceVaccineRequest.RetailPrice;
					price.UpdatedTime = DateTime.Now;
					price.IsDeleted = false;
					repository.Update(price);
				}
				return ApiResponse<string>.ApiResponseSuccess("Thêm thành công", "Thêm thành công");
			}
			catch (Exception ec)
			{
				return ApiResponse<string>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<string>> DeletePriceVaccine(string idPriceVaccine)
		{
			try
			{
				var entity = repository.GetAll().FirstOrDefault(x => x.Id == idPriceVaccine);
				if (entity == null)
				{
					return ApiResponse<string>.ApiResponseFail("Giá tiền vaccine này không tồn tại", "Giá tiền vaccine này không tồn tại");
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

		public async Task<ApiResponse<PriceVaccineResponse>> GetPriceVaccine(string idPriceVaccine)
		{
			try
			{
				var entity = repository.GetAll().AsQueryable().Include(x => x.VaccinceBatch).FirstOrDefault(x => x.Id == idPriceVaccine && !x.IsDeleted);
				if (entity == null)
				{
					return ApiResponse<PriceVaccineResponse>.ApiResponseFail("Giá tiền vaccine này không tồn tại");
				}
				var response = _mapper.Map<PriceVaccineResponse>(entity);
				return ApiResponse<PriceVaccineResponse>.ApiResponseSuccess(response);
			}
			catch (Exception ec)
			{
				return ApiResponse<PriceVaccineResponse>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<List<PriceVaccineResponse>>> GetPriceVaccines()
		{
			try
			{
				//var entity = repository.GetAll().AsQueryable().Include(x => x.VaccinceBatch).ThenInclude(x => x.Vaccine).Where(x => !x.IsDeleted).ToList();
				var entity = (from price in _context.PriceVaccines
							  join b in _context.VaccineBatches on price.IdVaccineBacth equals b.Id into _b
							  from b2 in _b.DefaultIfEmpty()
							  join v in _context.Vaccines on b2.VaccineId equals v.Id into _v
							  from v2 in _v.DefaultIfEmpty()
							  where !price.IsDeleted
							  select new PriceVaccineResponse
							  {
								  Id = price.Id,
								  CostPrice = price.CostPrice,
								  PreOrderPrice = price.PreOrderPrice,
								  RetailPrice = price.RetailPrice,
								  IdVaccineBacth = price.IdVaccineBacth,
								  VaccinceBatch = new VaccineBatchResponse()
								  {
									  Id = b2.Id,
									  CodeBatch = b2.CodeBatch,
									  Vaccine = new VaccineResponse()
									  {
										  Id = v2.Id,
										  NameVaccine = v2.NameVaccine
									  }
								  },
							  }
							  ).ToList();
				if (entity.Count() == 0)
				{
					return ApiResponse<List<PriceVaccineResponse>>.ApiResponseSuccess("Chưa có dữ liệu", null);
				}
				return ApiResponse<List<PriceVaccineResponse>>.ApiResponseSuccess(entity);
			}
			catch (Exception ec)
			{
				return ApiResponse<List<PriceVaccineResponse>>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<string>> UpdatePriceVaccine(UpdatePriceVaccineRequest updatePriceVaccineRequest)
		{
			try
			{
				var entity = repository.GetAll().FirstOrDefault(x => x.Id == updatePriceVaccineRequest.Id);
				if (entity == null)
				{
					return ApiResponse<string>.ApiResponseFail("Giá tiền vaccine này không tồn tại", "Giá tiền vaccine này không tồn tại");
				}
				entity.CostPrice = updatePriceVaccineRequest.CostPrice;
				entity.RetailPrice = updatePriceVaccineRequest.RetailPrice;
				entity.PreOrderPrice = updatePriceVaccineRequest.PreOrderPrice;
				entity.IdVaccineBacth = updatePriceVaccineRequest.IdVaccineBacth;
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