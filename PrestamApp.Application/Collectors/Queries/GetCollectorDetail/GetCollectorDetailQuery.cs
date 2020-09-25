using MediatR;

namespace PrestamApp.Application.Collectors.Queries.GetCollectorDetail
{
    public class GetCollectorDetailQuery : IRequest<CollectorDetailDto>

    {
        public int Id { get; set; }
    }
}
