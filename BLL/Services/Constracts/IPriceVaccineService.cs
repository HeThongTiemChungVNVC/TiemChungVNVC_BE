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
    public interface IPriceVaccineService
    {
        Task<ApiResponse<string>> CreatePriceVaccine(CreatePriceVaccineRequest createPriceVaccineRequest);

        Task<ApiResponse<List<PriceVaccineResponse>>> GetPriceVaccines();

        Task<ApiResponse<PriceVaccineResponse>> GetPriceVaccine(string idPriceVaccine);

        Task<ApiResponse<string>> UpdatePriceVaccine(UpdatePriceVaccineRequest updatePriceVaccineRequest);

        Task<ApiResponse<string>> DeletePriceVaccine(string idPriceVaccine);
    }
}