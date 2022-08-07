using Carental.BusinessLogic.Services;
using Carental.BusinessLogic.Services.Interfaces;
using Carental.DataAccess;
using Carental.DataAccess.Entities;
using Carental.DataAccess.Repositories;
using Carental.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Carental.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var configuration = builder.Configuration;

            // Add services to the container.


            builder.Services.AddDbContext<CarentalContext>(opt =>
                opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            builder.Services.AddScoped<IRepositoryBase<Renter>, RenterRepository>();
            //builder.Services.AddScoped<IRepositoryBase<Renter>, RepositoryBase<Renter>>();
            builder.Services.AddScoped<IRenterService, RenterService>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}