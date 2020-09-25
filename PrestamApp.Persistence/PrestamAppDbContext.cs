using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrestamApp.Domain.Entities;
using PrestamApp.Persistence.Extensions;

namespace PrestamApp.Persistence
{
  public class PrestamAppDbContext : DbContext
  {
    public PrestamAppDbContext(DbContextOptions<PrestamAppDbContext> options) : base(options)
    { }

    public DbSet<PersonalRefference> personalRefferences { get; set; }
    public DbSet<RelationShipType> RelationShipTypes { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<ZoneCollector> ZoneCollectors { get; set; }
    public DbSet<AddressData> AddressData { get; set; }
    public DbSet<AddressType> GetAddressTypes { get; set; }
    public DbSet<Zone> Zones { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Loan> Loans { get; set; }
    public DbSet<Collector> Collectors { get; set; }
    public DbSet<Due> Dues { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<DuePayment> DuesPayments { get; set; }
    public DbSet<TimeFrame> TimeFrames { get; set; }

  


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      // Create shadow properties
      foreach (var entityType in modelBuilder.Model.GetEntityTypes()
          .Where(e => typeof(IAuditable).IsAssignableFrom(e.ClrType)))
      {
        modelBuilder.Entity(entityType.ClrType)
            .Property<DateTime?>("CreatedDate");

        modelBuilder.Entity(entityType.ClrType)
            .Property<DateTime?>("ModifiedDate");

        modelBuilder.Entity(entityType.ClrType)
            .Property<string>("CreatedBy").HasMaxLength(50);

        modelBuilder.Entity(entityType.ClrType)
            .Property<string>("ModifiedBy").HasMaxLength(50);
      }

      modelBuilder.ApplyConfigurationsFromAssembly(typeof(PrestamAppDbContext).Assembly);

      //modelBuilder.Seed();

    }

    private void ApplyAuditInformation()
    {
      var modifiedEntities = ChangeTracker.Entries<IAuditable>()
          .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);
      foreach (var entity in modifiedEntities)
      {
        if (entity.State == EntityState.Added)
        {
          entity.Property("CreatedDate").CurrentValue = DateTime.Now;
          entity.Property("CreatedBy").CurrentValue = "SYSTEM";
        }
        else
        {
          entity.Property("ModifiedDate").CurrentValue = DateTime.Now;
          entity.Property("ModifiedBy").CurrentValue = "Carlos";
        }
      }
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
      ApplyAuditInformation();
      return base.SaveChangesAsync(cancellationToken);
    }

  }

}

