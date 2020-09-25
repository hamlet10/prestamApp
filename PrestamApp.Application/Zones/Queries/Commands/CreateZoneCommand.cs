using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamApp.Application.Zones.Queries.Commands
{
   public class CreateZoneCommand : IRequest
    {
        //public int Id { get; set; }
        public string Description { get; set; }
    }
}
