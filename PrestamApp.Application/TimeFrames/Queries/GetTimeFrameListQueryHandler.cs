using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PrestamApp.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrestamApp.Application.TimeFrames.Queries
{
    public class GetTimeFrameListQueryHandler : IRequestHandler<GetTimeFrameListQuery, IEnumerable<AddresTypeDto>>
    {
        private readonly PrestamAppDbContext _context;
        private readonly IMapper _mapper;

        public GetTimeFrameListQueryHandler(PrestamAppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public  async Task<IEnumerable<AddresTypeDto>> Handle(GetTimeFrameListQuery request, CancellationToken cancellationToken)
        {
            return await _context.TimeFrames.OrderBy(tf => tf.Id)
                .ProjectTo<AddresTypeDto>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
        }
    }
}
