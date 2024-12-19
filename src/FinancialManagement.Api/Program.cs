using FinancialManagement.Api.Configurations;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace FinancialManagement.Api
    {
    public class Program
        {
        public static void Main(string[] args)
            {
            // Criar e rodar a aplicação Web
            CreateHostBuilder(args).Build().Run();
            }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        }
    }
