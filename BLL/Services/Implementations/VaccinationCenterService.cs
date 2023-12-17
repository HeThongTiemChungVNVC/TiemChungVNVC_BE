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
    public class VaccinationCenterService : IVaccinationCenterService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<DtoVaccinationCenter> repository;
        private VNVCContext _context;

        public VaccinationCenterService(IMapper mapper, VNVCContext context, IRepository<DtoVaccinationCenter> repository)
        {
            _mapper = mapper;
            _context = context;
            this.repository = repository;
        }

        public async Task<ApiResponse<string>> CreateVaccinationCenter(CreateVaccinationCenterRequest createVaccinationCenterRequest)
        {
            try
            {
                var categoryVacine = _mapper.Map<DtoVaccinationCenter>(createVaccinationCenterRequest);
                repository.Insert(categoryVacine);
                return ApiResponse<string>.ApiResponseSuccess("Thêm thành công", "Thêm thành công");
            }
            catch (Exception ec)
            {
                return ApiResponse<string>.ApiResponseFail(ec.Message);
            }
        }

        public async Task<ApiResponse<string>> DeleteVaccinationCenter(string idVaccinationCenter)
        {
            try
            {
                var entity = repository.GetAll().FirstOrDefault(x => x.Id == idVaccinationCenter);
                if (entity == null)
                {
                    return ApiResponse<string>.ApiResponseFail("Loại chức vụ này không tồn tại", "Loại chức vụ này không tồn tại");
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

        public async Task<ApiResponse<VaccinationCenterResponse>> GetVaccinationCenter(string idVaccinationCenter)
        {
            try
            {
                var entity = repository.GetAll().FirstOrDefault(x => x.Id == idVaccinationCenter && !x.IsDeleted);
                if (entity == null)
                {
                    return ApiResponse<VaccinationCenterResponse>.ApiResponseFail("Loại chức vụ này không tồn tại");
                }
                var response = _mapper.Map<VaccinationCenterResponse>(entity);
                return ApiResponse<VaccinationCenterResponse>.ApiResponseSuccess(response);
            }
            catch (Exception ec)
            {
                return ApiResponse<VaccinationCenterResponse>.ApiResponseFail(ec.Message);
            }
        }

        public async Task<ApiResponse<List<VaccinationCenterResponse>>> GetVaccinationCenters()
        {
            try
            {
                var entity = repository.GetAll().Where(x => !x.IsDeleted).ToList();
                if (entity.Count() == 0)
                {
                    return ApiResponse<List<VaccinationCenterResponse>>.ApiResponseFail("Chưa có dữ liệu");
                }
                var response = entity.Select(_mapper.Map<DtoVaccinationCenter, VaccinationCenterResponse>).ToList();
                return ApiResponse<List<VaccinationCenterResponse>>.ApiResponseSuccess(response);
            }
            catch (Exception ec)
            {
                return ApiResponse<List<VaccinationCenterResponse>>.ApiResponseFail(ec.Message);
            }
        }

        public async Task<ApiResponse<string>> UpdateVaccinationCenter(UpdateVaccinationCenterRequest updateVaccinationCenterRequest)
        {
            try
            {
                var entity = repository.GetAll().FirstOrDefault(x => x.Id == updateVaccinationCenterRequest.Id);
                if (entity == null)
                {
                    return ApiResponse<string>.ApiResponseFail("Trung tâm này không tồn tại", "Trung tâm này không tồn tại");
                }
                if (!string.IsNullOrEmpty(updateVaccinationCenterRequest.CenterName))
                {
                    entity.CenterName = updateVaccinationCenterRequest.CenterName;
                }
                if (!string.IsNullOrEmpty(updateVaccinationCenterRequest.Address))
                {
                    entity.Address = updateVaccinationCenterRequest.Address;
                }
                if (!string.IsNullOrEmpty(updateVaccinationCenterRequest.PhoneNumber))
                {
                    entity.PhoneNumber = updateVaccinationCenterRequest.PhoneNumber;
                }
                entity.OpenTime = updateVaccinationCenterRequest.OpenTime;
                entity.CloseTime = updateVaccinationCenterRequest.CloseTime;
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