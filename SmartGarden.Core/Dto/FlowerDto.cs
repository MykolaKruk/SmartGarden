using System;

namespace SmartGarden.Core
{
    public class FlowerDto
    {
        public int Id { get; set; }
        public int CurrentHumidity { get; set; }
        public string Name { get; set; }
        public DateTime? LastWatering { get; set; }
        public int WaterCapacity { get; set; }
    }
}