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
	public interface IVaccinationRegistrationSevice
	{
		Task<ApiResponse<string>> CreateVaccinationRegistration(CreateVaccinationRegistrationRequest createVaccinationRegistrationRequest);

		Task<ApiResponse<List<VaccinationRegistrationResponse>>> GetVaccinationRegistrations();

		Task<ApiResponse<VaccinationRegistrationResponse>> GetVaccinationRegistration(string idVaccinationRegistration);

		Task<ApiResponse<VaccinationRegistrationResponse>> GetVaccinationRegistrationByCodeCustomer(string codeCustomer);

		Task<ApiResponse<string>> UpdateVaccinationRegistration(UpdateVaccinationRegistrationRequest updateVaccinationRegistrationRequest);

		Task<ApiResponse<string>> DeleteVaccinationRegistration(string idVaccinationRegistration);

		Task<ApiResponse<string>> RegistrationVaccination(RegistrationRequest registrationRequest);
	}
}