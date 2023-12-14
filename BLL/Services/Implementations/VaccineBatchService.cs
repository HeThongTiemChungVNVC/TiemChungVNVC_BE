using AutoMapper;
using BLL.Common;
using BLL.Requests;
using BLL.Responses;
using BLL.Services.Constracts;
using DAL.Dtos;
using Microsoft.IdentityModel.Tokens;
using Repository.DbContexts;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Implementations
{
    public class VaccineBatchService : IVaccineBatchService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<DtoVaccineBatch> repository;
        private VNVCContext _context;

        public VaccineBatchService(IMapper mapper, VNVCContext context, IRepository<DtoVaccineBatch> repository)
        {
            _mapper = mapper;
            _context = context;
            this.repository = repository;
        }

        public async Task<ApiResponse<string>> CreateVaccineBatch(CreateVaccineBatchRequest createVaccineBatchRequest)
        {
            try
            {
                var VaccineBatch = _mapper.Map<DtoVaccineBatch>(createVaccineBatchRequest);
                repository.Insert(VaccineBatch);
                return ApiResponse<string>.ApiResponseSuccess("Thêm thành công");
            }
            catch (Exception ec)
            {
                return ApiResponse<string>.ApiResponseFail(ec.Message);
            }
        }

        public async Task<ApiResponse<string>> DeleteVaccineBatch(string idVaccineBatch)
        {
            try
            {
                var entity = repository.GetAll().FirstOrDefault(x => x.Id == idVaccineBatch);
                if (entity == null)
                {
                    return ApiResponse<string>.ApiResponseFail("Lô vaccine này không tồn tại");
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

        public async Task<ApiResponse<VaccineBatchResponse>> GetVaccineBatch(string idVaccineBatch)
        {
            try
            {
                var entity = repository.GetAll().FirstOrDefault(x => x.Id == idVaccineBatch && !x.IsDeleted);
                if (entity == null)
                {
                    return ApiResponse<VaccineBatchResponse>.ApiResponseFail("Lô vaccine này không tồn tại");
                }
                var response = _mapper.Map<VaccineBatchResponse>(entity);
                return ApiResponse<VaccineBatchResponse>.ApiResponseSuccess(response);
            }
            catch (Exception ec)
            {
                return ApiResponse<VaccineBatchResponse>.ApiResponseFail(ec.Message);
            }
        }

        public async Task<ApiResponse<List<VaccineBatchResponse>>> GetVaccineBatchs()
        {
            try
            {
                var entity = repository.GetAll().Where(x => !x.IsDeleted).ToList();
                if (entity.Count() == 0)
                {
                    return ApiResponse<List<VaccineBatchResponse>>.ApiResponseFail("Chưa có dữ liệu");
                }
                var response = entity.Select(_mapper.Map<DtoVaccineBatch, VaccineBatchResponse>).ToList();
                return ApiResponse<List<VaccineBatchResponse>>.ApiResponseSuccess(response);
            }
            catch (Exception ec)
            {
                return ApiResponse<List<VaccineBatchResponse>>.ApiResponseFail(ec.Message);
            }
        }

        public async Task<ApiResponse<string>> UpdateVaccineBatch(UpdateVaccineBatchRequest updateVaccineBatchRequest)
        {
            try
            {
                var entity = repository.GetAll().FirstOrDefault(x => x.Id == updateVaccineBatchRequest.Id);
                if (entity == null)
                {
                    return ApiResponse<string>.ApiResponseFail("Lô vaccine này không tồn tại");
                }
                if (!string.IsNullOrEmpty(updateVaccineBatchRequest.CodeBatch))
                {
                    entity.CodeBatch = updateVaccineBatchRequest.CodeBatch;
                }
                if (!string.IsNullOrEmpty(updateVaccineBatchRequest.Country))
                {
                    entity.Country = updateVaccineBatchRequest.Country;
                }
                entity.QuantityOfVaccine = updateVaccineBatchRequest.QuantityOfVaccine;
                entity.ManufacturingDate = updateVaccineBatchRequest.ManufacturingDate;
                entity.ExpirationDate = updateVaccineBatchRequest.ExpirationDate;
                if (!string.IsNullOrEmpty(updateVaccineBatchRequest.VaccineId))
                {
                    entity.VaccineId = updateVaccineBatchRequest.VaccineId;
                }
                if (!string.IsNullOrEmpty(updateVaccineBatchRequest.SupplierId))
                {
                    entity.SupplierId = updateVaccineBatchRequest.SupplierId;
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