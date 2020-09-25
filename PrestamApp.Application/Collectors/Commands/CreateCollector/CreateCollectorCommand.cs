using MediatR;
using System.Collections.Generic;

namespace PrestamApp.Application.Collectors.Commands
{
  public class CreateCollectorCommand : IRequest
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumberOne { get; set; }
        public string PhoneNumberTwo { get; set; }
        public string Email { get; set; }
        public  List<int> Zones {get; set;}
    }
}
