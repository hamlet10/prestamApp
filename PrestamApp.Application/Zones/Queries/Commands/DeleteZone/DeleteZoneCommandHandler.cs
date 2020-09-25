using MediatR;
using PrestamApp.Application.Exceptions;
using PrestamApp.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrestamApp.Application.Zones.Queries.Commands.DeleteZone
{
    public class DeleteZoneCommandHandler : IRequestHandler<DeleteZoneCommand>
    {
        private readonly PrestamAppDbContext _context;
        public DeleteZoneCommandHandler(PrestamAppDbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(DeleteZoneCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Zones.FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Zones), request.Id);
            }

            _context.Zones.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
              
        }
    }
}
