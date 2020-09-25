using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrestamApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamApp.Persistence.Configurations
{
    class ZoneCollectorConfiguration : IEntityTypeConfiguration<ZoneCollector>
    {
        public void Configure(EntityTypeBuilder<ZoneCollector> builder)
        {
            //throw new NotImplementedException();
            builder.ToTable("ZoneCollectors");
            builder.HasKey(z => new { z.CollectorId, z.ZoneId});

            builder.HasOne(e => e.Zone)
                .WithMany(z => z.ZoneCollectors)
                .HasForeignKey(z => z.ZoneId);



            builder.HasOne(c => c.Collector)
                .WithMany(z => z.ZoneCollectors)
                .HasForeignKey(c => c.CollectorId)
                .OnDelete(DeleteBehavior.Cascade);





        }
    }
}
