using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CustomerManagement.Data.Contexts;
using Microsoft.Extensions.Logging;
using CustomerManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using custommigration.runner;

namespace Conga.Platform.LocalOnboarding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CreateHostBuilder(args).Build().Run();
            Console.WriteLine("Hello World!");
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
           new HostBuilder()
           .ConfigureAppConfiguration((hostingContext, config) =>
           {
               config.AddJsonFile("appsettings.json", true, true)
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddEnvironmentVariables();
           })
          .ConfigureServices((hostContext, services) =>
          {
              services.AddSingleton<IConfiguration>(sp =>
              {
                  return hostContext.Configuration;
              });

              services.AddSingleton<IConfiguration>(hostContext.Configuration);
              services.AddDbContext<CustomerManagementDbContext>((x => x.UseNpgsql(AppConfig.DbConnectionString)
              .LogTo(Console.WriteLine, LogLevel.Information)
              .EnableSensitiveDataLogging()
              .EnableDetailedErrors()));

              services.AddHostedService<Startup>();
          });
    }
}