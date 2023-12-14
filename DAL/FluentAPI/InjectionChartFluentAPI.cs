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
    public class InjectionChartFluentAPI : IEntityTypeConfiguration<DtoInjectionChart>
    {
        public void Configure(EntityTypeBuilder<DtoInjectionChart> builder)
        {
            builder.ToTable("InjectionChart");
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
            builder.Property(x => x.Id).HasMaxLength(50);
            builder.Property(x => x.IdVaccine).HasMaxLength(50);
            //
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Doses);
            builder.Property(x => x.Interval);
            builder.Property(x => x.Reminder).HasDefaultValue(false);
            builder.Property(x => x.UpdatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
        }
    }
}