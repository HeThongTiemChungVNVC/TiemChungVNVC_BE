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
    public class EmployeeFluentAPI : IEntityTypeConfiguration<DtoEmployee>
    {
        public void Configure(EntityTypeBuilder<DtoEmployee> builder)
        {
            builder.ToTable("Employee");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
            builder.Property(x => x.Id).HasMaxLength(50);
            builder.Property(x => x.IdCategoryPosition).HasMaxLength(50);
            builder.HasKey(x => new { x.Id });
            //
            builder.Property(x => x.FullName).HasMaxLength(100);
            builder.Property(x => x.CodeEmployee).HasMaxLength(100);
            builder.Property(x => x.Phone).HasMaxLength(11);
            builder.Property(x => x.Email).HasMaxLength(50);
            builder.Property(x => x.Address).HasMaxLength(50);
            builder.Property(x => x.Gender).HasMaxLength(10);
            builder.Property(x => x.DateOfBirth).HasDefaultValue(DateTime.Now);
            //
            builder.HasOne(x => x.CategoryPosition).WithMany(c => c.Employees).HasForeignKey(x => x.IdCategoryPosition).HasConstraintName("fk_employee_position").OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.VaccinationCenter).WithMany(c => c.Employees).HasForeignKey(x => x.IdVaccinationCenter).HasConstraintName("fk_employee_center").OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(x => x.VaccinationRegistrations);
        }
    }
}