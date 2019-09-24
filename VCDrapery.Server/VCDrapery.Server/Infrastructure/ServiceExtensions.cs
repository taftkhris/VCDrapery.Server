using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace VCDrapery.Server
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services, string policyName, IConfiguration configuration)
        {
            string value = configuration["allowedOrigins"];
            string[] allowedOrigins = value.Split(';', StringSplitOptions.RemoveEmptyEntries);

            services.AddCors(options => options.AddPolicy(policyName, p => p.WithOrigins(allowedOrigins).AllowCredentials()));
        }
    }
}
