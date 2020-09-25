using MediatR;
using PrestamApp.Domain.Entities;
using PrestamApp.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrestamApp.Application.Loans.Commands.CreateLoan
{
    class CreateLoanCommandHandler : IRequestHandler<CreateLoanCommand, Unit>
    {
        private readonly PrestamAppDbContext _context;


        public CreateLoanCommandHandler(PrestamAppDbContext context)


        {
            _context = context;
        }
        public async Task<Unit> Handle(CreateLoanCommand request, CancellationToken cancellationToken)
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
