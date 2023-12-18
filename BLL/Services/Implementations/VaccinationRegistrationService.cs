using BLL.Common;
using BLL.Requests;
using BLL.Responses;
using BLL.Services.Constracts;
using DAL.Dtos;
using Microsoft.EntityFrameworkCore;
using Repository.DbContexts;
using Repository.Repository;
using System.Globalization;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BLL.Services.Implementations
{
	public class VaccinationRegistrationService : IVaccinationRegistrationSevice
	{
		private readonly IMapper _mapper;
		private readonly ICustomerService _customerService;
		private readonly IEmailService _emailService;
		private readonly IRepository<DtoVaccinationRegistration> _repositoryVaccinationRegistration;
		private readonly IRepository<DtoCustomer> _repositoryCustomer;
		private readonly IRepository<DtoVaccineBatch> _repositoryBatch;
		private VNVCContext _context;

		public VaccinationRegistrationService(IMapper mapper, VNVCContext context, IRepository<DtoVaccinationRegistration> repositoryVaccinationRegistration, ICustomerService customerService, IRepository<DtoCustomer> repositoryCustomer, IEmailService emailService, IRepository<DtoVaccineBatch> repositoryBatch)
		{
			_mapper = mapper;
			_context = context;
			_repositoryVaccinationRegistration = repositoryVaccinationRegistration;
			_customerService = customerService;
			_repositoryCustomer = repositoryCustomer;
			_emailService = emailService;
			_repositoryBatch = repositoryBatch;
		}

		public async Task<ApiResponse<string>> CreateVaccinationRegistration(CreateVaccinationRegistrationRequest createVaccinationRegistrationRequest)
		{
			try
			{
				var categoryVacine = _mapper.Map<DtoVaccinationRegistration>(createVaccinationRegistrationRequest);
				_repositoryVaccinationRegistration.Insert(categoryVacine);
				return ApiResponse<string>.ApiResponseSuccess("Thêm thành công");
			}
			catch (Exception ec)
			{
				return ApiResponse<string>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<string>> DeleteVaccinationRegistration(string idVaccinationRegistration)
		{
			try
			{
				var entity = _repositoryVaccinationRegistration.GetAll().FirstOrDefault(x => x.Id == idVaccinationRegistration);
				if (entity == null)
				{
					return ApiResponse<string>.ApiResponseFail("Phiếu đăng ký tiêm này không tồn tại");
				}
				entity.IsDeleted = true;
				_repositoryVaccinationRegistration.Update(entity);
				return ApiResponse<string>.ApiResponseSuccess("Xóa thành công");
			}
			catch (Exception ec)
			{
				return ApiResponse<string>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<VaccinationRegistrationResponse>> GetVaccinationRegistration(string idVaccinationRegistration)
		{
			try
			{
				var entity = _context.VaccinationRegistrations.Include(x=>x.Employee).Include(x => x.VaccineBatch).ThenInclude(x => x.Vaccine).Include(x => x.Customer).Include(x => x.VaccinationCenter).FirstOrDefault(x => x.Id == idVaccinationRegistration && !x.IsDeleted);
				if (entity == null)
				{
					return ApiResponse<VaccinationRegistrationResponse>.ApiResponseFail("Phiếu đăng ký tiêm này không tồn tại");
				}
				var response = _mapper.Map<VaccinationRegistrationResponse>(entity);
				return ApiResponse<VaccinationRegistrationResponse>.ApiResponseSuccess(response);
			}
			catch (Exception ec)
			{
				return ApiResponse<VaccinationRegistrationResponse>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<VaccinationRegistrationResponse>> GetVaccinationRegistrationByCodeCustomer(string codeCustomer)
		{
			try
			{
				var customer = _context.Customers.FirstOrDefault(x => x.CodeCustomer == codeCustomer);
				if (customer == null)
				{
					return ApiResponse<VaccinationRegistrationResponse>.ApiResponseFail("Không tồn tại khách hàng này");
				}
				var entity = _context.VaccinationRegistrations.Include(x => x.Employee).Include(x => x.VaccineBatch).ThenInclude(x => x.Vaccine).Include(x => x.Customer).Include(x => x.VaccinationCenter).FirstOrDefault(x => x.IdCustomer == customer.Id);
				if (entity == null)
				{
					return ApiResponse<VaccinationRegistrationResponse>.ApiResponseFail("Khách hàng này chưa đăng ký tiêm tại đây");
				}
				var response = _mapper.Map<VaccinationRegistrationResponse>(entity);
				return ApiResponse<VaccinationRegistrationResponse>.ApiResponseSuccess(response);
			}
			catch (Exception ec)
			{
				return ApiResponse<VaccinationRegistrationResponse>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<List<VaccinationRegistrationResponse>>> GetVaccinationRegistrations()
		{
			try
			{
				var entity = _context.VaccinationRegistrations.Include(x => x.Employee).Include(x => x.VaccineBatch).ThenInclude(x => x.Vaccine).Include(x => x.Customer).Include(x => x.VaccinationCenter).Where(x => !x.IsDeleted).ToList();
				if (entity.Count() == 0)
				{
					return ApiResponse<List<VaccinationRegistrationResponse>>.ApiResponseFail("Chưa có dữ liệu");
				}
				var response = entity.Select(_mapper.Map<DtoVaccinationRegistration, VaccinationRegistrationResponse>).ToList();
				return ApiResponse<List<VaccinationRegistrationResponse>>.ApiResponseSuccess(response);
			}
			catch (Exception ec)
			{
				return ApiResponse<List<VaccinationRegistrationResponse>>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<string>> RegistrationVaccination(RegistrationRequest registrationRequest)
		{
			try
			{
				string format = "dd/MM/yyyy";
				var email = registrationRequest.Email;
				DateTime dob = DateTime.ParseExact(registrationRequest.Dob, format, CultureInfo.InvariantCulture);
				DateTime vaccinationDate = DateTime.ParseExact(registrationRequest.VaccinationDate, format, CultureInfo.InvariantCulture);
				// handle customer
				var dtoCustomer = new DtoCustomer()
				{
					Address = registrationRequest.Address,
					DateOfBirth = dob,
					FullName = registrationRequest.FullName,
					Email = registrationRequest.Email,
					Phone = registrationRequest.Phone,
					Gender = registrationRequest.Gender,
				};
				while (true)
				{
					var codeCustomer = "KH" + CustomerService.GetNumericPart(Guid.NewGuid());
					if (_repositoryCustomer.GetAll().FirstOrDefault(x => x.CodeCustomer == codeCustomer) == null)
					{
						dtoCustomer.CodeCustomer = codeCustomer;
						break;
					}
				}
				// get vaccine batch
				var vaccineBatch = _context.VaccineBatches.Where(x => !x.IsDeleted && x.VaccineId == registrationRequest.IdVaccine).FirstOrDefault();
				if (vaccineBatch == null)
				{
					return ApiResponse<string>.ApiResponseFail("Hiện tại lô vaccine này chưa cập nhật trên hệ thống vui lòng đến trung tâm gần nhất để đăng ký tiêm");
				}
				// get price vaccine
				var priceVaccine = _context.PriceVaccines.Where(x => x.IdVaccineBacth == vaccineBatch.Id && !x.IsDeleted).FirstOrDefault();
				if (priceVaccine == null)
				{
					return ApiResponse<string>.ApiResponseFail("Hiện tại vaccine này chưa cập nhật giá tiền trên hệ thống vui lòng đến trung tâm gần nhất để đăng ký tiêm");
				}
				// get injection chart
				var injectionChart = _context.InjectionCharts.Where(x => x.IdVaccine == registrationRequest.IdVaccine && !x.IsDeleted).FirstOrDefault();
				if (injectionChart == null)
				{
					return ApiResponse<string>.ApiResponseFail("Hiện tại vaccine này chưa cập nhật phác đồ trên hệ thống vui lòng đến trung tâm gần nhất để đăng ký tiêm");
				}
				// get center
				var center = _context.VaccinationCenters.Where(x => x.Id == registrationRequest.IdVaccinationCenter && !x.IsDeleted).FirstOrDefault();
				if (center == null)
				{
					return ApiResponse<string>.ApiResponseFail("Center không tồn tại");
				}
				var customer = _repositoryCustomer.Insert(dtoCustomer);
				// handle registration
				var dtoRegis = new DtoVaccinationRegistration()
				{
					IdCustomer = customer.Id,
					IdEmployee = registrationRequest.IdEmployee ?? "admin",
					IdVaccinationCenter = registrationRequest.IdVaccinationCenter,
					NameCustomer = registrationRequest.FullName,
					Status = ValueConstant.PENDING,
					NumberOfDosesRemaining = injectionChart.Doses,
					TotalPrice = priceVaccine.RetailPrice * injectionChart.Doses,
					IdVaccineBatch = vaccineBatch.Id,
					Note = "",
					VaccinationDate = vaccinationDate
				};
				_repositoryVaccinationRegistration.Insert(dtoRegis);
				string body = $"Xin chào bạn: {registrationRequest.FullName}, cảm ơn bạn đã đăng ký tại hệ thống chúng tôi <br/>" +
				$"Vui lòng bạn đến trung tâm <b>{center.CenterName}</b> trong ngày: <b>{registrationRequest.VaccinationDate}</b><br/>" +
				$"Tại địa chỉ: <b>{center.Address}</b><br/>" +
				$"Mã khách hàng của bạn là: <b>{customer.CodeCustomer}</b><br/>";
				var responseMail = await _emailService.SendEmail(email, body, "Tiêm chủng VNVC - Đăng ký tiêm");
				if (responseMail == false)
				{
					return ApiResponse<string>.ApiResponseFail("Can not send email", null);
				}
				return ApiResponse<string>.ApiResponseSuccess("Thành công vui lòng kiểm tra hộp thư email của bạn", "Thành công vui lòng kiểm tra hộp thư email của bạn");
			}
			catch (Exception ec)
			{
				return ApiResponse<string>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<string>> UpdateVaccinationRegistration(UpdateVaccinationRegistrationRequest updateVaccinationRegistrationRequest)
		{
			try
			{
				var entity = _repositoryVaccinationRegistration.GetAll().FirstOrDefault(x => x.Id == updateVaccinationRegistrationRequest.Id);
				if (entity == null)
				{
					return ApiResponse<string>.ApiResponseFail("Phiếu đăng ký tiêm này không tồn tại");
				}
				if (!string.IsNullOrEmpty(updateVaccinationRegistrationRequest.NameCustomer))
				{
					entity.NameCustomer = updateVaccinationRegistrationRequest.NameCustomer;
				}
				if (!string.IsNullOrEmpty(updateVaccinationRegistrationRequest.IdVaccineBatch))
				{
					entity.IdVaccineBatch = updateVaccinationRegistrationRequest.IdVaccineBatch;
					// updatet toltal price
					// get vaccine batch
					var vaccineBatch = _context.VaccineBatches.Where(x => !x.IsDeleted && x.Id == updateVaccinationRegistrationRequest.IdVaccineBatch).FirstOrDefault();
					if (vaccineBatch == null)
					{
						return ApiResponse<string>.ApiResponseFail("Hiện tại lô vaccine này chưa cập nhật trên hệ thống vui lòng đến trung tâm gần nhất để đăng ký tiêm", "Hiện tại lô vaccine này chưa cập nhật trên hệ thống vui lòng đến trung tâm gần nhất để đăng ký tiêm");
					}
					// get price vaccine
					var priceVaccine = _context.PriceVaccines.Where(x => x.IdVaccineBacth == vaccineBatch.Id && !x.IsDeleted).FirstOrDefault();
					if (priceVaccine == null)
					{
						return ApiResponse<string>.ApiResponseFail("Hiện tại vaccine này chưa cập nhật giá tiền trên hệ thống vui lòng đến trung tâm gần nhất để đăng ký tiêm", "Hiện tại vaccine này chưa cập nhật giá tiền trên hệ thống vui lòng đến trung tâm gần nhất để đăng ký tiêm");
					}
					// get injection chart
					var injectionChart = _context.InjectionCharts.Where(x => x.IdVaccine == vaccineBatch.VaccineId && !x.IsDeleted).FirstOrDefault();
					if (injectionChart == null)
					{
						return ApiResponse<string>.ApiResponseFail("Hiện tại vaccine này chưa cập nhật phác đồ trên hệ thống vui lòng đến trung tâm gần nhất để đăng ký tiêm", "Hiện tại vaccine này chưa cập nhật phác đồ trên hệ thống vui lòng đến trung tâm gần nhất để đăng ký tiêm");
					}

					entity.NumberOfDosesRemaining = injectionChart.Doses;
					entity.TotalPrice = priceVaccine.RetailPrice * injectionChart.Doses;
					entity.IdVaccineBatch = vaccineBatch.Id;
				}
				if (!string.IsNullOrEmpty(updateVaccinationRegistrationRequest.IdVaccinationCenter))
				{
					entity.IdVaccinationCenter = updateVaccinationRegistrationRequest.IdVaccinationCenter;
				}
				DateTime result = DateTime.ParseExact(updateVaccinationRegistrationRequest.VaccinationDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
				entity.VaccinationDate = result;
				if (updateVaccinationRegistrationRequest.NumberOfDosesRemaining != null)
				{
					entity.NumberOfDosesRemaining = (int)updateVaccinationRegistrationRequest.NumberOfDosesRemaining;
				}
				if (updateVaccinationRegistrationRequest.Status != null)
				{
					if (updateVaccinationRegistrationRequest.Status == ValueConstant.PAID)
					{  // đã thanh toán thì trừ số lượng ra
						var vaccineBatch = _context.VaccineBatches.Where(x => !x.IsDeleted && x.Id == updateVaccinationRegistrationRequest.IdVaccineBatch).FirstOrDefault();
						if (vaccineBatch == null)
						{
							return ApiResponse<string>.ApiResponseFail("Hiện tại lô vaccine này chưa cập nhật trên hệ thống vui lòng đến trung tâm gần nhất để đăng ký tiêm", "Hiện tại lô vaccine này chưa cập nhật trên hệ thống vui lòng đến trung tâm gần nhất để đăng ký tiêm");
						}
						var quantity = vaccineBatch.QuantityOfVaccine - entity.NumberOfDosesRemaining;
						if (quantity < 0)
						{
							return ApiResponse<string>.ApiResponseFail("Hiện tại lô vaccine này không còn đủ số lượng vaccine vui lòng nhập hàng", "Hiện tại lô vaccine này không còn đủ vaccine vui lòng nhập hàng");
						}
						vaccineBatch.QuantityOfVaccine = quantity;
						_repositoryBatch.Update(vaccineBatch);
					}
					entity.Status = (int)updateVaccinationRegistrationRequest.Status;
				}

				if (!string.IsNullOrEmpty(updateVaccinationRegistrationRequest.Note))
				{
					entity.Note = updateVaccinationRegistrationRequest.Note;
				}
				entity.IdEmployee = updateVaccinationRegistrationRequest.IdEmployee;
				entity.UpdatedBy = updateVaccinationRegistrationRequest.IdEmployee;
				entity.UpdatedTime = DateTime.Now;
                _repositoryVaccinationRegistration.Update(entity);
				return ApiResponse<string>.ApiResponseSuccess("Cập nhật thành công", "Cập nhật thành công");
			}
			catch (Exception ec)
			{
				return ApiResponse<string>.ApiResponseFail(ec.Message);
			}
		}
	}
}