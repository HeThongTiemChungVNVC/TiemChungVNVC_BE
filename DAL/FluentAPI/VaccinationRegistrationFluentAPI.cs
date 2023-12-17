using DAL.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.FluentAPI
{
	public class VaccinationRegistrationFluentAPI : IEntityTypeConfiguration<DtoVaccinationRegistration>
	{
		public void Configure(EntityTypeBuilder<DtoVaccinationRegistration> builder)
		{
			builder.ToTable("VaccinationRegistration");
			builder.Property(x => x.IsDeleted).HasDefaultValue(false);
			builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
			builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
			builder.Property(x => x.Id).HasMaxLength(50);
			builder.Property(x => x.IdVaccineBatch).HasMaxLength(50);
			builder.Property(x => x.IdEmployee).HasMaxLength(50);
			builder.Property(x => x.IdCustomer).HasMaxLength(50);
			builder.Property(x => x.IdVaccinationCenter).HasMaxLength(50);
			builder.Property(x => x.NumberOfDosesRemaining);
			builder.Property(x => x.NameCustomer);
			builder.Property(x => x.VaccinationDate);
			builder.Property(x => x.Note);
			builder.Property(x => x.Status).HasDefaultValue(0);
			builder.Property(x => x.TotalPrice);
			builder.HasKey(x => x.Id);
			builder.HasMany(x => x.DetailsVacccinationRegistrations);
			//
			builder.HasOne(x => x.VaccineBatch).WithMany(x => x.VaccinationRegistrations).HasForeignKey(x => x.IdVaccineBatch).HasConstraintName("FK_registration_batch").OnDelete(DeleteBehavior.NoAction);
			builder.HasOne(x => x.VaccinationCenter).WithMany(c => c.VaccinationRegistrations).HasForeignKey(x => x.IdVaccinationCenter).HasConstraintName("FK_registration_center").OnDelete(DeleteBehavior.NoAction);
			builder.HasOne(x => x.Customer).WithMany(c => c.VaccinationRegistrations).HasForeignKey(x => x.IdCustomer).HasConstraintName("FK_registration_Customer").OnDelete(DeleteBehavior.NoAction);
			builder.HasOne(x => x.Employee).WithMany(c => c.VaccinationRegistrations).HasForeignKey(x => x.IdEmployee).HasConstraintName("FK_registration_employee").OnDelete(DeleteBehavior.NoAction);
			builder.Property(x => x.UpdatedTime).HasDefaultValue(DateTime.Now);
			builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
		}
	}
}