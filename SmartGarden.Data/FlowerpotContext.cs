using Microsoft.EntityFrameworkCore;
using SmartGarden.Core.Entities;
using System;
using System.Linq;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SmartGarden.Data
{
    public class FlowerpotContext : IdentityDbContext<AppUser>
    {
        public FlowerpotContext(DbContextOptions<FlowerpotContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var relationship in modelBuilder.Entity<Flower>().Metadata.GetForeignKeys())
                relationship.DeleteBehavior = DeleteBehavior.Restrict;


            //modelBuilder.Entity<Flower>()
            //    .HasOne(item => item.WateringSettings)
            //    .WithMany()
            //    .HasForeignKey(item => item.WateringSettingsId)
            //    .OnDelete(DeleteBehavior.Restrict);
        }

        public DbSet<Flower> Flowers { get; set; }
        public DbSet<FlowerType> FlowerTypes { get; set; }
        public DbSet<MeasureUnit> MeasureUnits { get; set; }
        public DbSet<WateringSettings> WateringSettingses { get; set; }
    }
}
