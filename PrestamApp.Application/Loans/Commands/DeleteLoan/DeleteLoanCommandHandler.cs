using MediatR;
using PrestamApp.Application.Exceptions;
using PrestamApp.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrestamApp.Application.Loans.Commands.DeleteLoan
{
    public class DeleteLoanCommandHandler : IRequestHandler<DeleteLoanCommand>
    {
        private readonly PrestamAppDbContext _context;

        public DeleteLoanCommandHandler(PrestamAppDbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(DeleteLoanCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Loans.FindAsync(request.Id);
            if(entity == null)
            {
                throw new NotFoundException(nameof(Loans), request.Id);
            }

            _context.Loans.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
