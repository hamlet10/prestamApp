using System.Collections.Generic;
using MediatR;

namespace PrestamApp.Application.Collectors.Queries.GetCollectorList
{
    public class GetCollectorListQuery : IRequest<IEnumerable<CollectorDto>>
    {
        
    }
}