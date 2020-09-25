using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrestamApp.Domain.Entities;

namespace PrestamApp.Persistence.Configurations
{
  class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            //throw new NotImplementedException();
            builder.ToTable("Address");
            builder.Property(e => e.Id).HasColumnName("AddressId");
           
            builder.Property(e => e.Street).HasMaxLength(40);
            builder.Property(e => e.Refference).HasMaxLength(30);
            builder.Property(e => e.AddressTypeId).IsRequired();

            builder.HasOne(e => e.AddressType)
                .WithMany(a => a.Addresses)
                .HasForeignKey(e => e.AddressTypeId);

            builder.HasOne(e => e.AddressData)
                .WithMany(a => a.Address)
                .HasForeignKey(e => e.AddressDataId);
        }
    }
}
