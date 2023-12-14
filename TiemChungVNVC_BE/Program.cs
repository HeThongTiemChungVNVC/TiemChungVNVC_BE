using BLL.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NLog;
using NLog.Web;
using Repository.DbContexts;
using Repository.Repository;
using Swashbuckle.AspNetCore.SwaggerGen;
using TiemChungVNVC_BE.Configurations;

namespace TiemChungVNVC_BE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var logger = LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
            try
            {
                var builder = WebApplication.CreateBuilder(args);
                builder.Logging.ClearProviders();
                builder.Host.UseNLog();

                // Add services to the container.

                builder.Services.AddControllers();
                builder.Services.AddControllersWithViews(options =>
                {
                    options.AllowEmptyInputInBodyModelBinding = true;
                }).AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                }
                );
                // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
                builder.Services.AddHttpContextAccessor();
                builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
                builder.Services.AddSwaggerGen();
                builder.Services.AddDbContext<VNVCContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("VNVC")));
                builder.Services.AddEndpointsApiExplorer();
                builder.Services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
                builder.Services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigurationSwagger>();
                builder.Services.AddAuthenticationJWT(builder.Configuration);
                builder.Services.AddAutoMapper(typeof(ConfigureAutoMapper));
                builder.Services.AddServiceDI();

                builder.Services.AddCors(op => op.AddPolicy(name: "CommonPolicy", policy =>
                {
                    policy.WithOrigins("*").AllowAnyHeader().AllowAnyMethod();
                }));
                var app = builder.Build();

                // Configure the HTTP request pipeline.
                if (app.Environment.IsDevelopment())
                {
                    app.UseSwagger();
                    app.UseSwaggerUI();
                }
                else
                {
                    app.UseSwagger();
                    app.UseSwaggerUI();
                }
                app.UseHttpsRedirection();
                app.UseCors("CommonPolicy");
                app.UseAuthentication();
                app.UseAuthorization();

                app.MapGet("/", () => Results.Redirect("/swagger/index.html", true, true)).ExcludeFromDescription(); // ExcludeFromDescription to hidden api route
                app.MapControllers();

                app.Run();
            }
            catch (Exception ec)
            {
                logger.Error(ec.Message);
            }
        }
    }
}