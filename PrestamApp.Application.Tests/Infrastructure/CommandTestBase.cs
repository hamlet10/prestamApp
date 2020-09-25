using System;
using PrestamApp.Persistence;

namespace PrestamApp.Application.Tests.Infrastructure
{
    public class CommandTestBase : IDisposable
    {
        protected readonly PrestamAppDbContext Context;

        public CommandTestBase()
        {
            Context = PrestamAppContextFactory.Create();
        }
        public void Dispose()
        {
            PrestamAppContextFactory.Destroy(Context);
        }
    }
}