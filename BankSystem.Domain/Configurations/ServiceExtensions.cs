using BankSystem.DataAccess.Data;
using BankSystem.DataAccess.DbAccess;
using BankSystem.DataAccess.Repositories.Contracts;
using BankSystem.Domain.Services;
using BankSystem.Domain.Services.Contracts;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;


namespace BankSystem.Domain.Configurations;
public static class ServiceExtension
{
    public static void Configure(WebApplicationBuilder builder)
    {
        builder.Services.AddSingleton<ISqlDataAccess, SqlDataAccess>();

        builder.Services.AddSingleton<IOperatorRepository, OperatorRepository>();
        builder.Services.AddSingleton<IAccountRepository, AccountRepository>();

        builder.Services.AddSingleton<IOperatorService, OperatorService>();
        builder.Services.AddSingleton<IAccountService, AccountService>();

        builder.Services.AddSingleton<TokenGenerator>();

        var issuer = builder.Configuration["Jwt:Issuer"]!;
        var audience = builder.Configuration["Jwt:Audience"]!;
        var key = builder.Configuration["Jwt:Key"]!;

        builder.Services.Configure<JwtSettings>(s =>
        {
            s.Issuer = issuer;
            s.Audience = audience;
            s.SecrectKey = key;
        });

        builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = issuer,
                ValidAudience = audience,
                ClockSkew = TimeSpan.Zero,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key))
            });

        builder.Services.AddAuthorization(options =>
        {
            options.AddPolicy("User",
                policy => policy.RequireClaim(ClaimTypes.Role, "User"));

            options.AddPolicy("Operator",
                policy => policy.RequireClaim(ClaimTypes.Role, "Operator"));
        });
    }
}
