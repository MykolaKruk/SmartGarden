using AutoMapper;
using SmartGarden.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGarden.Core
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Flower, FlowerDto>();
            CreateMap<FlowerDto, Flower>();

            CreateMap<Humidity, HumidityDto>();
            CreateMap<HumidityDto, Humidity>();
        }

    }
}
