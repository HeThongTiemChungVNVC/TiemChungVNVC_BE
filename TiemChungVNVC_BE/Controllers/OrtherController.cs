using BLL.Services.Constracts;
using Microsoft.AspNetCore.Mvc;

namespace TiemChungVNVC_BE.Controllers
{
    [Route("api/orther")]
    [ApiController]
    public class OrtherController : ControllerBase
    {
        private readonly IOrtherService _ortherService;

        public OrtherController(IOrtherService ortherService)
        {
            _ortherService = ortherService;
        }

        [HttpGet("check/email/{email}")]
        public async Task<IActionResult> CheckEmail(string email)
        {
            var response = await _ortherService.CheckEmail(email);
            return Ok(response);
        }

        [HttpGet("check/phone-number/{phonenumber}")]
        public async Task<IActionResult> CheckPhoneNumber(string phonenumber)
        {
            var response = await _ortherService.CheckPhoneNumber(phonenumber);
            return Ok(response);
        }

        [HttpGet("check/username/{username}")]
        public async Task<IActionResult> CheckUsername(string username)
        {
            var response = await _ortherService.CheckUsername(username);
            return Ok(response);
        }
    }
}