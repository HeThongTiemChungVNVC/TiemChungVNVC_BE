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
	public class DetailVaccinationRegistrationFluentAPI : IEntityTypeConfiguration<DtoDetailVaccinationRegistration>
	{
		public void Configure(EntityTypeBuilder<DtoDetailVaccinationRegistration> builder)
		{
			builder.ToTable("DetailVaccinationRegistration");
			builder.Property(x => x.IsDeleted).HasDefaultValue(false);
			builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
			builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
			builder.Property(x => x.Id).HasMaxLength(50);
			builder.Property(x => x.IdVaccinationRegistration).HasMaxLength(50);
			builder.Property(x => x.DateVaccination).HasDefaultValue(DateTime.Now);
			builder.Property(x => x.Status).HasDefaultValue(0);
			builder.Property(x => x.Description);
			builder.HasKey(x => new { x.Id });
			//fk to table vaccination registration
			builder.HasOne(x => x.VaccinationRegistration)
			   .WithMany(x => x.DetailsVacccinationRegistrations)
			   .HasForeignKey(x => x.IdVaccinationRegistration)
			   .HasConstraintName("FK_details_vaccinationRegistration");
			builder.Property(x => x.UpdatedTime).HasDefaultValue(DateTime.Now);
			builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
		}
	}
}