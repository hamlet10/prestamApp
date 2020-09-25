using MediatR;
using PrestamApp.Application.Exceptions;
using PrestamApp.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrestamApp.Application.Collectors.Commands.DeleteCollector
{
    public class DeleteCollectorCommandHandler : IRequestHandler<DeleteCollectorCommand>
    {
        private readonly PrestamAppDbContext _context;
        public DeleteCollectorCommandHandler(PrestamAppDbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(DeleteCollectorCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Collectors.FindAsync(request.Id);
            if (entity == null)
            {
                throw new NotFoundException(nameof(Collectors), request.Id);
            }
            _context.Collectors.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
