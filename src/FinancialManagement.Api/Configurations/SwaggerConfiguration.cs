using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace FinancialManagement.Api.Configurations
    {
    public static class SwaggerConfiguration
        {
        public static void AddSwaggerConfiguration(this IServiceCollection services)
            {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "FinancialManagement API", Version = "v1" });
            });
            }
        }
    }
