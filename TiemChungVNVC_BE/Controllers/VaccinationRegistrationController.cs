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

		[HttpPost("registration/admin")]
		public async Task<IActionResult> RegistrationByAdmin(RegistrationRequestByAdmin request)
		{
			try
			{
				var res = await _serviceService.RegistrationVaccinationByAdmin(request);
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
		[HttpPut("detail")]
		public async Task<IActionResult> UpdateDetail(UpdateDetailRegistrationVaccinationRequest request)
		{
			try
			{
				var response = await _serviceService.UpdateDetailRegistrationVaccination(request);
				return Ok(response);
			}
			catch (Exception ec)
			{
				return BadRequest(ec.Message);
			}
		}

		[HttpGet("detail/send-email/{id}")]
		public async Task<IActionResult> Registration(string id)
		{
			try
			{
				var res = await _serviceService.SendEmailReminder(id);
				return Ok(res);
			}
			catch (Exception ec)
			{
				return BadRequest(ec.Message);
			}
		}
	}
}