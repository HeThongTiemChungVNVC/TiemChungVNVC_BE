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
    public class CategoryVaccineFluentAPI : IEntityTypeConfiguration<DtoCategoryVaccine>
    {
        public void Configure(EntityTypeBuilder<DtoCategoryVaccine> builder)
        {
            builder.ToTable("CategoryVaccine");
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
            builder.Property(x => x.Id).HasMaxLength(50);
            builder.Property(x => x.Title).HasMaxLength(100);
            builder.HasKey(x => x.Id);
            //
            builder.HasMany(x => x.Vaccines);
            builder.Property(x => x.UpdatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
        }
    }
}