using BLL.Requests;
using BLL.Services.Constracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TiemChungVNVC_BE.Controllers
{
    [Route("api/vaccine-batchs")]
    [ApiController]
    public class VaccineBatchController : ControllerBase
    {
        private readonly IVaccineBatchService VaccineBatchService;

        public VaccineBatchController(IVaccineBatchService VaccineBatchService)
        {
            this.VaccineBatchService = VaccineBatchService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var response = await VaccineBatchService.GetVaccineBatchs();
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
                var response = await VaccineBatchService.GetVaccineBatch(id);
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
                var response = await VaccineBatchService.DeleteVaccineBatch(id);
                return Ok(response);
            }
            catch (Exception ec)
            {
                return BadRequest(ec.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateVaccineBatchRequest request)
        {
            try
            {
                var response = await VaccineBatchService.UpdateVaccineBatch(request);
                return Ok(response);
            }
            catch (Exception ec)
            {
                return BadRequest(ec.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateVaccineBatchRequest request)
        {
            try
            {
                var response = await VaccineBatchService.CreateVaccineBatch(request);
                return Ok(response);
            }
            catch (Exception ec)
            {
                return BadRequest(ec.Message);
            }
        }
    }
}