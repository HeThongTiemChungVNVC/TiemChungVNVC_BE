using BLL.Common;
using BLL.Requests;
using BLL.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Constracts
{
    public interface ICategoryPositionService
    {
        Task<ApiResponse<string>> CreateCategoryPosition(CreateCategoryPositionRequest createCategoryPositionRequest);

        Task<ApiResponse<List<CategoryPositionResponse>>> GetCategoryPositions();

        Task<ApiResponse<CategoryPositionResponse>> GetCategoryPosition(string idCategoryPosition);

        Task<ApiResponse<string>> UpdateCategoryPosition(UpdateCategoryPositionRequest updateCategoryPositionRequest);

        Task<ApiResponse<string>> DeleteCategoryPosition(string idCategoryPosition);
    }
}