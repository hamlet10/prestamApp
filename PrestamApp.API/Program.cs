using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PrestamApp.Persistence;

namespace PrestamApp.API
{
  public class Program
    {
        public static void Main(string[] args)
        {
             var host= CreateWebHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope() )
            {
                try
                {
                    var context = scope.ServiceProvider.GetService<PrestamAppDbContext>();
                    context.Database.Migrate();
                 
                }
                catch (System.Exception ex)
                {
                    var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while migrating or initializing the database.");
                    
                }
            }

            host.Run();
        }

         public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                   .ConfigureLogging((hostingContext, logging) => {
                    logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                    logging.AddConsole();
                    logging.AddDebug();
                })
                .UseStartup<Startup>();
    }
}
