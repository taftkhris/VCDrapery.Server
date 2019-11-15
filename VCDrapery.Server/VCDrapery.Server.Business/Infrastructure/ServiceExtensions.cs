using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

using AutoMapper;
using VCDrapery.Server.Data;


namespace VCDrapery.Server.Business
{
    public static class ServiceExtensions
    {
        public static void ConfigureAppServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Provide your services and repositories IOC configuration here
            services.AddScoped<IDraperyService, DraperyService>();
            services.AddScoped<IDraperyRepository, DraperyRepository>();

            // Automapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            // Provide your Database context configuration here
            services.AddScoped<IDatabaseContext, DraperyContext>();
            services.AddDbContext<DraperyContext>(options => options.UseSqlServer(configuration.GetConnectionString("LocalDB")));
        }
    }
}
