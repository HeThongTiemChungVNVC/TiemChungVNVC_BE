using DAL.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.FluentAPI
{
	public class InformationFluentAPI : IEntityTypeConfiguration<DtoInformation>
	{
		public void Configure(EntityTypeBuilder<DtoInformation> builder)
		{
			builder.ToTable("Information");
			builder.Property(x => x.IsDeleted).HasDefaultValue(false);
			builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
			builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
			builder.Property(x => x.Id).HasMaxLength(50);
			builder.Property(x => x.Dob).HasMaxLength(15).HasDefaultValue(DateTime.Now);
			builder.Property(x => x.Gender).HasMaxLength(15).IsRequired(false);

			builder.HasKey(x => x.Id);
			builder.Property(x => x.FullName).HasMaxLength(255);
			builder.Property(x => x.Email).HasMaxLength(255);
			builder.Property(x => x.Phone).HasMaxLength(15).IsRequired(false);
			builder.Property(x => x.UpdatedTime).HasDefaultValue(DateTime.Now);
			builder.Property(x => x.CreatedBy).HasDefaultValue("admin");
		}
	}
}