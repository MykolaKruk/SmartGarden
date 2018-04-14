using SmartGarden.Core.Data;
using SmartGarden.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartGarden.Data.Repositories
{
    internal class HumidityRepository : EntityBaseRepository<Humidity>, IHumidityRepository
    {
        public HumidityRepository(FlowerpotContext context) : base(context)
        {
        }

        public Humidity GetFlower(int flowerId)
        {
            return _dbSet.Where(item => item.FlowerId == flowerId).FirstOrDefault();
        }
    }
}
