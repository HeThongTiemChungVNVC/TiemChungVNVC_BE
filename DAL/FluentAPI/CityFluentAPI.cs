using DAL.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.FluentAPI
{
    public class CityFluentAPI : IEntityTypeConfiguration<DtoCity>
    {
        public void Configure(EntityTypeBuilder<DtoCity> builder)
        {
            builder.ToTable("City");
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
            builder.Property(x => x.Id).HasMaxLength(10);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NameCity).HasMaxLength(100);
            // list district
            builder.HasMany(x => x.Districts);
            builder.Property(x => x.UpdatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
        }
    }
}