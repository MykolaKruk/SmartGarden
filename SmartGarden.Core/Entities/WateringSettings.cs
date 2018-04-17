using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SmartGarden.Core.Entities.Abstract;

namespace SmartGarden.Core.Entities
{
    public class WateringSettings : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int WateringCapacity { get; set; }
        public int WateringFrequency { get; set; }
        public int MinHumidity { get; set; }

        [ForeignKey("MeasureUnit"), Required]
        public int MeasureUnitId { get; set; }
        public MeasureUnit MeasureUnit { get; set; }

        public virtual ICollection<Flower> Flowers { get; set; }
        public virtual ICollection<FlowerType> FlowerTypes { get; set; }
    }
}