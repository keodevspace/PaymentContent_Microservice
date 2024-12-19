using Microsoft.Extensions.DependencyInjection;

namespace FinancialManagement.Api.Configurations
    {
    public static class CorsConfiguration
        {
        public static void AddCorsConfiguration(this IServiceCollection services)
            {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", policy =>
                {
                    policy.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                });
            });
            }
        }
    }
