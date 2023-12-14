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
    public interface ICategoryVaccineService
    {
        Task<ApiResponse<string>> CreateCategoryVaccine(CreateCategoryVaccineRequest createCategoryVaccineRequest);

        Task<ApiResponse<List<CategoryVaccineResponse>>> GetCategoryVaccines();

        Task<ApiResponse<CategoryVaccineResponse>> GetCategoryVaccine(string idCategoryVaccine);

        Task<ApiResponse<string>> UpdateCategoryVaccine(UpdateCategoryVaccineRequest updateCategoryVaccineRequest);

        Task<ApiResponse<string>> DeleteCategoryVaccine(string idCategoryVaccine);
    }
}