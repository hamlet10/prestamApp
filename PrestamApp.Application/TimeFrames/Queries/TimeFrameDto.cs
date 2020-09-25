using AutoMapper;
using PrestamApp.Application.Interfaces.Mapping;
using PrestamApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamApp.Application.TimeFrames.Queries
{
   public class AddresTypeDto : IHaveCustomMapping
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int CountDay { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<TimeFrame, AddresTypeDto>();
        }
    }
}
