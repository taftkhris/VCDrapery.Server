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
            //services.AddScoped<ISampleService, SampleService>();
            //services.AddScoped<ISampleRepository, SampleRepository>();

            // Automapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            // Provide your Database context configuration here
            //services.AddScoped<ISampleDatabaseContext, SampleDatabaseContext>();
            //services.AddDbContext<SampleDatabaseContext>(options => options.UseSqlServer(configuration.GetConnectionString("SampleDatabaseContext connection string")));
        }
    }
}
