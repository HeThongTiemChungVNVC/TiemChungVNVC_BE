using BLL.Requests;
using BLL.Services.Constracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TiemChungVNVC_BE.Controllers
{
    [Route("api/injection-charts")]
    [ApiController]
    public class InjectionChartController : ControllerBase
    {
        private readonly IInjectionChartService InjectionChartService;

        public InjectionChartController(IInjectionChartService InjectionChartService)
        {
            this.InjectionChartService = InjectionChartService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var response = await InjectionChartService.GetInjectionCharts();
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
                var response = await InjectionChartService.GetInjectionChart(id);
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
                var response = await InjectionChartService.DeleteInjectionChart(id);
                return Ok(response);
            }
            catch (Exception ec)
            {
                return BadRequest(ec.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateInjectionChartRequest request)
        {
            try
            {
                var response = await InjectionChartService.UpdateInjectionChart(request);
                return Ok(response);
            }
            catch (Exception ec)
            {
                return BadRequest(ec.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateInjectionChartRequest request)
        {
            try
            {
                var response = await InjectionChartService.CreateInjectionChart(request);
                return Ok(response);
            }
            catch (Exception ec)
            {
                return BadRequest(ec.Message);
            }
        }
    }
}