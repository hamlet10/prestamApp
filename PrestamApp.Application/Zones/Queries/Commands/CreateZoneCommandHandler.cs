using MediatR;
using PrestamApp.Domain.Entities;
using PrestamApp.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrestamApp.Application.Zones.Queries.Commands
{
    public class CreateContactCommandHandler : IRequestHandler<CreateZoneCommand, Unit>
    {
        private readonly PrestamAppDbContext _context;


        public CreateContactCommandHandler(PrestamAppDbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(CreateZoneCommand request, CancellationToken cancellationToken)
        {

            var entity = new Zone
            {
                
                Description = request.Description

            };

            _context.Zones.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;

        }
    }
}
