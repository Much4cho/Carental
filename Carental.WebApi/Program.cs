using Carental.BusinessLogic;
using Carental.DataAccess;
using Carental.WebApi.App_Start;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Text;

namespace Carental.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var configuration = builder.Configuration;


            builder.Services.ConfigureCors();

            //builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //    .AddEntityFrameworkStores<CarentalContext>();

            //builder.Services.AddIdentityServer()
            //    .AddApiAuthorization<ApplicationUser, CarentalContext>();

            //builder.Services.AddAuthentication()
            //    .AddIdentityServerJwt();

            builder.Services.AddDbContext<CarentalContext>(opt =>
                opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
            //builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

            builder.Services.ConfigureRepositories();
            builder.Services.ConfigureBussinessServices();
 
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                //options.DocumentFilter<RemoveSchemasFilter>();
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(options =>
                {
                    options.DefaultModelsExpandDepth(-1);
                });
            }

            //var OAuthOptions = new OAuthAuthorizationServerOptions
            //{
            //    TokenEndpointPath = new PathString("/Token"),
            //    Provider = new ApplicationOAuthProvider(PublicClientId),
            //    AuthorizeEndpointPath = new PathString("/api/Account/ExternalLogin"),
            //    AccessTokenExpireTimeSpan = TimeSpan.FromDays(14),
            //    // Note: Remove the following line before you deploy to production:
            //    AllowInsecureHttp = true
            //};

            //// Enable the application to use bearer tokens to authenticate users
            //app.UseOAuthBearerTokens(OAuthOptions);

            app.UseHttpsRedirection();

            app.UseCors(); ;

            //app.UseAuthentication();
            //app.UseIdentityServer();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}