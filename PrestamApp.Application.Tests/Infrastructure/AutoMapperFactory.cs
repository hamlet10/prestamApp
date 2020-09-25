using AutoMapper;
using PrestamApp.Application.Infrastructure.AutoMapper;

namespace PrestamApp.Application.Tests.Infrastructure
{
    public static class AutoMapperFactory
    {
        public static IMapper Create()
        {
            // Auto Mapper Configurations
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });
            return mappingConfig.CreateMapper();
        }
    }
}