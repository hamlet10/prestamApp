using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrestamApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamApp.Persistence.Configurations
{
    class AddressTypeConfiguration : IEntityTypeConfiguration<AddressType>
    {
        public void Configure(EntityTypeBuilder<AddressType> builder)
        {
            //throw new NotImplementedException();
            builder.ToTable("AddressTypes");
            builder.Property(a => a.Id).HasColumnName("AddressTypeID");
            builder.Property(a => a.Description).HasMaxLength(10);
        }
    }
}
