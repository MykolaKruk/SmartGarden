using SmartGarden.Core.Data;
using SmartGarden.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGarden.Data.Repositories
{
    internal class FlowerTypeRepository : EntityBaseRepository<FlowerType>, IFlowerTypeRepository
    {
        public FlowerTypeRepository(FlowerpotContext context) : base(context)
        {
        }
    }
}
