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
    public class SupplierFluentAPI : IEntityTypeConfiguration<DtoSupplier>
    {
        public void Configure(EntityTypeBuilder<DtoSupplier> builder)
        {
            builder.ToTable("Supplier");
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
            builder.Property(x => x.Id).HasMaxLength(50);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NameSupplier);
            builder.Property(x => x.Address);
            builder.Property(x => x.Phone);
            builder.Property(x => x.Email);
            builder.HasMany(x => x.VaccineBatches);
            builder.Property(x => x.UpdatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
        }
    }
}