using Microsoft.EntityFrameworkCore;
using PrestamApp.Persistence.Infrastructure;

namespace PrestamApp.Persistence
{
  public class PrestamAppDbContextFactory : DesignTimeDbContextFactoryBase<PrestamAppDbContext>
    {
       protected override PrestamAppDbContext CreateNewInstance(DbContextOptions<PrestamAppDbContext> options)
        {
            return new PrestamAppDbContext(options);
        }
    }
}
