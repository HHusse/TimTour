using System;
using Microsoft.EntityFrameworkCore;
using TimTour_Backend.Data.DataModel;

namespace TimTour_Backend.Data
{
    public class TimTourContext : DbContext
    {
        public TimTourContext()
        {
        }
        public TimTourContext(DbContextOptions<TimTourContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("SQLCONNECTIONSTRING"));
            }
        }
        public DbSet<EventDto> Events { get; set; }
        public DbSet<RestaurantDto> Restaurants { get; set; }
        public DbSet<MuseumDto> Museums { get; set; }
        public DbSet<HotelDto> Hotels { get; set; }
        public DbSet<BarDto> Bars { get; set; }

    }
}

