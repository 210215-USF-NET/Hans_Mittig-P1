using Microsoft.EntityFrameworkCore;
using StoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDL
{
    public class StoreDBContext : DbContext
    {
        public StoreDBContext(DbContextOptions options) : base(options)
        {
        }

        protected StoreDBContext()
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Location> Locations {get;set;}
        //public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().Property(customer => customer.id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Manager>().Property(manager => manager.id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Location>().Property(location => location.id).ValueGeneratedOnAdd();
            //modelBuilder.Entity<Inventory>().Property(inventory => inventory.id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Product>().Property(product => product.id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Orders>().Property(order => order.id).ValueGeneratedOnAdd();
            modelBuilder.Entity<OrderItems>().Property(orderitem => orderitem.id).ValueGeneratedOnAdd();
        }
    }
}
