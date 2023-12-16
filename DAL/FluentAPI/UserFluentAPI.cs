using DAL.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.FluentAPI
{
	public class UserFluentAPI : IEntityTypeConfiguration<DtoUser>
	{
		public void Configure(EntityTypeBuilder<DtoUser> builder)
		{
			builder.ToTable("User");
			builder.Property(x => x.IsDeleted).HasDefaultValue(false);
			builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
			builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
			builder.Property(x => x.Id).HasMaxLength(50);
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Username).HasMaxLength(100);
			builder.Property(x => x.Role).HasMaxLength(10).HasDefaultValue("doctor");
			builder.Property(x => x.PasswordHash);
			// list cart by user
			builder.HasOne(x => x.Employee).WithOne(x => x.User).HasForeignKey<DtoEmployee>(x => x.UserId);
			builder.HasMany(x => x.RefeshTokens);
			builder.Property(x => x.UpdatedTime).HasDefaultValue(DateTime.Now);
			builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
		}
	}
}