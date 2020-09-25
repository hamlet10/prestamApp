using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamApp.Application.ZonesCollectors.Queries
{
    public class GetZoneCollectorsListQuery : IRequest<IEnumerable<ZoneCollectorsDto>>

    {
    }
}
