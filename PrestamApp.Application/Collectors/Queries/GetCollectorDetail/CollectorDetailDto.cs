using AutoMapper;
using PrestamApp.Application.Interfaces.Mapping;
using PrestamApp.Domain.Entities;

namespace PrestamApp.Application.Collectors.Queries.GetCollectorDetail

{
    public class CollectorDetailDto : IHaveCustomMapping

    {

        public int Id { get; set; }
        //public int UserId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumberOne { get; set; }
        public string PhoneNumberTwo { get; set; }
        public string Email { get; set; }
        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Collector, CollectorDetailDto>();
        }
    }
}