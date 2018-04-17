using SmartGarden.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGarden.Core.Services
{
    public interface IWateringSettingsService: IService<WateringSettings>
    {
        bool UpperMinnimumPercentageHumidity(WateringSettings wateringSettings);
    }
}
