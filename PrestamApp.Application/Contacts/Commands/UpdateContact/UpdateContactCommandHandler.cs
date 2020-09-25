using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PrestamApp.Application.Exceptions;
using PrestamApp.Domain.Entities;
using PrestamApp.Persistence;

namespace PrestamApp.Application.Contacts.Commands.UpdateContact
{
    public class UpdateContactCommandHandler: IRequestHandler<UpdateContactCommand,Unit>
    {
        private readonly PrestamAppDbContext _context;

        public UpdateContactCommandHandler(PrestamAppDbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(UpdateContactCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Contacts.Include(c=> c.Address).SingleAsync(c => c.Id == request.Id, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Contact), request.Id);
            }
            entity.IdentificationNumber = request.IdentificationNumber;
            entity.UrlFile = request.UrlFile;
            entity.Name = request.Name;
            entity.LastName = request.LastName;
            entity.Gender = request.Gender;
            entity.Email = request.Email;
            entity.PhoneNumberOne = request.PhoneNumberOne;
            entity.PhoneNumberTwo = request.PhoneNumberTwo;
            entity.ZoneId = request.ZoneId;
            entity.Address.AddressDataId = request.AddressDataId;
            entity.Address.AddressTypeId = request.AddressTypeId;
            entity.Address.Refference = request.AddressReference;
            _context.Update(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return  Unit.Value;
        }
    }
}