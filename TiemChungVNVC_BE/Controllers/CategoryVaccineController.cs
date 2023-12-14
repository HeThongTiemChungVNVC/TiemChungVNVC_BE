using BLL.Requests;
using BLL.Services.Constracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TiemChungVNVC_BE.Controllers
{
    [Route("api/category-vaccines")]
    [ApiController]
    public class CategoryVaccineController : ControllerBase
    {
        private readonly ICategoryVaccineService categoryVaccineService;

        public CategoryVaccineController(ICategoryVaccineService categoryVaccineService)
        {
            this.categoryVaccineService = categoryVaccineService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var response = await categoryVaccineService.GetCategoryVaccines();
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
                var response = await categoryVaccineService.GetCategoryVaccine(id);
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
                var response = await categoryVaccineService.DeleteCategoryVaccine(id);
                return Ok(response);
            }
            catch (Exception ec)
            {
                return BadRequest(ec.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateCategoryVaccineRequest request)
        {
            try
            {
                var response = await categoryVaccineService.UpdateCategoryVaccine(request);
                return Ok(response);
            }
            catch (Exception ec)
            {
                return BadRequest(ec.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryVaccineRequest request)
        {
            try
            {
                var response = await categoryVaccineService.CreateCategoryVaccine(request);
                return Ok(response);
            }
            catch (Exception ec)
            {
                return BadRequest(ec.Message);
            }
        }
    }
}