using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PrestamApp.Application.AddressDatas.Queries;
using PrestamApp.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrestamApp.Application.AddressTypes.Queries
{
    public class GetAddressTypeListQueryHandler : IRequestHandler<GetAddressTypeListQuery, IEnumerable<AddressTypeDto>>
    {
        private readonly PrestamAppDbContext _context;
        private readonly IMapper _mapper;

        public GetAddressTypeListQueryHandler(PrestamAppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AddressTypeDto>> Handle(GetAddressTypeListQuery request, CancellationToken cancellationToken)
        {
            return await _context.GetAddressTypes.OrderBy(at => at.Id)
                .ProjectTo<AddressTypeDto>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
        }
    }
}
