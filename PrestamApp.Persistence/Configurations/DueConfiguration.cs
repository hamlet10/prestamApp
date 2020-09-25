using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrestamApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamApp.Persistence.Configurations
{
    class DueConfiguration : IEntityTypeConfiguration<Due>
    {
        public void Configure(EntityTypeBuilder<Due> builder)
        {
            builder.ToTable("Dues");
            
        }
    }
}
