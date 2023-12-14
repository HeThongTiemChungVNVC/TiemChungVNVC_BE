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
    public class CategoryVaccineService : ICategoryVaccineService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<DtoCategoryVaccine> repository;
        private VNVCContext _context;

        public CategoryVaccineService(IMapper mapper, VNVCContext context, IRepository<DtoCategoryVaccine> repository)
        {
            _mapper = mapper;
            _context = context;
            this.repository = repository;
        }

        public async Task<ApiResponse<string>> CreateCategoryVaccine(CreateCategoryVaccineRequest createCategoryVaccineRequest)
        {
            try
            {
                var categoryVacine = _mapper.Map<DtoCategoryVaccine>(createCategoryVaccineRequest);
                repository.Insert(categoryVacine);
                return ApiResponse<string>.ApiResponseSuccess("Thêm thành công");
            }
            catch (Exception ec)
            {
                return ApiResponse<string>.ApiResponseFail(ec.Message);
            }
        }

        public async Task<ApiResponse<string>> DeleteCategoryVaccine(string idCategoryVaccine)
        {
            try
            {
                var entity = repository.GetAll().FirstOrDefault(x => x.Id == idCategoryVaccine);
                if (entity == null)
                {
                    return ApiResponse<string>.ApiResponseFail("Loại vaccine này không tồn tại");
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

        public async Task<ApiResponse<CategoryVaccineResponse>> GetCategoryVaccine(string idCategoryVaccine)
        {
            try
            {
                var entity = repository.GetAll().FirstOrDefault(x => x.Id == idCategoryVaccine && !x.IsDeleted);
                if (entity == null)
                {
                    return ApiResponse<CategoryVaccineResponse>.ApiResponseFail("Loại vaccine này không tồn tại");
                }
                var response = _mapper.Map<CategoryVaccineResponse>(entity);
                return ApiResponse<CategoryVaccineResponse>.ApiResponseSuccess(response);
            }
            catch (Exception ec)
            {
                return ApiResponse<CategoryVaccineResponse>.ApiResponseFail(ec.Message);
            }
        }

        public async Task<ApiResponse<List<CategoryVaccineResponse>>> GetCategoryVaccines()
        {
            try
            {
                var entity = repository.GetAll().Where(x => !x.IsDeleted).ToList();
                if (entity.Count() == 0)
                {
                    return ApiResponse<List<CategoryVaccineResponse>>.ApiResponseFail("Chưa có dữ liệu");
                }
                var response = entity.Select(_mapper.Map<DtoCategoryVaccine, CategoryVaccineResponse>).ToList();
                return ApiResponse<List<CategoryVaccineResponse>>.ApiResponseSuccess(response);
            }
            catch (Exception ec)
            {
                return ApiResponse<List<CategoryVaccineResponse>>.ApiResponseFail(ec.Message);
            }
        }

        public async Task<ApiResponse<string>> UpdateCategoryVaccine(UpdateCategoryVaccineRequest updateCategoryVaccineRequest)
        {
            try
            {
                var entity = repository.GetAll().FirstOrDefault(x => x.Id == updateCategoryVaccineRequest.Id);
                if (entity == null)
                {
                    return ApiResponse<string>.ApiResponseFail("Loại vaccine này không tồn tại");
                }
                if (!string.IsNullOrEmpty(updateCategoryVaccineRequest.Title))
                {
                    entity.Title = updateCategoryVaccineRequest.Title;
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