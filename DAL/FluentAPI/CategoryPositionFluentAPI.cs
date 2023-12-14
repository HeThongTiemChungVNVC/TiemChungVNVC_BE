using DAL.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.FluentAPI
{
    public class CategoryPositionFluentAPI : IEntityTypeConfiguration<DtoCategoryPosition>
    {
        public void Configure(EntityTypeBuilder<DtoCategoryPosition> builder)
        {
            builder.ToTable("CategoryPosition");
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
            builder.Property(x => x.UpdatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
            builder.Property(x => x.Id).HasMaxLength(50);
            builder.Property(x => x.Title).HasMaxLength(100);
            builder.HasKey(x => x.Id);
            //
            builder.HasMany(x => x.Employees);
        }
    }
}