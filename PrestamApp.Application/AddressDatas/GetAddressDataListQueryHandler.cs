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

namespace PrestamApp.Application.AddressDatas
{
    public class GetAddressDataListQueryHandler : IRequestHandler<GetAddressDataListQuery, IEnumerable<AddressDataDto>>
    {
        private readonly PrestamAppDbContext _context;
        private readonly IMapper _mapper;

        public GetAddressDataListQueryHandler(PrestamAppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IEnumerable<AddressDataDto>> Handle(GetAddressDataListQuery request, CancellationToken cancellationToken)
        {
            return await _context.AddressData.Where(ad => ad.ParentId == request.ParentId)
                
                .ProjectTo<AddressDataDto>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
        }
    }
}
