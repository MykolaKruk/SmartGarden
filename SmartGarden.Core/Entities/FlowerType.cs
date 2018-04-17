using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SmartGarden.Core.Entities.Abstract;

namespace SmartGarden.Core.Entities
{
    public class FlowerType : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        [ForeignKey("WateringSettings"), Required]
        public int RecommendedWateringSettingsId { get; set; }
        public WateringSettings RecommendedWateringSettings { get; set; }

        public virtual ICollection<Flower> Flowers { get; set; }

    }
}