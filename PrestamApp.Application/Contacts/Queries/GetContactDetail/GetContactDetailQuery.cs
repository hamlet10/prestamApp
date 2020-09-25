using MediatR;

namespace PrestamApp.Application.Contacts.Queries.GetContactDetail
{
    public class GetContactDetailQuery : IRequest<ContactDetailDto>
    {
        public int Id { get; set; }
    }
}
