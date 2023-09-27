using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace CustomerManagement.Data
{
    public static class AppConfig
    {
        public const string DbConnectionStringKey = "DatabaseConnection";
        public static readonly string DbConnectionStringEnvVarKey = $"ConnectionStrings__{DbConnectionStringKey}";
        public static string? EnvironmentName =>
            Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT") ??
            Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

        public static IConfiguration Configuration
        {
            get
            {
                var basePath = AppContext.BaseDirectory;
                // AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
                var builder = new ConfigurationBuilder()
                    .SetBasePath(basePath)
                    .AddJsonFile("appsettings.json")
                    .AddJsonFile($"appsettings.{EnvironmentName}.json", true)
                    .AddEnvironmentVariables();
                var configuration = builder.Build();
                return configuration;
            }
        }

        public static string? DbConnectionString =>
            Environment.GetEnvironmentVariable(DbConnectionStringEnvVarKey) ??
            Configuration.GetConnectionString(DbConnectionStringKey);

        public static string? MigrationsAssembly => typeof(AppConfig).GetTypeInfo().Assembly.GetName()?.Name;
    }
}
