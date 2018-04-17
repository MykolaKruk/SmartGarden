using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SmartGarden.Core.Entities.Abstract;

namespace SmartGarden.Core.Entities
{
    public class MeasureUnit : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<WateringSettings> WateringSettingses { get; set; }
    }
}