using System;
using Microsoft.EntityFrameworkCore;
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

        public async Task<RestaurantDto> GetRandomRestaurant()
        {
            int restarurantCount = await Context.Restaurants.CountAsync();

            Random random = new Random();
            int randomIndex = random.Next(0, restarurantCount);

            var randomRestaurant = await Context.Restaurants
                .Skip(randomIndex)
                .Take(1)
                .FirstOrDefaultAsync();

            return randomRestaurant;
        }

        public async Task<RestaurantDto> GetRandomRestaurantByType(int type)
        {
            int restaurantCount = await Context.Restaurants
                .Where(r => r.Type == type)
                .CountAsync();

            if (restaurantCount == 0)
            {
                return null;
            }

            Random random = new Random();
            int randomIndex = random.Next(0, restaurantCount);

            var randomRestaurant = await Context.Restaurants
                .Where(r => r.Type == type)
                .Skip(randomIndex)
                .Take(1)
                .FirstOrDefaultAsync();

            return randomRestaurant;
        }
    }
}

