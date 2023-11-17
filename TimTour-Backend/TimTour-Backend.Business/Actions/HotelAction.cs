using TimTour_Backend.Business.Data;
using TimTour_Backend.Business.Mappers;
using TimTour_Backend.Data;
using TimTour_Backend.Data.DataModel;
using TimTour_Backend.Data.Repository;

namespace TimTour_Backend.Business.Actions
{
    public class HotelAction
    {
        private readonly TimTourContext Context;
        public HotelAction(TimTourContext context)
        {
            Context = context;
        }

        public async Task<List<Hotel>> Run()
        {
            List<Hotel> hotels = new List<Hotel>();
            HotelRepository hotelRepository = new HotelRepository(Context);
            List<HotelDto> dtoHotels = await hotelRepository.GetAll();

            dtoHotels.ForEach(h => hotels.Add(HotelMapper.MapToHotel(h)));

            return hotels;
        }
    }
}

