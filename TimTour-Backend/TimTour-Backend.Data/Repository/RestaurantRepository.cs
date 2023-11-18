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

        public async Task<List<RestaurantDto>> GetRstaurantByType(int type)
        {
            return Context.Restaurants.Where(r => r.Type == type).ToList();
        }
    }
}

