using SmartGarden.Core.Data;
using SmartGarden.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGarden.Data.Repositories
{
    internal class FlowerRepository : EntityBaseRepository<Flower>, IFlowerRepository
    {
        public FlowerRepository(FlowerpotContext context) : base(context)
        {
        }
    }
}
