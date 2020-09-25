using MediatR;
using PrestamApp.Domain.Entities;
using PrestamApp.Persistence;
using PrestamApp.Persistence.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrestamApp.Application.Collectors.Commands
{
    public class CreateCollectorCommandHandler : IRequestHandler<CreateCollectorCommand, Unit>
    {
        private readonly PrestamAppDbContext _context;


        public CreateCollectorCommandHandler(PrestamAppDbContext context)

        {
            _context = context;
        }
        public async Task<Unit> Handle(CreateCollectorCommand request, CancellationToken cancellationToken)
        {

            var entity = new Collector
            {
                UserId = request.UserId,
                Name = request.Name,
                Address = request.Address,
                PhoneNumberOne = request.PhoneNumberOne,
                PhoneNumberTwo = request.PhoneNumberTwo,
                Email = request.Email

            };
           
            entity.AddZones(request.Zones.ToArray());

            _context.Collectors.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;

        }
    }
}
