using AutoMapper;
using PrestamApp.Application.Interfaces.Mapping;
using PrestamApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamApp.Application.ZonesCollectors.Queries
{
    public class ZoneCollectorsDto  : IHaveCustomMapping
    {
        public int ZoneId { get; set; }
        public int CollectorId { get; set; }
        public string  ZoneName { get; set; }

        public string CollectorName { get; set; }


        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<ZoneCollector, ZoneCollectorsDto>()
                .ForMember(dt => dt.ZoneName, opt => opt.MapFrom(z => z.Zone.Description))
                .ForMember(dt => dt.CollectorName, opt => opt.MapFrom(c => c.Collector.Name));

            
        }
    }
}
