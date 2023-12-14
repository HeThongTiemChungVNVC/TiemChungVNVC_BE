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
    public class DetailMedicalRecord : IEntityTypeConfiguration<DtoDetailMedicalRecord>
    {
        public void Configure(EntityTypeBuilder<DtoDetailMedicalRecord> builder)
        {
            builder.ToTable("DetailMedicalRecord");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
            builder.Property(x => x.Id).HasMaxLength(50);
            builder.Property(x => x.BodyTemperature);
            builder.Property(x => x.BackgroundIllness);
            builder.Property(x => x.IdMedicalRecord).HasMaxLength(50);
            builder.HasKey(x => new { x.Id, x.IdMedicalRecord });
            //fk to table medial record
            builder.HasOne(x => x.MedicalRecord)
               .WithMany(x => x.DetailMedicalRecords)
               .HasForeignKey(x => x.IdMedicalRecord)
               .HasConstraintName("FK_details_record");
            builder.Property(x => x.UpdatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
        }
    }
}