using MediatR;
using PrestamApp.Domain.Entities;
using PrestamApp.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrestamApp.Application.PersonalRefferences.Commands
{
    public class CreatePersonalRefferenceCommandHandler : IRequestHandler<CreatePersonalRefferenceCommand, Unit>
    {
        private readonly PrestamAppDbContext _context;
        public CreatePersonalRefferenceCommandHandler(PrestamAppDbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(CreatePersonalRefferenceCommand request, CancellationToken cancellationToken)
        {
            var entity = new PersonalRefference
            {
                Name = request.Name,
                ContactId = request.ContactId,
                RelationShipTypeId = request.RelationShipTypeId,
                Address = request.Address,
                PhoneNumberOne = request.PhoneNumberOne
            };

            _context.personalRefferences.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
