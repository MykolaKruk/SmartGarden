using Microsoft.EntityFrameworkCore;
using SmartGarden.Core.Entities;
using System;

namespace SmartGarden.Data
{
    public class FlowerpotContext : DbContext
    {
        public FlowerpotContext(DbContextOptions<FlowerpotContext> options) : base(options)
        {
        }

        public FlowerpotContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flower>()
                .HasOne(p => p.Humidity)
                .WithOne(i => i.Flower)
                .HasForeignKey<Humidity>(b => b.FlowerId);
        }
        public DbSet<Flower> Flowers { get; set; }
        public DbSet<Humidity> Humidities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Flowerpotdb;Integrated Security=True");
            }
        }
    }
}
