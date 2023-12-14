using BLL.Requests;
using BLL.Services.Constracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TiemChungVNVC_BE.Controllers
{
    [Route("api/vaccination-centers")]
    [ApiController]
    public class VaccinationCenterController : ControllerBase
    {
        private readonly IVaccinationCenterService VaccinationCenterService;

        public VaccinationCenterController(IVaccinationCenterService VaccinationCenterService)
        {
            this.VaccinationCenterService = VaccinationCenterService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var response = await VaccinationCenterService.GetVaccinationCenters();
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
                var response = await VaccinationCenterService.GetVaccinationCenter(id);
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
                var response = await VaccinationCenterService.DeleteVaccinationCenter(id);
                return Ok(response);
            }
            catch (Exception ec)
            {
                return BadRequest(ec.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateVaccinationCenterRequest request)
        {
            try
            {
                var response = await VaccinationCenterService.UpdateVaccinationCenter(request);
                return Ok(response);
            }
            catch (Exception ec)
            {
                return BadRequest(ec.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateVaccinationCenterRequest request)
        {
            try
            {
                var response = await VaccinationCenterService.CreateVaccinationCenter(request);
                return Ok(response);
            }
            catch (Exception ec)
            {
                return BadRequest(ec.Message);
            }
        }
    }
}