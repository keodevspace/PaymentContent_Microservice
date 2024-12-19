using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FinancialManagement.Api.Models;

namespace FinancialManagement.Api.Configurations
    {
    public static class DbContextConfiguration
        {
        public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
            {
            IServiceCollection dbContextServiceCollection = services.AddDbContext<FinancialManagementContext>(options =>
                options.UseOracle(configuration.GetConnectionString("DefaultConnection")));
            }
        }
    }
