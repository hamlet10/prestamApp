using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PrestamApp.Persistence;

namespace PrestamApp.Application.Loans.Queries.GetLoanList
{
    public class GetLoanListQueryHandler: IRequestHandler<GetLoanListQuery,IEnumerable<LoanListDto>>
    {
        private readonly PrestamAppDbContext _context;
        private readonly IMapper _mapper;

        public GetLoanListQueryHandler(PrestamAppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IEnumerable<LoanListDto>> Handle(GetLoanListQuery request, CancellationToken cancellationToken)
        {
            return await _context.Loans.Include(c=> c.Contact).ProjectTo<LoanListDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
    }
}