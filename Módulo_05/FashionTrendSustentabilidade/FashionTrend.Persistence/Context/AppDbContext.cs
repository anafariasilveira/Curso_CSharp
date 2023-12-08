using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Service>()
           .Property(e => e.RequestType)
           .HasConversion(
               v => v.ToString(),
               v => (ERequestType)Enum.Parse(typeof(ERequestType), v));

        modelBuilder.Entity<Service>()
           .Property(e => e.Materials)
           .HasConversion(
               v => string.Join(",", v.Select(s => s.ToString())),
               v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                     .Select(s => (EMaterial)Enum.Parse(typeof(EMaterial), s))
                     .ToList());

        modelBuilder.Entity<Service>()
           .Property(e => e.SewingMachines)
           .HasConversion(
               v => string.Join(",", v.Select(s => s.ToString())),
               v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                     .Select(s => (ESewingMachine)Enum.Parse(typeof(ESewingMachine), s))
                     .ToList());

        modelBuilder.Entity<Supplier>()
            .Property(e => e.Materials)
            .HasConversion(
                v => string.Join(",", v.Select(s => s.ToString())),
                v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                      .Select(s => (EMaterial)Enum.Parse(typeof(EMaterial), s))
                      .ToList());

        modelBuilder.Entity<Supplier>()
           .Property(e => e.SewingMachines)
           .HasConversion(
               v => string.Join(",", v.Select(s => s.ToString())),
               v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                     .Select(s => (ESewingMachine)Enum.Parse(typeof(ESewingMachine), s))
                     .ToList());



        base.OnModelCreating(modelBuilder);
    }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<ServiceOrder> ServicesOrder { get; set; }
    public DbSet<Contract> Contracts { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<DraftContract> DraftContracts { get; set; }
}