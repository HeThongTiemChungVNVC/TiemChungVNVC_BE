using BLL.Services.Constracts;
using BLL.Services.Implementations;
using Repository.Repositories;

namespace TiemChungVNVC_BE.Configurations
{
	public static class ConfigurationDI
	{
		public static IServiceCollection AddServiceDI(this IServiceCollection services)
		{
			////
			services.AddScoped<UserRepository>();
			services.AddScoped<RefeshTokenRepository>();
			services.AddScoped<InformationRepository>();
			services.AddScoped<ProvinceRepository>();
			services.AddScoped<RecoveryTokenRepository>();
			services.AddScoped<ProvinceRepository>();
			////
			services.AddScoped<IAuthService, AuthService>();// Repository done
			services.AddScoped<IEmailService, EmailService>();
			services.AddScoped<IOrtherService, OrtherService>();
			services.AddScoped<IProvinceService, ProvinceService>();
			services.AddScoped<ISupplierService, SupplierService>();
			services.AddScoped<ICategoryVaccineService, CategoryVaccineService>();
			services.AddScoped<ICategoryPositionService, CategoryPositionService>();
			services.AddScoped<IVaccineService, VaccineService>();
			services.AddScoped<IVaccineBatchService, VaccineBatchService>();
			services.AddScoped<IInjectionChartService, InjectionChartService>();
			services.AddScoped<IPriceVaccineService, PriceVaccineService>();
			services.AddScoped<IVaccinationCenterService, VaccinationCenterService>();
			services.AddScoped<ICustomerService, CustomerService>();
			services.AddScoped<IEmployeeService, EmployeeService>();
			services.AddScoped<IVaccinationRegistrationSevice, VaccinationRegistrationService>();

			return services;
		}
	}
}