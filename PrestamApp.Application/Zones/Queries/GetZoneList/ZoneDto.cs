using AutoMapper;
using PrestamApp.Application.Interfaces.Mapping;
using PrestamApp.Domain.Entities;

namespace PrestamApp.Application.Zones.Queries.GetZoneList
{
    public class ZoneDto : IHaveCustomMapping

    {
        public int Id { get; set; }
        public string Description { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Zone, ZoneDto>();
        }
    }
}