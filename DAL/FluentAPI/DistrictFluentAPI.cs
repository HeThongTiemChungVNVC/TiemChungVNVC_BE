using DAL.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.FluentAPI
{
    public class DistrictFluentAPI : IEntityTypeConfiguration<DtoDistrict>
    {
        public void Configure(EntityTypeBuilder<DtoDistrict> builder)
        {
            builder.ToTable("District");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
            builder.Property(x => x.Id).HasMaxLength(10);
            builder.Property(x => x.IdCity).HasMaxLength(10);

            builder.Property(x => x.NameDistrict).HasMaxLength(100);
            // FK to table city
            builder.HasOne(x => x.City).
                WithMany(x => x.Districts).
                HasForeignKey(x => x.IdCity).
                HasConstraintName("FK_District_City");

            builder.HasMany(x => x.Wards);
            builder.Property(x => x.UpdatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
        }
    }
}