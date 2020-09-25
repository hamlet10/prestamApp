using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PrestamApp.Application.Exceptions;
using PrestamApp.Domain.Entities;
using PrestamApp.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrestamApp.Application.Contacts.Queries.GetContactDetail
{
    public class GetContactDetailQueryHandler : IRequestHandler<GetContactDetailQuery, ContactDetailDto>
    {
        private readonly PrestamAppDbContext _context;
       
        public GetContactDetailQueryHandler(PrestamAppDbContext context)
        {
            _context = context;
        
        }
        public async Task<ContactDetailDto> Handle(GetContactDetailQuery request, CancellationToken cancellationToken)
        {
            var entity = await _context.Contacts
                .Include(a => a.Zone)
                .Include(c => c.Address)
                .ThenInclude(a => a.AddressData)
                .ThenInclude(a=> a.Parent)
                .ThenInclude(a=> a.Parent)
                .SingleAsync(c => c.Id == request.Id, cancellationToken);
                

            if(entity == null)
            {
                throw new NotFoundException(nameof(Contact), request.Id);
            }

            return new ContactDetailDto
            {
                Id = entity.Id,
                ContactNumber = entity.ContactNumber,
                IdentificationNumber = entity.IdentificationNumber,
                Name = entity.Name,
                LastName = entity.LastName,
                PhoneNumberOne = entity.PhoneNumberOne,
                SectorName = entity.Address.AddressData.Description,
                CityName = entity.Address.AddressData.Parent.Description,
                ProvinceName = entity.Address.AddressData.Parent.Parent.Description,
                Street = entity.Address.Street,
                Zone = entity.Zone.Description
                
            };
        }
    }
}
