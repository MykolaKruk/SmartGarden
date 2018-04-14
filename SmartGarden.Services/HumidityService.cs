using AutoMapper;
using SmartGarden.Core.Data;
using SmartGarden.Core.Entities;
using SmartGarden.Core.Services;
using SmartGarden.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGarden.Services
{
    public class HumidityService : BaseService<Humidity, IHumidityRepository>, IHumidityService
    {
        public HumidityService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        protected override IHumidityRepository InitRepository()
        {
            return UnitOfWork.HumidityRepository;
        }
        public bool UpperMinnimumPercentageHumidity(Humidity humidity)
        {
            var dbSet = Repository.GetOne(humidity.Id);
            if (humidity.MinnimumPercentageHumidity >= dbSet.MinnimumPercentageHumidity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Humidity GetByFlower(int flowerId)
        {
            var humidity = Repository.GetFlower(flowerId);
            return humidity;
        }
    }
}
