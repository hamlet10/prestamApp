using System;
using Microsoft.EntityFrameworkCore;
using PrestamApp.Domain.Entities;
using PrestamApp.Persistence;

namespace PrestamApp.Application.Tests.Infrastructure
{
    public class PrestamAppContextFactory
    {
        public static PrestamAppDbContext Create()
        {
            var options = new DbContextOptionsBuilder<PrestamAppDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var context = new PrestamAppDbContext(options);
            context.Database.EnsureCreated();

            context.Zones.AddRange(
                new Zone { Id = 1, Description = "Test" },
                             new Zone { Id = 2, Description = "Ninja" },
                             new Zone { Id = 3, Description = "Shinobi" });

            context.SaveChanges();
            return context;
        }

        public static void Destroy(PrestamAppDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Dispose();
        }
    }
}