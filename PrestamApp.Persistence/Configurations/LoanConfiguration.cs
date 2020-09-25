using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrestamApp.Domain.Entities;

namespace PrestamApp.Persistence.Configurations
{
    public class LoanConfiguration : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder.ToTable("Loans");
            builder.Property(l => l.Id).HasColumnName("LoanID");
            builder.Property(l => l.ContactId).HasColumnName("ContactID").IsRequired();
            builder.Property(l => l.UrlFile).HasMaxLength(50);
            builder.Property(l => l.TimeFrameId).HasColumnName("TimeFrameID").IsRequired();
            //builder.Property(l => l.StatusId).HasColumnName("LoanStatusID").IsRequired();
            builder.Property(l => l.LoanAmount).IsRequired();
            builder.Property(l => l.SimpleInterest).IsRequired();
            builder.Property(l => l.InterestRate).IsRequired();
            builder.Property(l => l.Interest).IsRequired();
            builder.Property(l => l.LoanDate).IsRequired();
            builder.Property(l => l.EndDate).IsRequired();
            builder.Property(l => l.TotalBalance).IsRequired();
            builder.Property(l => l.IsActive).IsRequired();
            builder.Property(l => l.Code).HasMaxLength(10).IsRequired();
            builder.Property(l => l.NumberOfDuesPaid).HasColumnName("NumeroCuotasPagadas");
            builder.HasOne(l => l.Contact)
                .WithMany(c => c.Loans)
                .HasForeignKey(l => l.ContactId);

            builder.HasOne(l => l.TimeFrame)
                .WithMany(t => t.Loan)
                .HasForeignKey(l => l.TimeFrameId);


        }
    }
}