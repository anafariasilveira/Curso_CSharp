using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Supplier>().Ignore(supplier => supplier.Materials);
        modelBuilder.Entity<Supplier>().Ignore(supplier => supplier.SewingMachines);
        modelBuilder.Entity<Service>().Ignore(service => service.Materials);
        modelBuilder.Entity<Service>().Ignore(service => service.SewingMachines);
        modelBuilder.Entity<Service>().Ignore(service => service.Type);
    }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<ServiceOrder> ServicesOrder { get; set; }
    public DbSet<ServiceContract> ServiceContract { get; set; }
}