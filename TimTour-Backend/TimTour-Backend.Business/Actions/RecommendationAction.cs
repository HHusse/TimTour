using System;
using TimTour_Backend.Business.Data;
using TimTour_Backend.Business.Mappers;
using TimTour_Backend.Business.ResponseModels;
using TimTour_Backend.Data;
using TimTour_Backend.Data.DataModel;
using TimTour_Backend.Data.Repository;

namespace TimTour_Backend.Business.Actions
{
    public class RecommendationAction
    {
        private readonly TimTourContext Context;
        public RecommendationAction(TimTourContext context)
        {
            Context = context;
        }

        public async Task<RecommendationResponseModel> Run()
        {
            RestaurantRepository restaurantRepository = new RestaurantRepository(Context);
            RestaurantResponseModel restaurant = RestaurantMapper.MapToRestaurantResonse(RestaurantMapper.MapToRestaurant(await restaurantRepository.GetRandomRestaurant()));

            EventRepository eventRepository = new EventRepository(Context);
            EventResponseModel e = EventMapper.MapToEventResonse(EventMapper.MapToEvent(await eventRepository.GetRandomEvent()));

            MuseumRepository museumRepository = new MuseumRepository(Context);
            Museum museum = MuseumMapper.MapToMuseum(await museumRepository.GetRandomMuseum());

            HotelRepository hotelRepository = new HotelRepository(Context);
            Hotel hotel = HotelMapper.MapToHotel(await hotelRepository.GetRandomHotel());

            BarRepository barRepository = new BarRepository(Context);
            Bar bar = BarMapper.MapToBar(await barRepository.GetRandomBar());

            RecommendationResponseModel recommendation = new RecommendationResponseModel(restaurant, e, bar, museum, hotel);
            return recommendation;
        }

        public async Task<RecommendationResponseModel> Run(int restaurantType, int eventType)
        {
            RestaurantRepository restaurantRepository = new RestaurantRepository(Context);
            RestaurantResponseModel restaurant = RestaurantMapper.MapToRestaurantResonse(RestaurantMapper.MapToRestaurant(await restaurantRepository.GetRandomRestaurantByType(restaurantType)));

            EventRepository eventRepository = new EventRepository(Context);
            EventResponseModel e = EventMapper.MapToEventResonse(EventMapper.MapToEvent(await eventRepository.GetRandomEventByType(eventType)));

            MuseumRepository museumRepository = new MuseumRepository(Context);
            Museum museum = MuseumMapper.MapToMuseum(await museumRepository.GetRandomMuseum());

            HotelRepository hotelRepository = new HotelRepository(Context);
            Hotel hotel = HotelMapper.MapToHotel(await hotelRepository.GetRandomHotel());

            BarRepository barRepository = new BarRepository(Context);
            Bar bar = BarMapper.MapToBar(await barRepository.GetRandomBar());

            RecommendationResponseModel recommendation = new RecommendationResponseModel(restaurant, e, bar, museum, hotel);
            return recommendation;
        }
    }
}

