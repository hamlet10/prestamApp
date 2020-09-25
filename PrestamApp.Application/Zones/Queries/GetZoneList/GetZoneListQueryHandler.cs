using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PrestamApp.Persistence;

namespace PrestamApp.Application.Zones.Queries.GetZoneList
{
    public class GetZoneListQueryHandler: IRequestHandler<GetZoneListQuery, IEnumerable<ZoneDto>>
    {
        private readonly PrestamAppDbContext _context;
        private readonly IMapper _mapper;

        public GetZoneListQueryHandler(PrestamAppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ZoneDto>> Handle(GetZoneListQuery request, CancellationToken cancellationToken)
        {
            return await _context.Zones.OrderBy(z => z.Description)
                .ProjectTo<ZoneDto>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
        }
    }
}