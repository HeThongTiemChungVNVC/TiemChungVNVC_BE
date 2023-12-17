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
	public class InjectionChartService : IInjectionChartService
	{
		private readonly IMapper _mapper;
		private readonly IRepository<DtoInjectionChart> repository;
		private VNVCContext _context;

		public InjectionChartService(IMapper mapper, VNVCContext context, IRepository<DtoInjectionChart> repository)
		{
			_mapper = mapper;
			_context = context;
			this.repository = repository;
		}

		public async Task<ApiResponse<string>> CreateInjectionChart(CreateInjectionChartRequest createInjectionChartRequest)
		{
			try
			{
				var categoryVacine = _mapper.Map<DtoInjectionChart>(createInjectionChartRequest);
				repository.Insert(categoryVacine);
				return ApiResponse<string>.ApiResponseSuccess("Thêm thành công", "Thêm thành công");
			}
			catch (Exception ec)
			{
				return ApiResponse<string>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<string>> DeleteInjectionChart(string idInjectionChart)
		{
			try
			{
				var entity = repository.GetAll().FirstOrDefault(x => x.Id == idInjectionChart);
				if (entity == null)
				{
					return ApiResponse<string>.ApiResponseFail("Phác đồ này không tồn tại", "Phác đồ này không tồn tại");
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

		public async Task<ApiResponse<InjectionChartResponse>> GetInjectionChart(string idInjectionChart)
		{
			try
			{
				var entity = repository.GetAll().AsQueryable().Include(x => x.Vaccine).FirstOrDefault(x => x.Id == idInjectionChart && !x.IsDeleted);
				if (entity == null)
				{
					return ApiResponse<InjectionChartResponse>.ApiResponseFail("Phác đồ này không tồn tại");
				}
				var response = _mapper.Map<InjectionChartResponse>(entity);
				return ApiResponse<InjectionChartResponse>.ApiResponseSuccess(response);
			}
			catch (Exception ec)
			{
				return ApiResponse<InjectionChartResponse>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<List<InjectionChartResponse>>> GetInjectionCharts()
		{
			try
			{
				var entity = repository.GetAll().AsQueryable().Include(x => x.Vaccine).Where(x => !x.IsDeleted).ToList();
				if (entity.Count() == 0)
				{
					return ApiResponse<List<InjectionChartResponse>>.ApiResponseFail("Chưa có dữ liệu");
				}
				var response = entity.Select(_mapper.Map<DtoInjectionChart, InjectionChartResponse>).ToList();
				return ApiResponse<List<InjectionChartResponse>>.ApiResponseSuccess(response);
			}
			catch (Exception ec)
			{
				return ApiResponse<List<InjectionChartResponse>>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<string>> UpdateInjectionChart(UpdateInjectionChartRequest updateInjectionChartRequest)
		{
			try
			{
				var entity = repository.GetAll().FirstOrDefault(x => x.Id == updateInjectionChartRequest.Id);
				if (entity == null)
				{
					return ApiResponse<string>.ApiResponseFail("Phác đồ này không tồn tại", "Phác đồ này không tồn tại");
				}
				entity.Doses = updateInjectionChartRequest.Doses;
				entity.Interval = updateInjectionChartRequest.Interval;
				entity.Reminder = updateInjectionChartRequest.Reminder;
				entity.IdVaccine = updateInjectionChartRequest.IdVaccine;

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