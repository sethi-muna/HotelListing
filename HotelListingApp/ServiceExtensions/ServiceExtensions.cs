using HotelListingApp.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListingApp.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddIdentity<ApiUser,IdentityRole>();
            builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole), services);//specify the user and the role.
            builder.AddEntityFrameworkStores<DataBaseContext>().AddDefaultTokenProviders();//where store the details.
        }

        public static void ConfigureJsonSerialization(this IServiceCollection services)
        {
            services.AddControllers().AddNewtonsoftJson(option =>
                    option.SerializerSettings.ReferenceLoopHandling =
                    Newtonsoft.Json.ReferenceLoopHandling.Ignore);
        }
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "HotelListingApp", Version = "v1" });
            });
        }
        
        public static void ConfigureDbContext(this IServiceCollection services,IConfiguration configuration)
        {

            services.AddDbContext<DataBaseContext>(options => options.UseSqlServer(configuration.GetConnectionString("sqlConnection")));
        }

        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(o =>
            {
                o.AddPolicy("CorsPolicy", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyHeader());
            });
        }
    }
}
