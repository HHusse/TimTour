using System;
using TimTour_Backend.Business.Data;
using TimTour_Backend.Data.DataModel;

namespace TimTour_Backend.Business.Mappers
{
    public class HotelMapper
    {
        public static Hotel MapToHotel(HotelDto dto)
        {
            return new Hotel(
                dto.Name,
                dto.Stars,
                dto.Address,
                dto.PhoneNumber,
                dto.WebSiteURL
                );
        }
    }
}

