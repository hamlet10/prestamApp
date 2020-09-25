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

namespace PrestamApp.Application.Collectors.Queries.GetCollectorDetail
{
    public class GetCollectorDetailQueryHandler : IRequestHandler<GetCollectorDetailQuery, CollectorDetailDto>
    {
        private readonly PrestamAppDbContext _context;
       
        public GetCollectorDetailQueryHandler(PrestamAppDbContext context)

        {
            _context = context;
        
        }
        public async Task<CollectorDetailDto> Handle(GetCollectorDetailQuery request, CancellationToken cancellationToken)
        {
            var entity = await _context.Collectors.SingleAsync(c => c.Id == request.Id, cancellationToken);
                

            if(entity == null)
            {
                throw new NotFoundException(nameof(Collector), request.Id);
            }

            return new CollectorDetailDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Address = entity.Address,
                PhoneNumberOne = entity.PhoneNumberOne,
                PhoneNumberTwo = entity.PhoneNumberTwo,
                Email = entity.Email,

            };
        }
    }
}
