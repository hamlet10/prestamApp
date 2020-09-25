using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrestamApp.Domain.Entities;

namespace PrestamApp.Persistence.Configurations
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {

            builder.ToTable("Contacts");

            builder.Property(e => e.Id).HasColumnName("ContactId");

            builder.Property(e => e.ContactNumber).HasMaxLength(10).HasDefaultValue("C-000");

            builder.Property(e => e.IdentificationNumber)
                   .HasMaxLength(13);
            builder.Property(e => e.UrlFile).HasMaxLength(50);

            builder.Property(e => e.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(e => e.LastName)
                   .IsRequired()
                   .HasMaxLength(50);
           
            builder.Property(e => e.Email)
                   .HasMaxLength(50);

            builder.Property(e => e.Gender)
                   .IsRequired();

         
            builder.Property(e => e.PhoneNumberOne)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(e => e.PhoneNumberTwo)
                   .HasMaxLength(50);

            builder.Property(e => e.ZoneId)
                   .IsRequired();

            builder.HasOne(e => e.Zone)
                  .WithMany(z => z.Contacts)
                  .HasForeignKey(e => e.ZoneId);

      builder.HasOne(e => e.Address)
          .WithMany(a => a.Contacts)
          .HasForeignKey(e => e.AddressId);

      builder.HasMany(c=> c.PersonalRefferences).WithOne(pr=> pr.Contact).HasForeignKey(pr=> pr.ContactId);

    }
    }
}
