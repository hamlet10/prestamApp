using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrestamApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamApp.Persistence.Configurations
{
    class DuePaymentConfiguration : IEntityTypeConfiguration<DuePayment>
    {
        public void Configure(EntityTypeBuilder<DuePayment> builder)
        {
            builder.ToTable("DuesPayments");
            builder.HasKey(d => new { d.DueID, d.PaymentID});

            builder.HasOne(d => d.Due)
                .WithMany(dp => dp.DuesPayments)
                .HasForeignKey(dp => dp.DueID);

            builder.HasOne(p => p.Payment)
                .WithMany(dp => dp.DuesPayments)
                .HasForeignKey(dp => dp.PaymentID);

        }
    }
}
