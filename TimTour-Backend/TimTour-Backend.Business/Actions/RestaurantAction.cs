using TimTour_Backend.Business.Data;
using TimTour_Backend.Business.Mappers;
using TimTour_Backend.Data;
using TimTour_Backend.Data.DataModel;
using TimTour_Backend.Data.Repository;

namespace TimTour_Backend.Business.Actions
{
    public class RestaurantAction
    {
        private readonly TimTourContext Context;
        public RestaurantAction(TimTourContext context)
        {
            Context = context;
        }

        public async Task<List<Restaurant>> Run()
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            RestaurantRepository restaurantRepository = new RestaurantRepository(Context);
            List<RestaurantDto> dtoRestaurants = await restaurantRepository.GetAll();

            dtoRestaurants.ForEach(r => restaurants.Add(RestaurantMapper.MapToRestaurant(r)));

            return restaurants;
        }

        public async Task<List<Restaurant>> Run(int type)
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            RestaurantRepository restaurantRepository = new RestaurantRepository(Context);
            List<RestaurantDto> dtoRestaurants = await restaurantRepository.GetRstaurantByType(type);

            dtoRestaurants.ForEach(e => restaurants.Add(RestaurantMapper.MapToRestaurant(e)));

            return restaurants;
        }
    }
}

