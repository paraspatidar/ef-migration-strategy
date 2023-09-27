using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Data.Contexts
{
    internal class CustomerManagementDesignTimeDbContextFactory : IDesignTimeDbContextFactory<CustomerManagementDbContext>
    {
        public CustomerManagementDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CustomerManagementDbContext>();
            if (AppConfig.DbConnectionString == null)
                throw new ArgumentNullException(nameof(AppConfig.DbConnectionString));
            optionsBuilder.UseNpgsql(AppConfig.DbConnectionString);
            return new CustomerManagementDbContext(optionsBuilder.Options);

            
        }
    }
}
