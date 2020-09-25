using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PrestamApp.Auth.Data
{
    public class AuthDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("Security");

            builder.Entity<ApplicationUser>(u =>
            {
                u.Property(s=> s.FirstName).IsRequired().HasMaxLength(128);
                u.Property(s=> s.LastName).IsRequired().HasMaxLength(128);
                u.Property(s=> s.Code).HasMaxLength(16);
                u.Property(s=> s.CreatedBy).HasMaxLength(16);
                u.Property(s=> s.UpdatedBy).HasMaxLength(16);
                u.Property(s=> s.CreatedAt).HasDefaultValueSql("GETDATE()");
            });

            builder.Entity<ApplicationRole>(r =>
            {
                r.Property(s=> s.Description).HasMaxLength(128);
            });
        }
    }
}
