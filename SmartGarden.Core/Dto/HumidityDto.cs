namespace SmartGarden.Core
{
    public class HumidityDto
    {
        public int Id { get; set; }
        public int MinnimumPercentageHumidity { get; set; }

        public int FlowerId { get; set; }
    }
}