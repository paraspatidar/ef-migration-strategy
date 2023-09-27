
using Microsoft.EntityFrameworkCore;
using CustomerManagement.Data.DBEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Data.Contexts
{
    public class CustomerManagementDbContext : DbContext
    {
        public CustomerManagementDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<CustomerDetail> CustomerDetail { get; set; }
    }
}
