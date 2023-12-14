using DAL.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.FluentAPI
{
    public class PasswordRecoveryTokenFluentAPI : IEntityTypeConfiguration<DtoPasswordRecoveryToken>
    {
        public void Configure(EntityTypeBuilder<DtoPasswordRecoveryToken> builder)
        {
            builder.ToTable("RecoveryToken");
            builder.Property(x => x.Id).HasMaxLength(50).HasDefaultValue(Guid.NewGuid().ToString().Substring(0, 10).Replace('-', '_').Replace('+', '_'));
            builder.HasKey(x => new { x.Id, x.UserId });
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
            builder.Property(x => x.UserId).HasMaxLength(50);
            builder.Property(x => x.PinCode).HasMaxLength(7);
            builder.Property(x => x.Expires);
            builder.HasOne(x => x.User).WithMany(x => x.PasswordRecoveryTokens).HasForeignKey(x => x.UserId).HasConstraintName("FK_Recovery_User");
            builder.Property(x => x.UpdatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
        }
    }
}