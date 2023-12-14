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
                var categoryVacine = _mapper.Map<DtoPriceVaccine>(createPriceVaccineRequest);
                repository.Insert(categoryVacine);
                return ApiResponse<string>.ApiResponseSuccess("Thêm thành công");
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
                    return ApiResponse<string>.ApiResponseFail("Giá tiền vaccine này không tồn tại");
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

        public async Task<ApiResponse<PriceVaccineResponse>> GetPriceVaccine(string idPriceVaccine)
        {
            try
            {
                var entity = repository.GetAll().FirstOrDefault(x => x.Id == idPriceVaccine && !x.IsDeleted);
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
                var entity = repository.GetAll().Where(x => !x.IsDeleted).ToList();
                if (entity.Count() == 0)
                {
                    return ApiResponse<List<PriceVaccineResponse>>.ApiResponseFail("Chưa có dữ liệu");
                }
                var response = entity.Select(_mapper.Map<DtoPriceVaccine, PriceVaccineResponse>).ToList();
                return ApiResponse<List<PriceVaccineResponse>>.ApiResponseSuccess(response);
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
                    return ApiResponse<string>.ApiResponseFail("Giá tiền vaccine này không tồn tại");
                }
                entity.CostPrice = updatePriceVaccineRequest.CostPrice;
                entity.RetailPrice = updatePriceVaccineRequest.RetailPrice;
                entity.PreOrderPrice = updatePriceVaccineRequest.PreOrderPrice;
                entity.IdVaccineBacth = updatePriceVaccineRequest.IdVaccineBacth;
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