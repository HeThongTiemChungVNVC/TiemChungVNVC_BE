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
    public interface IVaccinationCenterService
    {
        Task<ApiResponse<string>> CreateVaccinationCenter(CreateVaccinationCenterRequest createVaccinationCenterRequest);

        Task<ApiResponse<List<VaccinationCenterResponse>>> GetVaccinationCenters();

        Task<ApiResponse<VaccinationCenterResponse>> GetVaccinationCenter(string idVaccinationCenter);

        Task<ApiResponse<string>> UpdateVaccinationCenter(UpdateVaccinationCenterRequest updateVaccinationCenterRequest);

        Task<ApiResponse<string>> DeleteVaccinationCenter(string idVaccinationCenter);
    }
}