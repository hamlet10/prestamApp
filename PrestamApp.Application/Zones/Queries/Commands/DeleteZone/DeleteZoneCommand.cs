using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamApp.Application.Zones.Queries.Commands.DeleteZone
{
    public class DeleteZoneCommand : IRequest
    {
        public int Id { get; set; }
    }
}
