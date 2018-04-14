using SmartGarden.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGarden.Core.Entities
{
    public class Humidity : IEntity
    {
        public int Id { get; set; }
        public int MinnimumPercentageHumidity { get; set; }

        public int FlowerId { get; set; }
        public Flower Flower { get; set; }
    }
}
