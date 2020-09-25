using MediatR;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamApp.Application.PersonalRefferences.Commands
{
    public class CreatePersonalRefferenceCommand : IRequest
    {
        public string Name { get; set; }
        public int ContactId { get; set; }
        public int RelationShipTypeId { get; set; }
        public string Address { get; set; }
        public Geometry Location { get; set; }
        public string PhoneNumberOne { get; set; }
        public string PhoneNumberTwo { get; set; }
    }
}
