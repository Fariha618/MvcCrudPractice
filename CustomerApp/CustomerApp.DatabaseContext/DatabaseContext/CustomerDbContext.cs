using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerApp.Models.Models;

namespace CustomerApp.DatabaseContext.DatabaseContext
{
    public class CustomerDbContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}
