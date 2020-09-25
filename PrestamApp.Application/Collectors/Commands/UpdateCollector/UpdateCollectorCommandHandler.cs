using MediatR;
using Microsoft.EntityFrameworkCore;
using PrestamApp.Application.Exceptions;
using PrestamApp.Persistence;
using PrestamApp.Persistence.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrestamApp.Application.Collectors.Commands.UpdateCollector
{
    class UpdateCollectorCommandHandler : IRequestHandler<UpdateCollectorCommand, Unit>
    {
        private readonly PrestamAppDbContext _context;

        public UpdateCollectorCommandHandler(PrestamAppDbContext context)

        {
            _context = context;
        }
        public async Task<Unit> Handle(UpdateCollectorCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Collectors.Include(z => z.ZoneCollectors).SingleAsync(c => c.Id == request.Id, cancellationToken);
            if (entity == null)
            {
                throw new NotFoundException(nameof(Collectors), request.Id);
            }

            entity.Name = request.Name;
            entity.Address = request.Address;
            entity.PhoneNumberOne = request.PhoneNumberOne;
            entity.PhoneNumberTwo = request.PhoneNumberTwo;
            entity.Email = request.Email;

            entity.UpdateZones(request.Zones.ToArray());
            _context.Update(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;


        }
    }
}
