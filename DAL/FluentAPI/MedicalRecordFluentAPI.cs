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
    public class MedicalRecordFluentAPI : IEntityTypeConfiguration<DtoMedicalRecord>
    {
        public void Configure(EntityTypeBuilder<DtoMedicalRecord> builder)
        {
            builder.ToTable("MedicalRecord");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
            builder.Property(x => x.Id).HasMaxLength(50);
            builder.Property(x => x.IdCustomer).HasMaxLength(50);
            builder.HasKey(x => new { x.Id });
            builder.HasMany(x => x.DetailMedicalRecords);
            builder.Property(x => x.UpdatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
            builder.HasOne(x => x.Customer).WithMany(c => c.MedicalRecords).HasForeignKey(x => x.IdCustomer).HasConstraintName("FK_Medicals_Customer").OnDelete(DeleteBehavior.NoAction);
        }
    }
}