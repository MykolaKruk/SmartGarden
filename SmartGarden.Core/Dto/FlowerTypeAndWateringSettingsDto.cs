using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGarden.Core.Dto
{
    public class FlowerTypeAndWateringSettingsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int WateringCapacity { get; set; }
        public int WateringFrequency { get; set; }
        public int MinHumidity { get; set; }
    }
}
