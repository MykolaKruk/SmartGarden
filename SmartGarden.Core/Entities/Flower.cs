using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SmartGarden.Core.Entities.Abstract;

namespace SmartGarden.Core.Entities
{
    public class Flower : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int CurrentHumidity { get; set; }
        public string Name { get; set; }
        public DateTime? LastWatering { get; set; }
        public int WaterCapacity { get; set; }

        [ForeignKey("AppUser"), Required]
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        [ForeignKey("FlowerType"), Required]
        public int FlowerTypeId { get; set; }
        public FlowerType FlowerType { get; set; }

        [ForeignKey("WateringSettings"), Required]
        public int WateringSettingsId { get; set; }
        public WateringSettings WateringSettings { get; set; }
    }
}