using System.Collections.Generic;
using MediatR;
namespace PrestamApp.Application.Contacts.Queries.GetContactList
{
    public class GetContactListQuery : IRequest<IEnumerable<ContactDto>>
    {
        public int? CollectorId { get; set; }
    }
}

