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
    public class CustomerFluentAPI : IEntityTypeConfiguration<DtoCustomer>
    {
        public void Configure(EntityTypeBuilder<DtoCustomer> builder)
        {
            builder.ToTable("Customer");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
            builder.Property(x => x.Id).HasMaxLength(50);
            //
            builder.Property(x => x.FullName).HasMaxLength(100);
            builder.Property(x => x.CodeCustomer).HasMaxLength(100);
            builder.Property(x => x.Phone).HasMaxLength(11);
            builder.Property(x => x.Email).HasMaxLength(50);
            builder.Property(x => x.Address).HasMaxLength(50);
            builder.Property(x => x.Gender).HasMaxLength(10);
            builder.Property(x => x.DateOfBirth).HasDefaultValue(DateTime.Now);
            builder.HasMany(x => x.MedicalRecords);
            builder.HasMany(x => x.VaccinationRegistrations);
            builder.Property(x => x.UpdatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
        }
    }
}