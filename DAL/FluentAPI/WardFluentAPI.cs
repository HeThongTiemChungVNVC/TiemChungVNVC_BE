using DAL.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.FluentAPI
{
    public class WardFluentAPI : IEntityTypeConfiguration<DtoWard>
    {
        public void Configure(EntityTypeBuilder<DtoWard> builder)
        {
            builder.ToTable("Ward");
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
            builder.Property(x => x.Id).HasMaxLength(10);
            builder.Property(x => x.IdDistrict).HasMaxLength(10);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NameWard).HasMaxLength(100);
            // FK to table district
            builder.HasOne(x => x.District).
                WithMany(x => x.Wards).
                HasForeignKey(x => x.IdDistrict).
                HasConstraintName("FK_Ward_District");
            builder.Property(x => x.UpdatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
            // list stores
        }
    }
}