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
    public class VaccineBatchFluentAPI : IEntityTypeConfiguration<DtoVaccineBatch>
    {
        public void Configure(EntityTypeBuilder<DtoVaccineBatch> builder)
        {
            builder.ToTable("VaccineBatch");
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
            builder.Property(x => x.Id).HasMaxLength(50);
            builder.Property(x => x.VaccineId).HasMaxLength(50);
            builder.Property(x => x.SupplierId).HasMaxLength(50);
            //
            builder.HasKey(x => new { x.Id });
            builder.Property(x => x.CodeBatch);
            builder.Property(x => x.Country);
            builder.Property(x => x.QuantityOfVaccine);

            builder.Property(x => x.ManufacturingDate).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.ExpirationDate).HasDefaultValue(DateTime.Now);
            builder.HasOne(x => x.PriceVaccine).WithOne(x => x.VaccinceBatch).HasForeignKey<DtoPriceVaccine>(x => x.IdVaccineBacth);
            builder.HasOne(x => x.Supplier).WithMany(c => c.VaccineBatches).HasForeignKey(x => x.SupplierId).HasConstraintName("fk_batch_supplier").OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.VaccinationRegistration).WithOne(x => x.VaccineBatch).HasForeignKey<DtoVaccinationRegistration>(x => x.IdVaccineBatch);
            builder.Property(x => x.UpdatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
        }
    }
}