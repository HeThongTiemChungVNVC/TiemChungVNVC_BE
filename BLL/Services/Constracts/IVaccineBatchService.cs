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
    public interface IVaccineBatchService
    {
        Task<ApiResponse<string>> CreateVaccineBatch(CreateVaccineBatchRequest createVaccineBatchRequest);

        Task<ApiResponse<List<VaccineBatchResponse>>> GetVaccineBatchs();

        Task<ApiResponse<VaccineBatchResponse>> GetVaccineBatch(string idVaccineBatch);

        Task<ApiResponse<string>> UpdateVaccineBatch(UpdateVaccineBatchRequest updateVaccineBatchRequest);

        Task<ApiResponse<string>> DeleteVaccineBatch(string idVaccineBatch);
    }
}