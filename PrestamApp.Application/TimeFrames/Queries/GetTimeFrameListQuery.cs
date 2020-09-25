using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamApp.Application.TimeFrames.Queries
{
    public class GetTimeFrameListQuery : IRequest<IEnumerable<AddresTypeDto>>
    {
    }
}
