using System;
using TimTour_Backend.Business.Data;
using TimTour_Backend.Data.DataModel;

namespace TimTour_Backend.Business.Mappers
{
    public class RestaurantMapper
    {
        public static Restaurant MapToRestaurant(RestaurantDto dto)
        {
            return new Restaurant(
                dto.Name,
                dto.Address,
                dto.PhoneNumber,
                dto.WebSiteURL
                );
        }
    }
}

