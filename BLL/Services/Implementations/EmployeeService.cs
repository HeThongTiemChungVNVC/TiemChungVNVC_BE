﻿using AutoMapper;
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
    public class EmployeeService : IEmployeeService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<DtoEmployee> repository;
        private VNVCContext _context;

        public EmployeeService(IMapper mapper, VNVCContext context, IRepository<DtoEmployee> repository)
        {
            _mapper = mapper;
            _context = context;
            this.repository = repository;
        }

        private static string GetNumericPart(Guid guid)
        {
            // Convert the GUID to a string and remove non-numeric characters
            string numericPart = new string(guid.ToString().Where(char.IsDigit).ToArray());

            // Ensure the length is 8 by taking the first 8 characters
            numericPart = numericPart.Length >= 6 ? numericPart.Substring(0, 6) : numericPart;

            return numericPart;
        }

        public async Task<ApiResponse<string>> CreateEmployee(CreateEmployeeRequest createEmployeeRequest)
        {
            try
            {
                var employee = _mapper.Map<DtoEmployee>(createEmployeeRequest);
                while (true)
                {
                    var codeCustomer = "NV" + GetNumericPart(Guid.NewGuid());
                    if (repository.GetAll().FirstOrDefault(x => x.CodeEmployee == codeCustomer) == null)
                    {
                        employee.CodeEmployee = codeCustomer;
                        break;
                    }
                }
                repository.Insert(employee);
                return ApiResponse<string>.ApiResponseSuccess("Thêm thành công");
            }
            catch (Exception ec)
            {
                return ApiResponse<string>.ApiResponseFail(ec.Message);
            }
        }

        public async Task<ApiResponse<string>> DeleteEmployee(string idEmployee)
        {
            try
            {
                var entity = repository.GetAll().FirstOrDefault(x => x.Id == idEmployee);
                if (entity == null)
                {
                    return ApiResponse<string>.ApiResponseFail("Nhân viên này không tồn tại");
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

        public async Task<ApiResponse<EmployeeResponse>> GetEmployee(string idEmployee)
        {
            try
            {
                var entity = repository.GetAll().FirstOrDefault(x => x.Id == idEmployee && !x.IsDeleted);
                if (entity == null)
                {
                    return ApiResponse<EmployeeResponse>.ApiResponseFail("Nhân viên này không tồn tại");
                }
                var response = _mapper.Map<EmployeeResponse>(entity);
                return ApiResponse<EmployeeResponse>.ApiResponseSuccess(response);
            }
            catch (Exception ec)
            {
                return ApiResponse<EmployeeResponse>.ApiResponseFail(ec.Message);
            }
        }

        public async Task<ApiResponse<List<EmployeeResponse>>> GetEmployees()
        {
            try
            {
                var entity = repository.GetAll().Where(x => !x.IsDeleted).ToList();
                if (entity.Count() == 0)
                {
                    return ApiResponse<List<EmployeeResponse>>.ApiResponseFail("Chưa có dữ liệu");
                }
                var response = entity.Select(_mapper.Map<DtoEmployee, EmployeeResponse>).ToList();
                return ApiResponse<List<EmployeeResponse>>.ApiResponseSuccess(response);
            }
            catch (Exception ec)
            {
                return ApiResponse<List<EmployeeResponse>>.ApiResponseFail(ec.Message);
            }
        }

        public async Task<ApiResponse<string>> UpdateEmployee(UpdateEmployeeRequest updateEmployeeRequest)
        {
            try
            {
                var entity = repository.GetAll().FirstOrDefault(x => x.Id == updateEmployeeRequest.Id);
                if (entity == null)
                {
                    return ApiResponse<string>.ApiResponseFail("Nhân viên này không tồn tại");
                }
                if (!string.IsNullOrEmpty(updateEmployeeRequest.FullName))
                {
                    entity.FullName = updateEmployeeRequest.FullName;
                }
                if (!string.IsNullOrEmpty(updateEmployeeRequest.Phone))
                {
                    entity.Phone = updateEmployeeRequest.Phone;
                }
                if (!string.IsNullOrEmpty(updateEmployeeRequest.Email))
                {
                    entity.Email = updateEmployeeRequest.Email;
                }
                if (!string.IsNullOrEmpty(updateEmployeeRequest.Address))
                {
                    entity.Address = updateEmployeeRequest.Address;
                }
                if (!string.IsNullOrEmpty(updateEmployeeRequest.Gender))
                {
                    entity.Gender = updateEmployeeRequest.Gender;
                }
                if (!string.IsNullOrEmpty(updateEmployeeRequest.IdCategoryPosition))
                {
                    entity.IdCategoryPosition = updateEmployeeRequest.IdCategoryPosition;
                }
                if (!string.IsNullOrEmpty(updateEmployeeRequest.IdVaccinationCenter))
                {
                    entity.IdVaccinationCenter = updateEmployeeRequest.IdVaccinationCenter;
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