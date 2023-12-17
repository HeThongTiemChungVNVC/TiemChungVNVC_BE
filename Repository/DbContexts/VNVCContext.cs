using DAL.Dtos;
using DAL.FluentAPI;
using Microsoft.EntityFrameworkCore;

namespace Repository.DbContexts
{
	public class VNVCContext : DbContext
	{
		public VNVCContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<DtoUser> Users { get; set; }
		public DbSet<DtoRefeshToken> RefeshTokens { get; set; }
		public DbSet<DtoPasswordRecoveryToken> RecoveryTokens { get; set; }

		//public DbSet<DtoCity> Cities { get; set; }
		//public DbSet<DtoDistrict> Districts { get; set; }
		//public DbSet<DtoWard> Wards { get; set; }
		public DbSet<DtoEmployee> Employees { get; set; }

		public DbSet<DtoCustomer> Customers { get; set; }
		public DbSet<DtoCategoryPosition> CategoryPositions { get; set; }

		public DbSet<DtoCategoryVaccine> CategoryVaccines { get; set; }
		public DbSet<DtoInjectionChart> InjectionCharts { get; set; }
		public DbSet<DtoPriceVaccine> PriceVaccines { get; set; }
		public DbSet<DtoSupplier> Suppliers { get; set; }
		public DbSet<DtoVaccinationCenter> VaccinationCenters { get; set; }
		public DbSet<DtoVaccine> Vaccines { get; set; }
		public DbSet<DtoVaccineBatch> VaccineBatches { get; set; }
		public DbSet<DtoDetailMedicalRecord> DetailMedicalRecords { get; set; }
		public DbSet<DtoMedicalRecord> MedicalRecords { get; set; }
		public DbSet<DtoVaccinationRegistration> VaccinationRegistrations { get; set; }
		public DbSet<DtoDetailVaccinationRegistration> DetailVaccinationRegistrations { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.ApplyConfiguration(new RefeshTokenFluentAPI());
			modelBuilder.ApplyConfiguration(new UserFluentAPI());
			modelBuilder.ApplyConfiguration(new PasswordRecoveryTokenFluentAPI());
			//modelBuilder.ApplyConfiguration(new CityFluentAPI());
			//modelBuilder.ApplyConfiguration(new DistrictFluentAPI());
			//modelBuilder.ApplyConfiguration(new WardFluentAPI());
			modelBuilder.ApplyConfiguration(new EmployeeFluentAPI());
			modelBuilder.ApplyConfiguration(new CustomerFluentAPI());
			modelBuilder.ApplyConfiguration(new CategoryPositionFluentAPI());
			modelBuilder.ApplyConfiguration(new CategoryVaccineFluentAPI());
			modelBuilder.ApplyConfiguration(new InjectionChartFluentAPI());
			modelBuilder.ApplyConfiguration(new PriceVaccineFluentAPI());
			modelBuilder.ApplyConfiguration(new SupplierFluentAPI());
			modelBuilder.ApplyConfiguration(new VaccinationCenterFluentAPI());
			modelBuilder.ApplyConfiguration(new VacineFluentAPI());
			modelBuilder.ApplyConfiguration(new VaccineBatchFluentAPI());
			modelBuilder.ApplyConfiguration(new DetailMedicalRecord());
			modelBuilder.ApplyConfiguration(new MedicalRecordFluentAPI());
			modelBuilder.ApplyConfiguration(new DetailVaccinationRegistrationFluentAPI());
			modelBuilder.ApplyConfiguration(new VaccinationRegistrationFluentAPI());
		}
	}
}