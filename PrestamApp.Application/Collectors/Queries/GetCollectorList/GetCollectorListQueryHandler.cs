using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PrestamApp.Persistence;

namespace PrestamApp.Application.Collectors.Queries.GetCollectorList
{
    public class GetCollectorListQueryHandler: IRequestHandler<GetCollectorListQuery,IEnumerable<CollectorDto>>
    {
        private readonly PrestamAppDbContext _context;
        private readonly IMapper _mapper;

        public GetCollectorListQueryHandler(PrestamAppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IEnumerable<CollectorDto>> Handle(GetCollectorListQuery request, CancellationToken cancellationToken)
        {
            return await _context.Collectors.OrderBy(c => c.Id)
                .ProjectTo<CollectorDto>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
        }
    }
}