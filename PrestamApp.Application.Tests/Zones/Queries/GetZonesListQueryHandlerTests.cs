using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using PrestamApp.Application.Tests.Infrastructure;
using PrestamApp.Application.Zones.Queries.GetZoneList;
using PrestamApp.Persistence;
using Shouldly;
using  Xunit;
namespace PrestamApp.Application.Tests.Zones.Queries
{
    [Collection("QueryCollection")]
    public class GetZonesListQueryHandlerTests
    {
        private readonly PrestamAppDbContext _context;
        private readonly IMapper _mapper;

        public GetZonesListQueryHandlerTests(QueryTestFixture fixture)
        {
            _context = fixture.Context;
            _mapper = fixture.Mapper;
            
        }

        [Fact]
        public async Task GetZonesTest()
        {
            var sut = new GetZoneListQueryHandler(_context,_mapper);

            var result = await sut.Handle(new GetZoneListQuery(), CancellationToken.None);
            
            result.ShouldBeOfType<List<ZoneDto>>();

            result.Count().ShouldBe(3);
         
        }
    }
}