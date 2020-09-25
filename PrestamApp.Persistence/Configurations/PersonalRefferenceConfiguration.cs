using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrestamApp.Domain.Entities;

namespace PrestamApp.Persistence.Configurations
{
  class PersonalRefferenceConfiguration : IEntityTypeConfiguration<PersonalRefference>
    {
        public void Configure(EntityTypeBuilder<PersonalRefference> builder)
        {
            
           builder.ToTable("PersonalRefferences");
            builder.Property(p => p.Id).HasColumnName("PersonalRefferenceId");
            builder.Property(p => p.Name).HasMaxLength(150).IsRequired();
            builder.Property(p => p.PhoneNumberOne).HasMaxLength(13).IsRequired();

            builder.HasOne(p => p.RelationShipType)
                .WithMany(r => r.personalRefferences)
                .HasForeignKey(p => p.RelationShipTypeId);
                 builder.Property(r=> r.Address).HasMaxLength(256).IsRequired();
            builder.HasOne(p => p.Contact)
                .WithMany(r => r.PersonalRefferences)
                .HasForeignKey(p => p.ContactId);

        }
    }
}
