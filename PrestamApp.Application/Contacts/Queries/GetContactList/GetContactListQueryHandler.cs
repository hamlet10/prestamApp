using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using PrestamApp.Persistence;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PrestamApp.Application.Contacts.Queries.GetContactList
{
    public class GetContactListQueryHandler : IRequestHandler<GetContactListQuery, IEnumerable<ContactDto>>
    {
        private readonly PrestamAppDbContext _context;
        private readonly IMapper _mapper;

        public GetContactListQueryHandler(PrestamAppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ContactDto>> Handle(GetContactListQuery request, CancellationToken cancellationToken)
        {
            return await _context.Contacts.Include(c=> c.Zone).OrderByDescending(c=> c.Id).ProjectTo<ContactDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

        }
    }
}
