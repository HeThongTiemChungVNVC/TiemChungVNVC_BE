using BLL.Requests;
using BLL.Services.Constracts;
using BLL.Services.Implementations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TiemChungVNVC_BE.Controllers
{
	[Route("api/vaccination-registrations")]
	[ApiController]
	public class VaccinationRegistrationController : ControllerBase
	{
		private readonly IVaccinationRegistrationSevice _serviceService;

		public VaccinationRegistrationController(IVaccinationRegistrationSevice sevice)
		{
			_serviceService = sevice;
		}

		[HttpPost("registration")]
		public async Task<IActionResult> Registration(RegistrationRequest request)
		{
			try
			{
				var res = await _serviceService.RegistrationVaccination(request);
				return Ok(res);
			}
			catch (Exception ec)
			{
				return BadRequest(ec.Message);
			}
		}

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			try
			{
				var response = await _serviceService.GetVaccinationRegistrations();
				return Ok(response);
			}
			catch (Exception ec)
			{
				return BadRequest(ec.Message);
			}
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> Get(string id)
		{
			try
			{
				var response = await _serviceService.GetVaccinationRegistration(id);
				return Ok(response);
			}
			catch (Exception ec)
			{
				return BadRequest(ec.Message);
			}
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(string id)
		{
			try
			{
				var response = await _serviceService.DeleteVaccinationRegistration(id);
				return Ok(response);
			}
			catch (Exception ec)
			{
				return BadRequest(ec.Message);
			}
		}

		[HttpPut]
		public async Task<IActionResult> Update(UpdateVaccinationRegistrationRequest request)
		{
			try
			{
				var response = await _serviceService.UpdateVaccinationRegistration(request);
				return Ok(response);
			}
			catch (Exception ec)
			{
				return BadRequest(ec.Message);
			}
		}

		[HttpGet("customer/{code_customer}")]
		public async Task<IActionResult> Registration(string code_customer)
		{
			try
			{
				var res = await _serviceService.GetVaccinationRegistrationByCodeCustomer(code_customer);
				return Ok(res);
			}
			catch (Exception ec)
			{
				return BadRequest(ec.Message);
			}
		}
	}
}