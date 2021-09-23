using System;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class HomeDeliveryContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("--");
        }

       public DbSet<Delivery> Deliveries { get; set; }
       public DbSet<Order> Orders { get; set; }
       public DbSet<Recipient> Recipients { get; set; }
       public DbSet<AccessWindow> AccessWindows { get; set; }
        
    }
}
