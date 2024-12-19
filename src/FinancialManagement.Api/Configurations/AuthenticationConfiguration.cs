namespace FinancialManagement.Api.Configurations
    {
    public static class AuthenticationConfiguration
        {
        public static void AddAuthenticationConfiguration(this IServiceCollection services)
            {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    // Configurações de JWT
                    options.TokenValidationParameters = new TokenValidationParameters
                        {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = "http://localhost:5000",
                        ValidAudience = "http://localhost:5000",
                        IssuerSigningKey = JwtSecurityKey.Create("SecurityKey-12345678")
                        };
                });
            }
        }
    }
