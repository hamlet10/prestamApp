using System;
using AutoMapper;
using PrestamApp.Persistence;
using Xunit;

namespace PrestamApp.Application.Tests.Infrastructure
{
    public class QueryTestFixture : IDisposable
    {
        public  PrestamAppDbContext Context { get; private set; }
        public  IMapper Mapper { get; private set; }

        public QueryTestFixture()
        {
            Context = PrestamAppContextFactory.Create();
            Mapper = AutoMapperFactory.Create();
        }
        public void Dispose()
        {
            PrestamAppContextFactory.Destroy(Context);
        }

      [CollectionDefinition("QueryCollection")]
      public class QueryCollection: ICollectionFixture<QueryTestFixture>
      {
          
      }
    }
}