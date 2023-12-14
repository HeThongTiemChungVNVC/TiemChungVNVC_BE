using BLL.Requests;
using BLL.Services.Constracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TiemChungVNVC_BE.Controllers
{
    [Route("api/category-positions")]
    [ApiController]
    public class CategoryPositionController : ControllerBase
    {
        private readonly ICategoryPositionService CategoryPositionService;

        public CategoryPositionController(ICategoryPositionService CategoryPositionService)
        {
            this.CategoryPositionService = CategoryPositionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var response = await CategoryPositionService.GetCategoryPositions();
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
                var response = await CategoryPositionService.GetCategoryPosition(id);
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
                var response = await CategoryPositionService.DeleteCategoryPosition(id);
                return Ok(response);
            }
            catch (Exception ec)
            {
                return BadRequest(ec.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateCategoryPositionRequest request)
        {
            try
            {
                var response = await CategoryPositionService.UpdateCategoryPosition(request);
                return Ok(response);
            }
            catch (Exception ec)
            {
                return BadRequest(ec.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryPositionRequest request)
        {
            try
            {
                var response = await CategoryPositionService.CreateCategoryPosition(request);
                return Ok(response);
            }
            catch (Exception ec)
            {
                return BadRequest(ec.Message);
            }
        }
    }
}