using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrestamApp.Domain.Entities;

namespace PrestamApp.Persistence.Configurations
{
    public class CollectorConfiguration: IEntityTypeConfiguration<Collector>
    {
        public void Configure(EntityTypeBuilder<Collector> builder)
        {
            builder.ToTable("Collectors");
            builder.Property(p => p.Id).HasColumnName("CollectorID");
            builder.Property(p => p.UserId).HasColumnName("UserID").IsRequired();
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Address).HasMaxLength(70).IsRequired();
            builder.Property(p => p.PhoneNumberOne).HasColumnName("PhoneNumber1").IsRequired();
            builder.Property(p => p.PhoneNumberTwo).HasColumnName("PhoneNumber2");
            builder.Property(p => p.Email).HasMaxLength(255).IsRequired();
        }
    }
}
