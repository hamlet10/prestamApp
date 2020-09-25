using System.Collections.Generic;
using MediatR;

namespace PrestamApp.Application.Zones.Queries.GetZoneList
{
    public class GetZoneListQuery: IRequest<IEnumerable<ZoneDto>>
    {
        
    }
}