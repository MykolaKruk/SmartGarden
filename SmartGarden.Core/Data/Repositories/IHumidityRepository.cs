using SmartGarden.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGarden.Core.Data
{
    public interface IHumidityRepository : IEntityBaseRepository<Humidity>
    {
        Humidity GetFlower(int flowerId);
    }
}
