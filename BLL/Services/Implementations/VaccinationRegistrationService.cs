using AutoMapper;
using BLL.Common;
using BLL.Requests;
using BLL.Responses;
using BLL.Services.Constracts;
using DAL.Dtos;
using Microsoft.AspNetCore.Http;
using Repository.DbContexts;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Implementations
{
    public class VaccinationRegistrationService : IVaccinationRegistrationSevice
    {
        private readonly IMapper _mapper;
        private readonly IRepository<DtoVaccinationRegistration> repository;
        private VNVCContext _context;

        public VaccinationRegistrationService(IMapper mapper, VNVCContext context, IRepository<DtoVaccinationRegistration> repository)
        {
            _mapper = mapper;
            _context = context;
            this.repository = repository;
        }

        public async Task<ApiResponse<string>> CreateVaccinationRegistration(CreateVaccinationRegistrationRequest createVaccinationRegistrationRequest)
        {
            try
            {
                var categoryVacine = _mapper.Map<DtoVaccinationRegistration>(createVaccinationRegistrationRequest);
                repository.Insert(categoryVacine);
                return ApiResponse<string>.ApiResponseSuccess("Thêm thành công");
            }
            catch (Exception ec)
            {
                return ApiResponse<string>.ApiResponseFail(ec.Message);
            }
        }

        public async Task<ApiResponse<string>> DeleteVaccinationRegistration(string idVaccinationRegistration)
        {
            try
            {
                var entity = repository.GetAll().FirstOrDefault(x => x.Id == idVaccinationRegistration);
                if (entity == null)
                {
                    return ApiResponse<string>.ApiResponseFail("Phiếu đăng ký tiêm này không tồn tại");
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

        public async Task<ApiResponse<VaccinationRegistrationResponse>> GetVaccinationRegistration(string idVaccinationRegistration)
        {
            try
            {
                var entity = repository.GetAll().FirstOrDefault(x => x.Id == idVaccinationRegistration && !x.IsDeleted);
                if (entity == null)
                {
                    return ApiResponse<VaccinationRegistrationResponse>.ApiResponseFail("Phiếu đăng ký tiêm này không tồn tại");
                }
                var response = _mapper.Map<VaccinationRegistrationResponse>(entity);
                return ApiResponse<VaccinationRegistrationResponse>.ApiResponseSuccess(response);
            }
            catch (Exception ec)
            {
                return ApiResponse<VaccinationRegistrationResponse>.ApiResponseFail(ec.Message);
            }
        }

        public async Task<ApiResponse<List<VaccinationRegistrationResponse>>> GetVaccinationRegistrations()
        {
            try
            {
                var entity = repository.GetAll().Where(x => !x.IsDeleted).ToList();
                if (entity.Count() == 0)
                {
                    return ApiResponse<List<VaccinationRegistrationResponse>>.ApiResponseFail("Chưa có dữ liệu");
                }
                var response = entity.Select(_mapper.Map<DtoVaccinationRegistration, VaccinationRegistrationResponse>).ToList();
                return ApiResponse<List<VaccinationRegistrationResponse>>.ApiResponseSuccess(response);
            }
            catch (Exception ec)
            {
                return ApiResponse<List<VaccinationRegistrationResponse>>.ApiResponseFail(ec.Message);
            }
        }

        public async Task<ApiResponse<string>> UpdateVaccinationRegistration(UpdateVaccinationRegistrationRequest updateVaccinationRegistrationRequest)
        {
            try
            {
                var entity = repository.GetAll().FirstOrDefault(x => x.Id == updateVaccinationRegistrationRequest.Id);
                if (entity == null)
                {
                    return ApiResponse<string>.ApiResponseFail("Phiếu đăng ký tiêm này không tồn tại");
                }
                if (!string.IsNullOrEmpty(updateVaccinationRegistrationRequest.NameCustomer))
                {
                    entity.NameCustomer = updateVaccinationRegistrationRequest.NameCustomer;
                }
                if (!string.IsNullOrEmpty(updateVaccinationRegistrationRequest.IdVaccineBatch))
                {
                    entity.IdVaccineBatch = updateVaccinationRegistrationRequest.IdVaccineBatch;
                }
                if (!string.IsNullOrEmpty(updateVaccinationRegistrationRequest.IdVaccinationCenter))
                {
                    entity.IdVaccinationCenter = updateVaccinationRegistrationRequest.IdVaccinationCenter;
                }
                DateTime result = DateTime.ParseExact(updateVaccinationRegistrationRequest.VaccinationDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                entity.VaccinationDate = result;
                entity.NumberOfDosesRemaining = updateVaccinationRegistrationRequest.NumberOfDosesRemaining;
                entity.Status = updateVaccinationRegistrationRequest.Status;
                entity.TotalPrice = updateVaccinationRegistrationRequest.TotalPrice;
                entity.Note = updateVaccinationRegistrationRequest.Note;
                entity.IdEmployee = updateVaccinationRegistrationRequest.IdEmployee;
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