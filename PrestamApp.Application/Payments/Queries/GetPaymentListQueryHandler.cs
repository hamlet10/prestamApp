using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using PrestamApp.Persistence;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PrestamApp.Application.Payments.Queries
{
    class GetPaymentListQueryHandler
    {
        public class GetLoanListQueryHandler : IRequestHandler<GetPaymentListQuery, IEnumerable<PaymentDto>>
        {
            private readonly PrestamAppDbContext _context;
            private readonly IMapper _mapper;

            public GetLoanListQueryHandler(PrestamAppDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }
            public async Task<IEnumerable<PaymentDto>> Handle(GetPaymentListQuery request, CancellationToken cancellationToken)
            {
              

                return await _context.DuesPayments
                    .Include(p => p.Payment)
                    .Include(d => d.Due).Where(d => d.Due.LoanID == request.LoanId)
                    .Select(p=> p.Payment)
                    .ProjectTo<PaymentDto>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken);

                //Where(l => l.PaymentID == request.).ProjectTo<PaymentDto>(_mapper.ConfigurationProvider)
                //.ToListAsync(cancellationToken);
            }
        }
    }
}
