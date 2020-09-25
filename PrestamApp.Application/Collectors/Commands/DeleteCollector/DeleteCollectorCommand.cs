using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamApp.Application.Collectors.Commands.DeleteCollector

{
    public class DeleteCollectorCommand : IRequest

    {
        public int Id { get; set; }

    }
}
