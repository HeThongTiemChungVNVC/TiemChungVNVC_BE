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
    public class PriceVaccineFluentAPI : IEntityTypeConfiguration<DtoPriceVaccine>
    {
        public void Configure(EntityTypeBuilder<DtoPriceVaccine> builder)
        {
            builder.ToTable("PriceVaccine");
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
            builder.Property(x => x.Id).HasMaxLength(50);
            builder.Property(x => x.IdVaccineBacth).HasMaxLength(50);
            //
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CostPrice);
            builder.Property(x => x.RetailPrice);
            builder.Property(x => x.PreOrderPrice);
            builder.Property(x => x.UpdatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
        }
    }
}