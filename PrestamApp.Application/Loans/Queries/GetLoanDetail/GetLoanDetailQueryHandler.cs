using MediatR;
using Microsoft.EntityFrameworkCore;
using PrestamApp.Application.Exceptions;
using PrestamApp.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrestamApp.Application.Loans.Queries.GetLoanDetail
{
    public class GetLoanDetailQueryHandler : IRequestHandler<GetLoanDetailQuery, LoanDetailDto>
    {
        private readonly PrestamAppDbContext _context;

        public GetLoanDetailQueryHandler(PrestamAppDbContext context)
        {
            _context = context;

        }
        public async Task<LoanDetailDto> Handle(GetLoanDetailQuery request, CancellationToken cancellationToken)
        {
            var entity = await _context.Loans.Include(c => c.Contact)
                .Include(t => t.TimeFrame).SingleAsync(l => l.Id == request.LoanId, cancellationToken);



            if (entity == null)
            {
                throw new NotFoundException(nameof(Loans), request.LoanId);
            }

            return new LoanDetailDto
            {
                Id = entity.Id,
                Code = entity.Code,
                ContactId = entity.ContactId,
                UrlFile = entity.UrlFile,
                TimeFrameId = entity.TimeFrameId,
                LoanAmount = entity.LoanAmount,
                TotalCapitalAmount = entity.TotalCapitalAmount,
                SimpleInterest = entity.SimpleInterest,
                InterestRate = entity.InterestRate,
                Interest = entity.Interest,
                LoanDate = entity.LoanDate,
                EndDate = entity.EndDate,
                NumberOfDue = entity.NumberOfDue,
                NumberOfDuesPaid = entity.NumberOfDuesPaid,
                TotalBalance = entity.TotalBalance,
                IsActive = entity.IsActive,
                UpToDate = entity.UpToDate,
                TimeFrameDescription = entity.TimeFrame.Description

            };
        }
    }
}
