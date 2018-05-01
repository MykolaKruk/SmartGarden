using SmartGarden.Core.Data;
using SmartGarden.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGarden.Data.Repositories
{
    internal class WateringSettingsRepository : EntityBaseRepository<WateringSettings>, IWateringSettingsRepository
    {
        public WateringSettingsRepository(FlowerpotContext context) : base(context)
        {
        }
    }
}
