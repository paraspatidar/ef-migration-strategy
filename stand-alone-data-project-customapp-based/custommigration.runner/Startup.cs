using CustomerManagement.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custommigration.runner
{
    public class Startup : IHostedService
    {
        public CustomerManagementDbContext CustomerManagementDbContext { get; }
        public Startup(CustomerManagementDbContext customerManagementDbContext)
        {
            CustomerManagementDbContext = customerManagementDbContext;
        }

        

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Staring migration runner!");
            try
            {
                await CustomerManagementDbContext.Database.MigrateAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"migration runner error:{ex.Message} | {ex.StackTrace} | {ex}");
            }

            Console.WriteLine("Done migration runner!");
            Console.ReadLine();
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Stopping app!");
        }
    }
}
