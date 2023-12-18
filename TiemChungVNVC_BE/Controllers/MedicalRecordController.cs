using BLL.Requests;
using BLL.Services.Constracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TiemChungVNVC_BE.Controllers
{
    [Route("api/medical-records")]
    [ApiController]
    public class MedicalRecordController : ControllerBase
    {
        private readonly IMedicalRecordCustomerService _medicalRecordService;

        public MedicalRecordController(IMedicalRecordCustomerService medicalRecordService)
        {
            _medicalRecordService = medicalRecordService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var response = await _medicalRecordService.GetMedicalRecords();
                return Ok(response);
            }
            catch (Exception ec)
            {
                return BadRequest(ec.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateMedicalRecordRequest recordRequest)
        {
            try
            {
                var response = await _medicalRecordService.CreateMedicalRecord(recordRequest);
                return Ok(response);
            }
            catch (Exception ec)
            {
                return BadRequest(ec.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            try
            {
                var response = await _medicalRecordService.GetMedicalRecord(id);
                return Ok(response);
            }
            catch (Exception ec)
            {
                return BadRequest(ec.Message);
            }
        }

        [HttpGet("customer/{code_customer}")]
        public async Task<IActionResult> GetByCodeCustomer(string code_customer)
        {
            try
            {
                var response = await _medicalRecordService.GetMedicalRecordByCodeCustomer(code_customer);
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
                var response = await _medicalRecordService.DeleteMedicalRecord(id);
                return Ok(response);
            }
            catch (Exception ec)
            {
                return BadRequest(ec.Message);
            }
        }

        [HttpDelete("detail/{id}")]
        public async Task<IActionResult> DeleteDetail(string id)
        {
            try
            {
                var response = await _medicalRecordService.DeleteDetailMedicalRecord(id);
                return Ok(response);
            }
            catch (Exception ec)
            {
                return BadRequest(ec.Message);
            }
        }

        [HttpPost("detail")]
        public async Task<IActionResult> CreateDetail(CreateDetailMedicalRequest request)
        {
            try
            {
                var response = await _medicalRecordService.CreateDetailMedicalRecord(request);
                return Ok(response);
            }
            catch (Exception ec)
            {
                return BadRequest(ec.Message);
            }
        }

        [HttpPut("detail")]
        public async Task<IActionResult> UpdateDetail(UpdateDetailMedicalRequest request)
        {
            try
            {
                var response = await _medicalRecordService.UpdateDetailMedicalRecord(request);
                return Ok(response);
            }
            catch (Exception ec)
            {
                return BadRequest(ec.Message);
            }
        }
    }
}