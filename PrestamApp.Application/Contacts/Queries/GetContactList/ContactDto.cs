using AutoMapper;
using PrestamApp.Application.Interfaces.Mapping;
using PrestamApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamApp.Application.Contacts.Queries.GetContactList
{
   public class ContactDto : IHaveCustomMapping
    {
        public int Id { get; set; }
        public string ContactNumber { get; set; }
        public string IdentificationNumber { get; set; }
       
        public string Name { get; set; }
        public string LastName { get; set; }
        
        public string PhoneNumberOne { get; set; }
       
        public string ZoneName { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Contact, ContactDto>()
                .ForMember(dto => dto.ZoneName, opts => opts.MapFrom(c => c.Zone.Description));
        }
    }
}
