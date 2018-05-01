using AutoMapper;
using SmartGarden.Core.Dto;
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

            CreateMap<FlowerType, FlowerTypeDto>();
            CreateMap<FlowerTypeDto, FlowerType>();

            CreateMap<MeasureUnit, MeasureUnitDto>();
            CreateMap<MeasureUnitDto, MeasureUnit>();

            CreateMap<WateringSettings, WateringSettingsDto>();
            CreateMap<WateringSettingsDto, WateringSettings>();
        }

    }
}
