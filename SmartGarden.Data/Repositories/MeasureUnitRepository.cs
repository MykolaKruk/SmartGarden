using SmartGarden.Core.Data;
using SmartGarden.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGarden.Data.Repositories
{
    internal class MeasureUnitRepository : EntityBaseRepository<MeasureUnit>, IMeasureUnitRepository
    {
        public MeasureUnitRepository(FlowerpotContext context) : base(context)
        {
        }
    }
}
