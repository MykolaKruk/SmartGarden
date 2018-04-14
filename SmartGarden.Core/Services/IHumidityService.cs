using SmartGarden.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGarden.Core.Services
{
    public interface IHumidityService : IService<Humidity>
    {
        bool UpperMinnimumPercentageHumidity(Humidity humidity);
        Humidity GetByFlower(int flowerId);
    }
}
