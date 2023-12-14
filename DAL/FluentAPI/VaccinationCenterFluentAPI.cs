using DAL.Dtos;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.FluentAPI
{
    public class VaccinationCenterFluentAPI : IEntityTypeConfiguration<DtoVaccinationCenter>
    {
        public void Configure(EntityTypeBuilder<DtoVaccinationCenter> builder)
        {
            builder.ToTable("VaccinationCenter");
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
            builder.Property(x => x.Id).HasMaxLength(50);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CenterName);
            builder.Property(x => x.Address);
            builder.Property(x => x.PhoneNumber);
            builder.Property(x => x.OpenTime);
            builder.Property(x => x.CloseTime);
            builder.HasMany(x => x.Employees);
            builder.HasMany(x => x.VaccinationRegistrations);
            builder.Property(x => x.UpdatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
        }
    }
}