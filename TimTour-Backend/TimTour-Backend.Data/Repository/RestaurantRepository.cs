using System;
using TimTour_Backend.Data.DataModel;

namespace TimTour_Backend.Data.Repository
{
    public class RestaurantRepository
    {
        private readonly TimTourContext Context;
        public RestaurantRepository(TimTourContext context)
        {
            Context = context;
        }

        public async Task<List<RestaurantDto>> GetAll()
        {
            return Context.Restaurants.ToList();
        }
    }
}

