using MediatR;
using PrestamApp.Application.Exceptions;
using PrestamApp.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrestamApp.Application.Contacts.Commands.DeleteContact
{
    public class DeleteContactCommandHandler : IRequestHandler<DeleteContactCommand>
    {
        private readonly PrestamAppDbContext _context;

        public DeleteContactCommandHandler(PrestamAppDbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(DeleteContactCommand request, CancellationToken cancellationToken)
        {
           var entity =  await _context.Contacts.FindAsync(request.Id);
            if(entity == null)
            {
                throw new NotFoundException(nameof(Contacts), request.Id);
            }

            _context.Contacts.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;

        }
    }
}
