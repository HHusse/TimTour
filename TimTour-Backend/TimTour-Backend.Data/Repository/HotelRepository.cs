using System;
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
    }
}

