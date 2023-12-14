using BLL.Common;
using BLL.Requests;
using BLL.Responses;

namespace BLL.Services.Constracts
{
    public interface IInjectionChartService
    {
        Task<ApiResponse<string>> CreateInjectionChart(CreateInjectionChartRequest createInjectionChartRequest);

        Task<ApiResponse<List<InjectionChartResponse>>> GetInjectionCharts();

        Task<ApiResponse<InjectionChartResponse>> GetInjectionChart(string idInjectionChart);

        Task<ApiResponse<string>> UpdateInjectionChart(UpdateInjectionChartRequest updateInjectionChartRequest);

        Task<ApiResponse<string>> DeleteInjectionChart(string idInjectionChart);
    }
}