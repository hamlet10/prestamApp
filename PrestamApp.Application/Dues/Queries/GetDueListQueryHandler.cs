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

namespace PrestamApp.Application.Dues.Queries
{
    class GetDueListQueryHandler
    {
        public class GetLoanListQueryHandler : IRequestHandler<GetDueListQuery, IEnumerable<DuesDto>>
        {
            private readonly PrestamAppDbContext _context;
            private readonly IMapper _mapper;

            public GetLoanListQueryHandler(PrestamAppDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }
            public async Task<IEnumerable<DuesDto>> Handle(GetDueListQuery request, CancellationToken cancellationToken)
            {
                return await _context.Dues.Where(l => l.LoanID == request.LoanId).ProjectTo<DuesDto>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken);
            }
        }
    }
}
