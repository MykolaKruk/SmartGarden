using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGarden.Core.Dto
{
    class WateringSettingsDto
    {
        public int Id { get; set; }
        public int WateringCapacity { get; set; }
        public int WateringFrequency { get; set; }
        public int MinHumidity { get; set; }


    }
}
