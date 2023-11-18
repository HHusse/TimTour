using System;
using Microsoft.EntityFrameworkCore;
using TimTour_Backend.Data.DataModel;

namespace TimTour_Backend.Data.Repository
{
    public class HotelRepository
    {
        private readonly TimTourContext Context;
        public HotelRepository(TimTourContext context)
        {
            Context = context;
        }

        public async Task<List<HotelDto>> GetAll()
        {
            return Context.Hotels.ToList();
        }

        public async Task<HotelDto> GetRandomHotel()
        {
            int hotelCount = await Context.Hotels.CountAsync();

            Random random = new Random();
            int randomIndex = random.Next(0, hotelCount);

            var randomHotel = await Context.Hotels
                .Skip(randomIndex)
                .Take(1)
                .FirstOrDefaultAsync();

            return randomHotel;
        }
    }
}

