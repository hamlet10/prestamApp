using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrestamApp.Domain.Entities;

namespace PrestamApp.Persistence.Configurations
{
    public class ZoneConfiguration : IEntityTypeConfiguration<Zone>
    {
        public void Configure(EntityTypeBuilder<Zone> builder)
        {
            builder.ToTable("Zones");

            builder.Property(e=> e.Id)
                   .HasColumnName("ZoneID");

            builder.Property(e=> e.Description)
                  .IsRequired()
                  .HasMaxLength(50);
        }
    }
}
