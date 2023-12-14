using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace TiemChungVNVC_BE.Configurations
{
	public static class ConfigurationJWT
	{
		public static IServiceCollection AddAuthenticationJWT(this IServiceCollection services, ConfigurationManager configuration)
		{
			services.AddAuthentication(option =>
			{
				option.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
				option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
				option.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
			}).AddJwtBearer(option =>
			{
				option.RequireHttpsMetadata = false;
				option.SaveToken = true;
				option.TokenValidationParameters = new TokenValidationParameters()
				{
					ValidateAudience = false,
					ValidateIssuer = false,
					IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"])),
					ValidateIssuerSigningKey = true,
					ClockSkew = TimeSpan.Zero
				};
			}).AddCookie();

			return services;
		}
	}
}