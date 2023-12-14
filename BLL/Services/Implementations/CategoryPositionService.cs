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
    public class CategoryPositionService : ICategoryPositionService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<DtoCategoryPosition> repository;
        private VNVCContext _context;

        public CategoryPositionService(IMapper mapper, VNVCContext context, IRepository<DtoCategoryPosition> repository)
        {
            _mapper = mapper;
            _context = context;
            this.repository = repository;
        }

        public async Task<ApiResponse<string>> CreateCategoryPosition(CreateCategoryPositionRequest createCategoryPositionRequest)
        {
            try
            {
                var categoryVacine = _mapper.Map<DtoCategoryPosition>(createCategoryPositionRequest);
                repository.Insert(categoryVacine);
                return ApiResponse<string>.ApiResponseSuccess("Thêm thành công");
            }
            catch (Exception ec)
            {
                return ApiResponse<string>.ApiResponseFail(ec.Message);
            }
        }

        public async Task<ApiResponse<string>> DeleteCategoryPosition(string idCategoryPosition)
        {
            try
            {
                var entity = repository.GetAll().FirstOrDefault(x => x.Id == idCategoryPosition);
                if (entity == null)
                {
                    return ApiResponse<string>.ApiResponseFail("Loại chức vụ này không tồn tại");
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

        public async Task<ApiResponse<CategoryPositionResponse>> GetCategoryPosition(string idCategoryPosition)
        {
            try
            {
                var entity = repository.GetAll().FirstOrDefault(x => x.Id == idCategoryPosition && !x.IsDeleted);
                if (entity == null)
                {
                    return ApiResponse<CategoryPositionResponse>.ApiResponseFail("Loại chức vụ này không tồn tại");
                }
                var response = _mapper.Map<CategoryPositionResponse>(entity);
                return ApiResponse<CategoryPositionResponse>.ApiResponseSuccess(response);
            }
            catch (Exception ec)
            {
                return ApiResponse<CategoryPositionResponse>.ApiResponseFail(ec.Message);
            }
        }

        public async Task<ApiResponse<List<CategoryPositionResponse>>> GetCategoryPositions()
        {
            try
            {
                var entity = repository.GetAll().Where(x => !x.IsDeleted).ToList();
                if (entity.Count() == 0)
                {
                    return ApiResponse<List<CategoryPositionResponse>>.ApiResponseFail("Chưa có dữ liệu");
                }
                var response = entity.Select(_mapper.Map<DtoCategoryPosition, CategoryPositionResponse>).ToList();
                return ApiResponse<List<CategoryPositionResponse>>.ApiResponseSuccess(response);
            }
            catch (Exception ec)
            {
                return ApiResponse<List<CategoryPositionResponse>>.ApiResponseFail(ec.Message);
            }
        }

        public async Task<ApiResponse<string>> UpdateCategoryPosition(UpdateCategoryPositionRequest updateCategoryPositionRequest)
        {
            try
            {
                var entity = repository.GetAll().FirstOrDefault(x => x.Id == updateCategoryPositionRequest.Id);
                if (entity == null)
                {
                    return ApiResponse<string>.ApiResponseFail("Loại chức vụ này không tồn tại");
                }
                if (!string.IsNullOrEmpty(updateCategoryPositionRequest.Title))
                {
                    entity.Title = updateCategoryPositionRequest.Title;
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