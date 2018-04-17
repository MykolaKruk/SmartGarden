using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using SmartGarden.Core.Entities.Abstract;

namespace SmartGarden.Core.Entities
{
    public class AppUser : IdentityUser
    {
        public virtual ICollection<Flower> Flowers { get; set; }
    }
}
