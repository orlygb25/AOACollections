using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace AOACollections.Models
{
    public class AOAInitializer : DropCreateDatabaseAlways<AOADBContext>
    {
        protected override void Seed(AOADBContext context)
        {

        }
    }

    public class AOADBContext  : DbContext
    {
        static AOADBContext()
        {
            Database.SetInitializer<AOADBContext>(new AOAInitializer());
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

             modelBuilder.Entity<Delivery>().HasMany(e => e.Orders).WithOptional(a => a.Delivery).HasForeignKey(e => e.ID);
    
        }

        public AOADBContext()
        {
            Database.SetInitializer<AOADBContext>(null);
        }

        public System.Data.Entity.DbSet<AOACollections.Models.Delivery> Deliveries { get; set; }
    }
}
