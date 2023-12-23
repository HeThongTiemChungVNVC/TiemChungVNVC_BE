using AutoMapper;
using BLL.Common;
using BLL.Requests;
using BLL.Responses;
using BLL.Services.Constracts;
using DAL.Dtos;
using Microsoft.EntityFrameworkCore;
using Repository.DbContexts;
using Repository.Repository;

namespace BLL.Services.Implementations
{
	public class MedicalRecordCustomerService : IMedicalRecordCustomerService
	{
		private readonly IMapper _mapper;
		private readonly IRepository<DtoMedicalRecord> repository;
		private readonly IRepository<DtoDetailMedicalRecord> repositoryDetail;
		private VNVCContext _context;

		public MedicalRecordCustomerService(IMapper mapper, VNVCContext context, IRepository<DtoMedicalRecord> repository, IRepository<DtoDetailMedicalRecord> repositoryDetail)
		{
			_mapper = mapper;
			_context = context;
			this.repository = repository;
			this.repositoryDetail = repositoryDetail;
		}

		private static string GetNumericPart(Guid guid)
		{
			// Convert the GUID to a string and remove non-numeric characters
			string numericPart = new string(guid.ToString().Where(char.IsDigit).ToArray());

			// Ensure the length is 8 by taking the first 8 characters
			numericPart = numericPart.Length >= 6 ? numericPart.Substring(0, 6) : numericPart;

			return numericPart;
		}

		public async Task<ApiResponse<string>> CreateDetailMedicalRecord(CreateDetailMedicalRequest createDetailMedicalRequest)
		{
			try
			{
				var dtoDetail = _mapper.Map<DtoDetailMedicalRecord>(createDetailMedicalRequest);
				repositoryDetail.Insert(dtoDetail);
				return ApiResponse<string>.ApiResponseSuccess("Thêm thành công");
			}
			catch (Exception ec)
			{
				return ApiResponse<string>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<string>> CreateMedicalRecord(CreateMedicalRecordRequest createMedicalRecordRequest)
		{
			try
			{
				var MedicalRecord = _mapper.Map<DtoMedicalRecord>(createMedicalRecordRequest);
				while (true)
				{
					var codeMedicalRecord = "HS" + GetNumericPart(Guid.NewGuid());
					if (repository.GetAll().FirstOrDefault(x => x.CodeMedicalRecord == codeMedicalRecord) == null)
					{
						MedicalRecord.CodeMedicalRecord = codeMedicalRecord;
						break;
					}
				}

				repository.Insert(MedicalRecord);
				return ApiResponse<string>.ApiResponseSuccess("Thêm thành công", "Thêm thành công");
			}
			catch (Exception ec)
			{
				return ApiResponse<string>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<string>> DeleteDetailMedicalRecord(string idDetailMedicalRecord)
		{
			try
			{
				var entity = repositoryDetail.Get(idDetailMedicalRecord);
				if (entity == null)
				{
					return ApiResponse<string>.ApiResponseFail("Chi tiết hồ sơ này không tồn tại", "Chi tiết hồ sơ này không tồn tại");
				}
				entity.IsDeleted = true;
				repositoryDetail.Update(entity);
				return ApiResponse<string>.ApiResponseSuccess("Xóa thành công", "Xóa thành công");
			}
			catch (Exception ec)
			{
				return ApiResponse<string>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<string>> DeleteMedicalRecord(string idMedicalRecord)
		{
			try
			{
				var entity = repository.GetAll().FirstOrDefault(x => x.Id == idMedicalRecord);
				if (entity == null)
				{
					return ApiResponse<string>.ApiResponseFail("Hồ sơ này không tồn tại", "Hồ sơ này không tồn tại");
				}
				entity.IsDeleted = true;
				repository.Update(entity);
				return ApiResponse<string>.ApiResponseSuccess("Xóa thành công", "Xóa thành công");
			}
			catch (Exception ec)
			{
				return ApiResponse<string>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<MedicalRecordResponse>> GetMedicalRecord(string idMedicalRecord)
		{
			try
			{
				var entity = repository.GetAll().AsQueryable().Include(x => x.Customer).Include(x => x.DetailMedicalRecords.Where(x => !x.IsDeleted)).FirstOrDefault(x => x.Id == idMedicalRecord && !x.IsDeleted);
				if (entity == null)
				{
					return ApiResponse<MedicalRecordResponse>.ApiResponseFail("Hồ sơ này không tồn tại");
				}
				var response = _mapper.Map<MedicalRecordResponse>(entity);
				return ApiResponse<MedicalRecordResponse>.ApiResponseSuccess(response);
			}
			catch (Exception ec)
			{
				return ApiResponse<MedicalRecordResponse>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<MedicalRecordResponse>> GetMedicalRecordByCodeCustomer(string codeCustomer)
		{
			try
			{
				var entity = repository.GetAll().AsQueryable().Include(x => x.Customer).Include(x => x.DetailMedicalRecords.Where(x => !x.IsDeleted)).FirstOrDefault(x => x.Customer.CodeCustomer == codeCustomer && !x.IsDeleted);
				if (entity == null)
				{
					return ApiResponse<MedicalRecordResponse>.ApiResponseFail("Hồ sơ này không tồn tại");
				}
				var response = _mapper.Map<MedicalRecordResponse>(entity);
				return ApiResponse<MedicalRecordResponse>.ApiResponseSuccess(response);
			}
			catch (Exception ec)
			{
				return ApiResponse<MedicalRecordResponse>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<List<MedicalRecordResponse>>> GetMedicalRecords()
		{
			try
			{
				var entity = repository.GetAll().AsQueryable().Include(x => x.Customer).Where(x => !x.IsDeleted).ToList();
				if (entity.Count() == 0)
				{
					return ApiResponse<List<MedicalRecordResponse>>.ApiResponseFail("Chưa có dữ liệu");
				}
				var response = entity.Select(_mapper.Map<DtoMedicalRecord, MedicalRecordResponse>).ToList();
				return ApiResponse<List<MedicalRecordResponse>>.ApiResponseSuccess(response);
			}
			catch (Exception ec)
			{
				return ApiResponse<List<MedicalRecordResponse>>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<string>> UpdateDetailMedicalRecord(UpdateDetailMedicalRequest updateDetailMedicalRequest)
		{
			try
			{
				var dtoDetail = repositoryDetail.Get(updateDetailMedicalRequest.Id);
				if (dtoDetail == null)
				{
					return ApiResponse<string>.ApiResponseFail("Không tồn tại chi tiết khám sàn lọc này");
				}
				dtoDetail.UpdatedTime = DateTime.Now;
				dtoDetail.BodyTemperature = updateDetailMedicalRequest.BodyTemperature;
				dtoDetail.BackgroundIllness = updateDetailMedicalRequest.BackgroundIllness;
				// additional
				dtoDetail.BloodPressure = updateDetailMedicalRequest.BloodPressure;
				dtoDetail.Height = updateDetailMedicalRequest.Height;
				dtoDetail.MedicalHistory = updateDetailMedicalRequest.MedicalHistory;
				dtoDetail.CurrentHealthStatus = updateDetailMedicalRequest.CurrentHealthStatus;
				dtoDetail.Weight = updateDetailMedicalRequest.Weight;
				repositoryDetail.Update(dtoDetail);
				return ApiResponse<string>.ApiResponseSuccess("Sửa thành công", "Sửa thành công");
			}
			catch (Exception ec)
			{
				return ApiResponse<string>.ApiResponseFail(ec.Message);
			}
		}
	}
}