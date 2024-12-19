using FinancialManagement.Api.Configurations;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FinancialManagement.Api
    {
    public class Startup
        {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
            {
            _configuration = configuration;
            }

        public void ConfigureServices(IServiceCollection services)
            {
            // Adicionar configuração do banco de dados (Oracle)
            services.AddDatabaseConfiguration(_configuration);

            // Adicionar serviços de aplicação
            services.AddApplicationServices();

            // Configurar autenticação (se necessário)
            services.AddAuthenticationConfiguration();

            // Configurar CORS
            services.AddCorsConfiguration();

            // Adicionar Swagger
            services.AddSwaggerConfiguration();

            // Adicionar Controllers
            services.AddControllers();
            }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            {
            if (env.IsDevelopment())
                {
                // Ativar Swagger no ambiente de desenvolvimento
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "FinancialManagement API v1"));
                }

            // Configurar CORS
            app.UseCors("AllowAll");

            // Ativar autenticação
            app.UseAuthentication();

            // Ativar autorização
            app.UseAuthorization();

            // Configurar os middlewares da aplicação
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            }
        }
    }
