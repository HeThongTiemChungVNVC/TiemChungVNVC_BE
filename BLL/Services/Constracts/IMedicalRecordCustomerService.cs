using BLL.Common;
using BLL.Requests;
using BLL.Responses;

namespace BLL.Services.Constracts
{
    public interface IMedicalRecordCustomerService
    {
        Task<ApiResponse<string>> CreateMedicalRecord(CreateMedicalRecordRequest createMedicalRecordRequest);

        Task<ApiResponse<List<MedicalRecordResponse>>> GetMedicalRecords();

        Task<ApiResponse<MedicalRecordResponse>> GetMedicalRecord(string idMedicalRecord);

        Task<ApiResponse<MedicalRecordResponse>> GetMedicalRecordByCodeCustomer(string codeCustomer);

        Task<ApiResponse<string>> DeleteMedicalRecord(string idMedicalRecord);

        Task<ApiResponse<string>> DeleteDetailMedicalRecord(string idDetailMedicalRecord);

        Task<ApiResponse<string>> CreateDetailMedicalRecord(CreateDetailMedicalRequest createDetailMedicalRequest);

        Task<ApiResponse<string>> UpdateDetailMedicalRecord(UpdateDetailMedicalRequest updateDetailMedicalRequest);
    }
}