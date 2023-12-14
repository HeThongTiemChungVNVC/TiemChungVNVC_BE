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
    public class VacineFluentAPI : IEntityTypeConfiguration<DtoVaccine>
    {
        public void Configure(EntityTypeBuilder<DtoVaccine> builder)
        {
            builder.ToTable("Vaccine");
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
            builder.Property(x => x.CategoryVaccineId).HasMaxLength(50);
            builder.Property(x => x.Id).HasMaxLength(50);
            builder.HasKey(x => x.Id);
            //
            builder.Property(x => x.Prevention);
            builder.Property(x => x.NameVaccine);
            builder.Property(x => x.InjectionSite);
            builder.Property(x => x.Image);
            builder.Property(x => x.Condition);
            builder.HasMany(x => x.VaccineBatches);
            builder.HasOne(x => x.CategoryVaccine).WithMany(c => c.Vaccines).HasForeignKey(x => x.CategoryVaccineId).HasConstraintName("Fk_Category_Vaccine").OnDelete(DeleteBehavior.Cascade); ;
            //
            builder.HasOne(x => x.InjectionChart).WithOne(x => x.Vaccine).HasForeignKey<DtoInjectionChart>(x => x.IdVaccine);
            builder.Property(x => x.UpdatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
        }
    }
}