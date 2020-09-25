using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamApp.Application.Contacts.Commands.DeleteContact
{
    public class DeleteContactCommand : IRequest
    {
        public int Id { get; set; }
    }
}
