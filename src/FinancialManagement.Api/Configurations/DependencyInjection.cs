using Microsoft.Extensions.DependencyInjection;
using FinancialManagement.Api.Services;

namespace FinancialManagement.Api.Configurations
    {
    public static class DependencyInjection
        {
        public static void AddApplicationServices(this IServiceCollection services)
            {
            // Registrar os serviços
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ITransactionService, TransactionService>();
            }
        }
    }
