using BLL.Requests;
using BLL.Services.Constracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TiemChungVNVC_BE.Controllers
{
    [Route("api/price-vaccines")]
    [ApiController]
    public class PriceVaccineController : ControllerBase
    {
        private readonly IPriceVaccineService PriceVaccineService;

        public PriceVaccineController(IPriceVaccineService PriceVaccineService)
        {
            this.PriceVaccineService = PriceVaccineService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var response = await PriceVaccineService.GetPriceVaccines();
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
                var response = await PriceVaccineService.GetPriceVaccine(id);
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
                var response = await PriceVaccineService.DeletePriceVaccine(id);
                return Ok(response);
            }
            catch (Exception ec)
            {
                return BadRequest(ec.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdatePriceVaccineRequest request)
        {
            try
            {
                var response = await PriceVaccineService.UpdatePriceVaccine(request);
                return Ok(response);
            }
            catch (Exception ec)
            {
                return BadRequest(ec.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreatePriceVaccineRequest request)
        {
            try
            {
                var response = await PriceVaccineService.CreatePriceVaccine(request);
                return Ok(response);
            }
            catch (Exception ec)
            {
                return BadRequest(ec.Message);
            }
        }
    }
}