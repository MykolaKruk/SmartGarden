using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGarden.Core.Dto
{
    public class FlowerTypeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RecommendedWateringSettingsId { get; set; }


    }
}
