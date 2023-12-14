using BLL.Services.Constracts;
using Microsoft.AspNetCore.Mvc;

namespace TiemChungVNVC_BE.Controllers
{
	[Route("api/province")]
	[ApiController]
	public class ProvinceController : ControllerBase
	{
		private readonly IProvinceService _provinceService;

		public ProvinceController(IProvinceService provinceService)
		{
			_provinceService = provinceService;
		}

		[HttpGet("cities")]
		public async Task<IActionResult> GetCities()
		{
			var cities = await _provinceService.GetCities();
			if (!cities.IsSuccess)
			{
				return NotFound(cities);
			}
			return Ok(cities);
		}

		[HttpGet("cities/{id}/districts")]
		public async Task<IActionResult> GetDistrictsByCity(string id)
		{
			var districts = await _provinceService.GetDistrictsByCity(id);
			if (!districts.IsSuccess)
			{
				return NotFound(districts);
			}
			return Ok(districts);
		}

		[HttpGet("districts/{id}/wards")]
		public async Task<IActionResult> GetWardsByDistrict(string id)
		{
			var wards = await _provinceService.GetWardsByDistrict(id);
			if (!wards.IsSuccess)
			{
				return NotFound(wards);
			}
			return Ok(wards);
		}

		[HttpGet("city/{id}")]
		public async Task<IActionResult> GetCityById(string id)
		{
			var city = await _provinceService.GetCity(id);
			if (!city.IsSuccess)
			{
				return NotFound(city);
			}
			return Ok(city);
		}

		[HttpGet("district/{id}")]
		public async Task<IActionResult> GetDistrictsById(string id)
		{
			var district = await _provinceService.GetDistrictById(id);
			if (!district.IsSuccess)
			{
				return NotFound(district);
			}
			return Ok(district);
		}

		[HttpGet("ward/{id}")]
		public async Task<IActionResult> GetWardsById(string id)
		{
			var ward = await _provinceService.GetWardById(id);
			if (!ward.IsSuccess)
			{
				return NotFound(ward);
			}
			return Ok(ward);
		}

		[HttpGet("full-address/{id_ward}")]
		public async Task<IActionResult> GetFullAddress(string id_ward)
		{
			var ward = await _provinceService.GetFullAddress(id_ward);
			if (!ward.IsSuccess)
			{
				return NotFound(ward);
			}
			return Ok(ward);
		}
	}
}