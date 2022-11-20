using Carental.DataAccess.Repositories.Interfaces;
using Carental.DataAccess.Repositories;
using Carental.BusinessLogic.Services.Interfaces;
using Carental.BusinessLogic.Services;

namespace Carental.WebApi.App_Start
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(policy =>
                {
                    policy
                        .AllowCredentials()
                        .WithOrigins("http://127.0.0.1:5173")
                        //.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                });
            });
        }

        public static void ConfigureAuthorization(this IServiceCollection services)
        {
        }

        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IRentalRepository, RentalRepository>();
            services.AddScoped<IRenterRepository, RenterRepository>();
        }

        public static void ConfigureBussinessServices(this IServiceCollection services)
        {
            services.AddScoped<ICarService, CarService>();
            services.AddScoped<IRentalService, RentalService>();
            services.AddScoped<IRenterService, RenterService>();
        }
    }
}
