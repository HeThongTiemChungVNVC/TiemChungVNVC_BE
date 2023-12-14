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
    public interface IVaccineService
    {
        Task<ApiResponse<string>> CreateVaccine(CreateVaccineRequest createVaccineRequest);

        Task<ApiResponse<List<VaccineResponse>>> GetVaccines();

        Task<ApiResponse<VaccineResponse>> GetVaccine(string idVaccine);

        Task<ApiResponse<string>> UpdateVaccine(UpdateVaccineRequest updateVaccineRequest);

        Task<ApiResponse<string>> DeleteVaccine(string idVaccine);
    }
}