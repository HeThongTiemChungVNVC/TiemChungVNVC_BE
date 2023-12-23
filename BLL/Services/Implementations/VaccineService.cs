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
	public class VaccineService : IVaccineService
	{
		private readonly IMapper _mapper;
		private readonly IRepository<DtoVaccine> repository;
		private VNVCContext _context;

		public VaccineService(IMapper mapper, VNVCContext context, IRepository<DtoVaccine> repository)
		{
			_mapper = mapper;
			_context = context;
			this.repository = repository;
		}

		public async Task<ApiResponse<string>> CreateVaccine(CreateVaccineRequest createVaccineRequest)
		{
			try
			{
				var Vaccine = _mapper.Map<DtoVaccine>(createVaccineRequest);
				repository.Insert(Vaccine);
				return ApiResponse<string>.ApiResponseSuccess("Thêm thành công", "Thêm thành công");
			}
			catch (Exception ec)
			{
				return ApiResponse<string>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<string>> DeleteVaccine(string idVaccine)
		{
			try
			{
				var entity = repository.GetAll().FirstOrDefault(x => x.Id == idVaccine);
				if (entity == null)
				{
					return ApiResponse<string>.ApiResponseFail("Vaccine này không tồn tại", "Vaccine này không tồn tại");
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

		public async Task<ApiResponse<VaccineResponse>> GetVaccine(string idVaccine)
		{
			try
			{
				var entity = repository.GetAll().AsQueryable().Include(x => x.InjectionChart).Include(x => x.CategoryVaccine).FirstOrDefault(x => x.Id == idVaccine && !x.IsDeleted);
				if (entity == null)
				{
					return ApiResponse<VaccineResponse>.ApiResponseFail("Vaccine này không tồn tại");
				}
				var response = _mapper.Map<VaccineResponse>(entity);
				return ApiResponse<VaccineResponse>.ApiResponseSuccess(response);
			}
			catch (Exception ec)
			{
				return ApiResponse<VaccineResponse>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<List<VaccineResponse>>> GetVaccines()
		{
			try
			{
				//var entity = repository.GetAll().AsQueryable().Include(x => x.InjectionChart).Include(x => x.CategoryVaccine).Where(x => !x.IsDeleted).ToList();
				var entity = (from v in _context.Vaccines
							  join inject in _context.InjectionCharts on v.Id equals inject.IdVaccine into _inject
							  from inject2 in _inject.DefaultIfEmpty()
							  join cate in _context.CategoryVaccines on v.CategoryVaccineId equals cate.Id into _cate
							  from cate2 in _cate.DefaultIfEmpty()
							  where !v.IsDeleted
							  select new VaccineResponse
							  {
								  Id = v.Id,
								  CategoryVaccine = new CategoryVaccineResponse()
								  {
									  Id = cate2.Id,
									  Title = cate2.Title,
								  },
								  CategoryVaccineId = cate2.Id,
								  InjectionChart = new InjectionChartResponse()
								  {
									  Id = inject2.Id,
									  IdVaccine = inject2.IdVaccine
								  },
								  Condition = v.Condition,
								  NameVaccine = v.NameVaccine,
								  Prevention = v.Prevention,
								  InjectionSite = v.InjectionSite,
								  Image = v.Image
							  }).ToList();
				if (entity.Count() == 0)
				{
					return ApiResponse<List<VaccineResponse>>.ApiResponseFail("Chưa có dữ liệu");
				}
				return ApiResponse<List<VaccineResponse>>.ApiResponseSuccess(entity);
			}
			catch (Exception ec)
			{
				return ApiResponse<List<VaccineResponse>>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<string>> UpdateVaccine(UpdateVaccineRequest updateVaccineRequest)
		{
			try
			{
				var entity = repository.GetAll().FirstOrDefault(x => x.Id == updateVaccineRequest.Id);
				if (entity == null)
				{
					return ApiResponse<string>.ApiResponseFail("Vaccine này không tồn tại", "Vaccine này không tồn tại");
				}
				if (!string.IsNullOrEmpty(updateVaccineRequest.Prevention))
				{
					entity.Prevention = updateVaccineRequest.Prevention;
				}
				if (!string.IsNullOrEmpty(updateVaccineRequest.NameVaccine))
				{
					entity.NameVaccine = updateVaccineRequest.NameVaccine;
				}
				if (!string.IsNullOrEmpty(updateVaccineRequest.InjectionSite))
				{
					entity.InjectionSite = updateVaccineRequest.InjectionSite;
				}
				if (!string.IsNullOrEmpty(updateVaccineRequest.Image))
				{
					entity.Image = updateVaccineRequest.Image;
				}
				if (!string.IsNullOrEmpty(updateVaccineRequest.Condition))
				{
					entity.Condition = updateVaccineRequest.Condition;
				}
				if (!string.IsNullOrEmpty(updateVaccineRequest.CategoryVaccineId))
				{
					entity.CategoryVaccineId = updateVaccineRequest.CategoryVaccineId;
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