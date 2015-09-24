using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AOACollections.Models
{
    public class AOADBContext  : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Order> Orders { get; set; }

        public AOADBContext()
        {
            Database.SetInitializer<AOADBContext>(null);
        }

        public System.Data.Entity.DbSet<AOACollections.Models.Delivery> Deliveries { get; set; }
    }
}
