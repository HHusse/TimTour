using System;
using TimTour_Backend.Business.Data;

namespace TimTour_Backend.Business.ResponseModels
{
    public class RecommendationResponseModel
    {
        public RecommendationResponseModel(RestaurantResponseModel restaurant, EventResponseModel e, Bar bar, Museum museum, Hotel hotel)
        {
            Restaurant = restaurant;
            Event = e;
            Bar = bar;
            Museum = museum;
            Hotel = hotel;
        }

        public RestaurantResponseModel Restaurant { get; set; }
        public EventResponseModel Event { get; set; }
        public Bar Bar { get; set; }
        public Museum Museum { get; set; }
        public Hotel Hotel { get; set; }
    }
}

