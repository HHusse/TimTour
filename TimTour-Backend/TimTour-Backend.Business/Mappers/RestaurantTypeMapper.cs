using System;
using TimTour_Backend.Business.Data;

namespace TimTour_Backend.Business.Mappers
{
    public class RestaurantTypeMapper
    {
        public static Dictionary<RestaurantType, string> Mapper = new Dictionary<RestaurantType, string>() {
            { RestaurantType.NONE, "none"},
            { RestaurantType.ROMANIAN, "romanian"},
            { RestaurantType.ITALIAN, "italian"},
            { RestaurantType.VEGETARIAN, "vegetarian"},
            { RestaurantType.FASTFOOD, "fastfood"}
        };
    }
}

