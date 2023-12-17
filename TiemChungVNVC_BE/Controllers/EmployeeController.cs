using BLL.Requests;
using BLL.Services.Constracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TiemChungVNVC_BE.Controllers
{
	[Route("api/employees")]
	[ApiController]
	public class EmployeeController : ControllerBase
	{
		private readonly IEmployeeService EmployeeService;

		public EmployeeController(IEmployeeService EmployeeService)
		{
			this.EmployeeService = EmployeeService;
		}

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			try
			{
				var response = await EmployeeService.GetEmployees();
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
				var response = await EmployeeService.GetEmployee(id);
				return Ok(response);
			}
			catch (Exception ec)
			{
				return BadRequest(ec.Message);
			}
		}

		[HttpGet("user/{id}")]
		public async Task<IActionResult> GetByUser(string id)
		{
			try
			{
				var response = await EmployeeService.GetEmployeeByUserId(id);
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
				var response = await EmployeeService.DeleteEmployee(id);
				return Ok(response);
			}
			catch (Exception ec)
			{
				return BadRequest(ec.Message);
			}
		}

		[HttpPut]
		public async Task<IActionResult> Update(UpdateEmployeeRequest request)
		{
			try
			{
				var response = await EmployeeService.UpdateEmployee(request);
				return Ok(response);
			}
			catch (Exception ec)
			{
				return BadRequest(ec.Message);
			}
		}

		[HttpPost]
		public async Task<IActionResult> Create(CreateEmployeeRequest request)
		{
			try
			{
				var response = await EmployeeService.CreateEmployee(request);
				return Ok(response);
			}
			catch (Exception ec)
			{
				return BadRequest(ec.Message);
			}
		}
	}
}