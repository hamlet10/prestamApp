using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using PrestamApp.Domain.Entities;
using PrestamApp.Persistence;

namespace PrestamApp.Application.Contacts.Commands.CreateContact
{
    public class CreateContactCommandHandler : IRequestHandler<CreateContactCommand, Unit>
    {
        private readonly PrestamAppDbContext _context;


        public CreateContactCommandHandler(PrestamAppDbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(CreateContactCommand request, CancellationToken cancellationToken)
        {

            var entity = new Contact
            {
                //ContactNumber = request.ContactNumber,
                ContactNumber =  "C-000",
                IdentificationNumber = request.IdentificationNumber,
                Name = request.Name,
                LastName = request.LastName,
                Email = request.Email,
                Gender = request.Gender,
                PhoneNumberOne = request.PhoneNumberOne,
                PhoneNumberTwo = request.PhoneNumberTwo,
                ZoneId = request.ZoneId
            };

            entity.Address = new Address
            {
                AddressDataId = request.AddressDataId,
                Refference = request.Address,
                Street = request.Street,
                AddressTypeId = request.AddressTypeId
            };

            _context.Contacts.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            entity.ContactNumber = SetCode(entity.Id);
            _context.Update(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;


        }

        private string SetCode(int id)
        {
            string code = "C-000";
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