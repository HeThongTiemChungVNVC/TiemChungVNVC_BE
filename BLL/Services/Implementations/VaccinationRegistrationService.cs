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
using Repository.Migrations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.Xml;
using System.Diagnostics.Eventing.Reader;

namespace BLL.Services.Implementations
{
	public class VaccinationRegistrationService : IVaccinationRegistrationSevice
	{
		private readonly IMapper _mapper;
		private readonly ICustomerService _customerService;
		private readonly IEmailService _emailService;
		private readonly IRepository<DtoVaccinationRegistration> _repositoryVaccinationRegistration;
		private readonly IRepository<DtoDetailVaccinationRegistration> _repositoryDetailVaccinationRegistration;
		private readonly IRepository<DtoCustomer> _repositoryCustomer;
		private readonly IRepository<DtoVaccineBatch> _repositoryBatch;
		private VNVCContext _context;

		public VaccinationRegistrationService(IMapper mapper, VNVCContext context, IRepository<DtoVaccinationRegistration> repositoryVaccinationRegistration, ICustomerService customerService, IRepository<DtoCustomer> repositoryCustomer, IEmailService emailService, IRepository<DtoVaccineBatch> repositoryBatch, IRepository<DtoDetailVaccinationRegistration> repositoryDetailVaccinationRegistration)
		{
			_mapper = mapper;
			_context = context;
			_repositoryVaccinationRegistration = repositoryVaccinationRegistration;
			_customerService = customerService;
			_repositoryCustomer = repositoryCustomer;
			_emailService = emailService;
			_repositoryBatch = repositoryBatch;
			_repositoryDetailVaccinationRegistration = repositoryDetailVaccinationRegistration;
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
				var entity = (from c in _context.VaccinationRegistrations
							  join e in _context.Employees on c.IdEmployee equals e.Id
							  join batch in _context.VaccineBatches on c.IdVaccineBatch equals batch.Id
							  join center in _context.VaccinationCenters on c.IdVaccinationCenter equals center.Id
							  join customer in _context.Customers on c.IdCustomer equals customer.Id

							  where !c.IsDeleted && c.Id == idVaccinationRegistration
							  select new VaccinationRegistrationResponse()
							  {
								  Id = c.Id,
								  IdEmployee = c.IdEmployee,
								  IdCustomer = c.IdCustomer,
								  Customer = new CustomerResponse() { FullName = customer.FullName, Id = customer.Id, CodeCustomer = customer.CodeCustomer },
								  VaccineBatch = new VaccineBatchResponse()
								  {
									  Id = batch.Id,
									  CodeBatch = batch.CodeBatch,
									  Vaccine = new VaccineResponse() { NameVaccine = batch.Vaccine.NameVaccine }
								  },
								  TotalPrice = c.TotalPrice,
								  Note = c.Note,
								  VaccinationCenter = new VaccinationCenterResponse()
								  {
									  Id = center.Id,
									  CenterName = center.CenterName
								  },
								  Employee = new EmployeeResponse()
								  {
									  FullName = e.FullName,
									  CodeEmployee = e.CodeEmployee
								  },
								  IdVaccinationCenter = c.IdVaccinationCenter,
								  IdVaccineBatch = c.IdVaccineBatch,
								  Status = c.Status,
								  VaccinationDate = c.VaccinationDate
							  }).FirstOrDefault();
				var details = _context.DetailVaccinationRegistrations.Where(x => x.IdVaccinationRegistration == idVaccinationRegistration && !x.IsDeleted).ToList();
				entity.DetailsVacccinationRegistrations = details.Select(_mapper.Map<DtoDetailVaccinationRegistration, DetailVaccinationRegistrationResponse>).ToList();
				if (entity == null)
				{
					return ApiResponse<VaccinationRegistrationResponse>.ApiResponseFail("Phiếu đăng ký tiêm này không tồn tại");
				}
				return ApiResponse<VaccinationRegistrationResponse>.ApiResponseSuccess(entity);
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
				var entity_c = (from c in _context.VaccinationRegistrations
								join e in _context.Employees on c.IdEmployee equals e.Id
								join batch in _context.VaccineBatches on c.IdVaccineBatch equals batch.Id
								join center in _context.VaccinationCenters on c.IdVaccinationCenter equals center.Id
								join customer in _context.Customers on c.IdCustomer equals customer.Id

								where !c.IsDeleted
								select new VaccinationRegistrationResponse()
								{
									Id = c.Id,
									IdEmployee = c.IdEmployee,
									IdCustomer = c.IdCustomer,	
									Customer = new CustomerResponse() { FullName = customer.FullName, Id = customer.Id, CodeCustomer = customer.CodeCustomer },
									VaccineBatch = new VaccineBatchResponse()
									{
										Id = batch.Id,
										CodeBatch = batch.CodeBatch,
										Vaccine = new VaccineResponse() { NameVaccine = batch.Vaccine.NameVaccine }
									},
									TotalPrice = c.TotalPrice,
									Note = c.Note,
									VaccinationCenter = new VaccinationCenterResponse()
									{
										Id = center.Id,
										CenterName = center.CenterName
									},
									Employee = new EmployeeResponse()
									{
										FullName = e.FullName,
										CodeEmployee = e.CodeEmployee

									},
									IdVaccinationCenter = c.IdVaccinationCenter,
									IdVaccineBatch = c.IdVaccineBatch,
									Status = c.Status,
									VaccinationDate = c.VaccinationDate
								}).ToList();
				if (entity_c.Count() == 0)
				{
					return ApiResponse<List<VaccinationRegistrationResponse>>.ApiResponseFail("Chưa có dữ liệu");
				}
				return ApiResponse<List<VaccinationRegistrationResponse>>.ApiResponseSuccess(entity_c);
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
				var isExistCustomer = false;
				var idCustomer = "";
				var codeCustomer = "";
				if (!string.IsNullOrEmpty(registrationRequest.CodeCustomer))
				{
					var checkCustomer = _context.Customers.FirstOrDefault(x => x.CodeCustomer == registrationRequest.CodeCustomer);
					if (checkCustomer != null)
					{
						isExistCustomer = true;
						idCustomer = checkCustomer.Id;
						codeCustomer = checkCustomer.CodeCustomer;
					}
				}

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
					var codeCustomerTemp = "KH" + CustomerService.GetNumericPart(Guid.NewGuid());
					if (_repositoryCustomer.GetAll().FirstOrDefault(x => x.CodeCustomer == codeCustomerTemp) == null)
					{
						dtoCustomer.CodeCustomer = codeCustomerTemp;
						codeCustomer = codeCustomerTemp;
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
				if (!isExistCustomer)
				{
					var customer = _repositoryCustomer.Insert(dtoCustomer);
					idCustomer = customer.Id;
				}
				// handle registration
				var dtoRegis = new DtoVaccinationRegistration()
				{
					IdCustomer = idCustomer,
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
				$"Mã khách hàng của bạn là: <b>{codeCustomer}</b><br/>";
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

		public async Task<ApiResponse<string>> RegistrationVaccinationByAdmin(RegistrationRequestByAdmin registrationRequest)
		{
			try
			{
				var checkCustomer = _context.Customers.FirstOrDefault(x => x.CodeCustomer == registrationRequest.CodeCustomer);
				if (checkCustomer == null)
				{
					return ApiResponse<string>.ApiResponseFail("Không tồn tại khách hàng này", "Không tồn tại khách hàng này");
				}
				string format = "dd/MM/yyyy";
				DateTime vaccinationDate = DateTime.ParseExact(registrationRequest.VaccinationDate, format, CultureInfo.InvariantCulture);
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
					return ApiResponse<string>.ApiResponseFail("Trung tâm không tồn tại");
				}

				// handle registration
				var dtoRegis = new DtoVaccinationRegistration()
				{
					IdCustomer = checkCustomer.Id,
					IdEmployee = registrationRequest.IdEmployee ?? "admin",
					IdVaccinationCenter = registrationRequest.IdVaccinationCenter,
					NameCustomer = checkCustomer.FullName,
					Status = ValueConstant.PENDING,
					NumberOfDosesRemaining = injectionChart.Doses,
					TotalPrice = priceVaccine.RetailPrice * injectionChart.Doses,
					IdVaccineBatch = vaccineBatch.Id,
					Note = "",
					VaccinationDate = vaccinationDate
				};
				_repositoryVaccinationRegistration.Insert(dtoRegis);
				return ApiResponse<string>.ApiResponseSuccess("Đăng ký thành công", "Đăng ký thành công");
			}
			catch (Exception ec)
			{
				return ApiResponse<string>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<string>> SendEmailReminder(string idDetailRegistration)
		{
			try
			{
				var dtoDetail = _context.DetailVaccinationRegistrations.Include(x => x.VaccinationRegistration).FirstOrDefault(x => x.Id == idDetailRegistration);
				if (dtoDetail == null)
				{
					return ApiResponse<string>.ApiResponseFail("Không tồn tại chi tiết này");
				}
				var vaccinationRegistration = _context.VaccinationRegistrations.Include(x => x.Employee).Include(x => x.DetailsVacccinationRegistrations).Include(x => x.VaccineBatch).ThenInclude(x => x.Vaccine).Include(x => x.Customer).Include(x => x.VaccinationCenter).FirstOrDefault(x => x.Id == dtoDetail.IdVaccinationRegistration && !x.IsDeleted);
				var days = (dtoDetail.DateVaccination - DateTime.Now).Days;
				var mess = "";
				if (days < 0)
				{
					mess = "bạn đã trễ hẹn lịch tiêm vui lòng đến trung tâm sớm nhất để tiêm";
				}
				else if (days == 0)
				{
					mess = "bạn có lịch tiêm vào ngày hôm nay vui lòng bạn đến trung tâm";
				}
				else
				{
					mess = $"sắp tới bạn có lịch tiêm tại hệ thống Tiêm Chủng VNVC còn {days} ngày";
				}
				string body = $"Xin chào bạn: {vaccinationRegistration.Customer.FullName}, {mess} .<br/>" +
				$"Vui lòng bạn đến trung tâm <b>{vaccinationRegistration.VaccinationCenter.CenterName}</b> vào ngày: <b>{dtoDetail.DateVaccination.ToString("dd/MM/yyyy")}.</b><br/>" +
				$"Tại địa chỉ: <b>{vaccinationRegistration.VaccinationCenter.Address}</b><br/>" +
				$"Mã khách hàng của bạn là: <b>{vaccinationRegistration.Customer.CodeCustomer}</b><br/>";
				var responseMail = await _emailService.SendEmail(vaccinationRegistration.Customer.Email, body, "Tiêm chủng VNVC - Nhắc lịch tiêm");
				if (responseMail == false)
				{
					return ApiResponse<string>.ApiResponseFail("Can not send email", null);
				}
				return ApiResponse<string>.ApiResponseSuccess("Đã gửi email nhắc lịch đến cho khách hàng", "Đã gửi email nhắc lịch đến cho khách hàng");
			}
			catch (Exception ec)
			{
				return ApiResponse<string>.ApiResponseFail(ec.Message);
			}
		}

		public async Task<ApiResponse<string>> UpdateDetailRegistrationVaccination(UpdateDetailRegistrationVaccinationRequest updateDetailRegistrationVaccinationRequest)
		{
			try
			{
				var dto = _repositoryDetailVaccinationRegistration.Get(updateDetailRegistrationVaccinationRequest.Id);
				if (dto == null)
				{
					return ApiResponse<string>.ApiResponseFail("Không tồn tại chi tiết này");
				}
				if (updateDetailRegistrationVaccinationRequest.Status != null)
				{
					dto.Status = (int)updateDetailRegistrationVaccinationRequest.Status;
				}
				if (!string.IsNullOrEmpty(updateDetailRegistrationVaccinationRequest.Description))
				{
					dto.Description = updateDetailRegistrationVaccinationRequest.Description;
				}
				dto.UpdatedTime = DateTime.Now;
				_repositoryDetailVaccinationRegistration.Update(dto);
				return ApiResponse<string>.ApiResponseSuccess("Cập nhật thành công", "Cập nhật thành công");
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
						// tạo chi tiết tiêm của phiếu tiêm này
						// get injection chart
						var injectionChart = _context.InjectionCharts.Where(x => x.IdVaccine == vaccineBatch.VaccineId && !x.IsDeleted).FirstOrDefault();
						if (injectionChart == null)
						{
							return ApiResponse<string>.ApiResponseFail("Hiện tại vaccine này chưa cập nhật phác đồ trên hệ thống vui lòng đến trung tâm gần nhất để đăng ký tiêm", "Hiện tại vaccine này chưa cập nhật phác đồ trên hệ thống vui lòng đến trung tâm gần nhất để đăng ký tiêm");
						}
						var dayFirst = entity.VaccinationDate;
						for (int day = 0; day < entity.NumberOfDosesRemaining; day++)
						{
							var dtoDetail = new DtoDetailVaccinationRegistration()
							{
								IdVaccinationRegistration = entity.Id,
								DateVaccination = dayFirst,
								Status = ValueConstant.PENDING,
								Description = "",
								UpdatedBy = updateVaccinationRegistrationRequest.IdEmployee,
							};
							dayFirst = dayFirst.AddDays(injectionChart.Interval);
							_repositoryDetailVaccinationRegistration.Insert(dtoDetail);
						}
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