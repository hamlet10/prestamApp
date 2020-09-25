using AutoMapper;
using PrestamApp.Application.Interfaces.Mapping;
using PrestamApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamApp.Application.Contacts.Queries.GetContactDetail
{
    public class ContactDetailDto 
    {

        public int Id { get; set; }
        public string ContactNumber { get; set; }
        public string IdentificationNumber { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }

        public string Street { get; set; }

        public string PhoneNumberOne { get; set; }

        public string ProvinceName { get; set; }
        public string CityName { get; set; }

        public string SectorName { get; set; }

        public string Zone { get; set; }



    }
}
