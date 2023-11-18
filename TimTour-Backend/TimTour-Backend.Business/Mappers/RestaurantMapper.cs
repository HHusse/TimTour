using System;
using TimTour_Backend.Business.Data;
using TimTour_Backend.Business.ResponseModels;
using TimTour_Backend.Data.DataModel;

namespace TimTour_Backend.Business.Mappers
{
    public class RestaurantMapper
    {
        public static Restaurant MapToRestaurant(RestaurantDto dto)
        {
            return new Restaurant(
                dto.Name,
                (RestaurantType)dto.Type,
                dto.Address,
                dto.PhoneNumber,
                dto.WebSiteURL
                );
        }

        public static RestaurantResponseModel MapToRestaurantResonse(Restaurant r)
        {
            return new RestaurantResponseModel(
                r.Name,
                r.Type,
                r.Address,
                r.PhoneNumber,
                r.WebSiteURL
                );
        }

        public static List<RestaurantResponseModel> MapToRestaurantsResponse(List<Restaurant> restaurants)
        {
            List<RestaurantResponseModel> responseModel = new List<RestaurantResponseModel>();

            restaurants.ForEach(e => responseModel.Add(MapToRestaurantResonse(e)));
            return responseModel;
        }
    }
}

