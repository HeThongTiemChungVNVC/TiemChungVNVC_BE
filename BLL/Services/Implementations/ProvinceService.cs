using AutoMapper;
using BLL.Common;
using BLL.Responses;
using BLL.Services.Constracts;
using DAL.Dtos;
using Microsoft.Extensions.Logging;
using Repository.Repositories;
using System.Reflection;

namespace BLL.Services.Implementations
{
	public class ProvinceService : IProvinceService
	{
		private readonly ProvinceRepository _repositoryProvince;
		private readonly IMapper _mapper;
		private readonly ILogger<AuthService> _logger;

		public ProvinceService(
			IMapper mapper,
			ILogger<AuthService> logger,
			ProvinceRepository repositoryProvince
			)
		{
			_mapper = mapper;
			_logger = logger;
			_repositoryProvince = repositoryProvince;
		}

		public async Task<ApiResponse<List<CityResponse>>> GetCities()
		{
			try
			{
				var cities = _repositoryProvince.GetAllCities();
				if (cities.Count == 0)
				{
					return ApiResponse<List<CityResponse>>.ApiResponseFail("Call api get cities fail");
				}
				var citiesResponse = cities.Select(_mapper.Map<DtoCity, CityResponse>).ToList();

				return ApiResponse<List<CityResponse>>.ApiResponseSuccess(citiesResponse);
			}
			catch (Exception ec)
			{
				_logger.LogError($"|{DateTime.Now}|:  Exception error: {ec.Message}");
				return ApiResponse<List<CityResponse>>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<CityResponse>> GetCity(string id)
		{
			try
			{
				var city = _repositoryProvince.GetCity(id);
				if (city == null)
				{
					return ApiResponse<CityResponse>.ApiResponseFail("Not found city");
				}
				var cityResponse = _mapper.Map<CityResponse>(city);

				return ApiResponse<CityResponse>.ApiResponseSuccess(cityResponse);
			}
			catch (Exception ec)
			{
				_logger.LogError($"|{DateTime.Now}|:  Exception error: {ec.Message}");
				return ApiResponse<CityResponse>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<List<DistrictResponse>>> GetDistrictsByCity(string idCity)
		{
			try
			{
				var districts = _repositoryProvince.GetAllDictrictsByCity(idCity);
				if (districts.Count == 0)
				{
					return ApiResponse<List<DistrictResponse>>.ApiResponseFail($"Not found district by city id: {idCity}");
				}
				var districtsResponse = districts.Select(_mapper.Map<DtoDistrict, DistrictResponse>).ToList();

				return ApiResponse<List<DistrictResponse>>.ApiResponseSuccess(districtsResponse);
			}
			catch (Exception ec)
			{
				_logger.LogError($"|{DateTime.Now}|:  Exception error: {ec.Message}");
				return ApiResponse<List<DistrictResponse>>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<DistrictResponse>> GetDistrictById(string id)
		{
			try
			{
				var district = _repositoryProvince.GetAllDictrictsByCity(id);
				if (district == null)
				{
					return ApiResponse<DistrictResponse>.ApiResponseFail("Not found district");
				}
				var districtResponse = _mapper.Map<DistrictResponse>(district);
				return ApiResponse<DistrictResponse>.ApiResponseSuccess(districtResponse);
			}
			catch (Exception ec)
			{
				_logger.LogError($"|{DateTime.Now}|:  Exception error: {ec.Message}");
				return ApiResponse<DistrictResponse>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<List<WardResponse>>> GetWardsByDistrict(string idDistrict)
		{
			try
			{
				var wards = _repositoryProvince.GetAllWardsByDistrict(idDistrict);
				if (wards.Count == 0)
				{
					return ApiResponse<List<WardResponse>>.ApiResponseFail($"Not found wards by district id: {idDistrict}");
				}
				var wardsResponse = wards.Select(_mapper.Map<DtoWard, WardResponse>).ToList();

				return ApiResponse<List<WardResponse>>.ApiResponseSuccess(wardsResponse);
			}
			catch (Exception ec)
			{
				_logger.LogError($"|{DateTime.Now}|:  Exception error: {ec.Message}");
				return ApiResponse<List<WardResponse>>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<WardResponse>> GetWardById(string id)
		{
			try
			{
				var ward = _repositoryProvince.GetWard(id);
				if (ward == null)
				{
					return ApiResponse<WardResponse>.ApiResponseFail("Not found ward");
				}
				var wardResponse = _mapper.Map<WardResponse>(ward);
				return ApiResponse<WardResponse>.ApiResponseSuccess(wardResponse);
			}
			catch (Exception ec)
			{
				_logger.LogError($"|{DateTime.Now}|:  Exception error: {ec.Message}");
				return ApiResponse<WardResponse>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<string>> GetFullAddress(string idWard)
		{
			try
			{
				var city = _repositoryProvince.GetFullAddress(idWard);

				return ApiResponse<string>.ApiResponseSuccess(city);
			}
			catch (Exception ec)
			{
				_logger.LogError($"|{DateTime.Now}|:  Exception error: {ec.Message}");
				return ApiResponse<string>.ApiResponseFail(ec.Message);
			}
		}
	}
}