using System;
using TimTour_Backend.Business.Data;
using TimTour_Backend.Data.DataModel;

namespace TimTour_Backend.Business.Mappers
{
    public class MuseumMapper
    {
        public static Museum MapToMuseum(MuseumDto dto)
        {
            return new Museum(
                dto.Name,
                dto.Address,
                dto.WebSiteURL
                );
        }
    }
}

