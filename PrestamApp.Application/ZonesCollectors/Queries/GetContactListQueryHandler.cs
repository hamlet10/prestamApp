using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using PrestamApp.Persistence;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrestamApp.Application.Contacts.Queries.GetContactList;

namespace PrestamApp.Application.ZonesCollectors.Queries
{
    public class GetContactListQueryHandler : IRequestHandler<GetZoneCollectorsListQuery, IEnumerable<ZoneCollectorsDto>>
    {
        private readonly PrestamAppDbContext _context;
        private readonly IMapper _mapper;

        public GetContactListQueryHandler(PrestamAppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ZoneCollectorsDto>> Handle(GetZoneCollectorsListQuery request, CancellationToken cancellationToken)
        {
            return await _context.ZoneCollectors.Include(z => z.Zone)
                .Include(z => z.Collector)
                .ProjectTo<ZoneCollectorsDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

        }
    }
}
