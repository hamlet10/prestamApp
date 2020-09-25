using Microsoft.EntityFrameworkCore;
using PrestamApp.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PrestamApp.Persistence.Configurations
{
  class AddressDataConfiguration : IEntityTypeConfiguration<AddressData>
    {

        public void Configure(EntityTypeBuilder<AddressData> builder)
        {
            builder.ToTable("AddressData");
            builder.Property(a => a.Id).HasColumnName("AddressDataID");
            builder.Property(a => a.Description).HasMaxLength(100);

            builder.HasMany(ad => ad.Childs)
                .WithOne(ad => ad.Parent)
                .HasForeignKey(ad => ad.ParentId);

        }
    }
}
