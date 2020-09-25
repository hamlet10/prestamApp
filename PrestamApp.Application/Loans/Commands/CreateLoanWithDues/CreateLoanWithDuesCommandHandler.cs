using MediatR;
using Microsoft.EntityFrameworkCore;
using PrestamApp.Domain.Entities;
using PrestamApp.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrestamApp.Application.Loans.Commands.CreateLoanWithDues
{
    public class CreateLoanWithDuesCommandHandler : IRequestHandler<CreateLoanWithDuesCommand, Unit>
    {
        private readonly PrestamAppDbContext _context;
        public CreateLoanWithDuesCommandHandler(PrestamAppDbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(CreateLoanWithDuesCommand request, CancellationToken cancellationToken)
        {

            var entity = new Loan
            {
                ContactId = request.ContactId,
                UrlFile = request.UrlFile,
                TimeFrameId = request.TimeFrameId,
                LoanAmount = request.LoanAmount,
                SimpleInterest = request.SimpleInterest,
                InterestRate = request.InterestRate,
                Interest = request.Interest,
                LoanDate = request.LoanDate,
                EndDate = request.EndDate,
                NumberOfDue = request.NumberOfDue,
                TotalBalance = request.TotalBalance,
                IsActive = request.IsActive,
                UpToDate = request.UpToDate,
                Code = "L-000",
                TotalCapitalAmount = request.TotalCapitalAmount
            };

            decimal capitalAmount = request.LoanAmount / request.NumberOfDue;
            decimal interest = request.Interest / request.NumberOfDue;

            var timeFrame = await _context.TimeFrames.SingleAsync(tf => tf.Id == request.TimeFrameId);

            for (int i = 1; i <= request.NumberOfDue; i++)
            {
                DateTime date = request.LoanDate.AddDays(timeFrame.CountDay * i);
                entity.Dues.Add(new Due
                {
                    CapitalAmount = capitalAmount,
                    InterestAmount = interest,
                    PaymentAmount = capitalAmount + interest,
                    LateFee = 0,
                    PendingBalance = 0,
                    DueNumber = i,
                    Date = date,
                    DueIsPaidOff = false
                });
            }

            _context.Loans.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            entity.Code = SetCode(entity.Id);
            _context.Update(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }

        private string SetCode(int id)
        {
            string code = "L-000";
            string stringId = id.ToString();
            if (stringId.Length <= 3)
            {
                code = code.Remove(5 - stringId.Length);
            }
            else
            {

                code = code.Remove(2);

            }
            return code + stringId;
        }
    }
}
