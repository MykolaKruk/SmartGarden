using SmartGarden.Core.Entities.Abstract;

namespace SmartGarden.Core.Entities
{
    public class Flower : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Humidity Humidity { get; set; }
    }
}