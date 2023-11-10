using FashionTrend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionTrend.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Service> Services { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Supplier>().Ignore(supplier => supplier.Materials);
            modelBuilder.Entity<Supplier>().Ignore(supplier => supplier.SewingMachines);
            modelBuilder.Entity<Service>().Ignore(service => service.Materials);
            modelBuilder.Entity<Service>().Ignore(service => service.SewingMachines);
            modelBuilder.Entity<Service>().Ignore(service => service.Type);
        }
    }
}
