using DAL.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.FluentAPI
{
    public class RefeshTokenFluentAPI : IEntityTypeConfiguration<DtoRefeshToken>
    {
        public void Configure(EntityTypeBuilder<DtoRefeshToken> builder)
        {
            builder.ToTable("RefeshToken");
            builder.Property(x => x.Id).HasMaxLength(50).HasDefaultValue(Guid.NewGuid().ToString().Substring(0, 10).Replace('-', '_').Replace('+', '_'));
            builder.HasKey(x => new { x.Id, x.RefeshToken, x.UserId });
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
            builder.Property(x => x.RefeshToken);
            builder.Property(x => x.UserId).HasMaxLength(50);
            builder.Property(x => x.Expires);
            builder.HasOne(x => x.User).WithMany(x => x.RefeshTokens).HasForeignKey(x => x.UserId).HasConstraintName("FK_RefeshToken_User").OnDelete(DeleteBehavior.Cascade);
            builder.Property(x => x.UpdatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
        }
    }
}