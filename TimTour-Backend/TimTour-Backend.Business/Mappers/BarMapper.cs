using System;
using TimTour_Backend.Business.Data;
using TimTour_Backend.Data.DataModel;

namespace TimTour_Backend.Business.Mappers
{
    public class BarMapper
    {
        public static Bar MapToBar(BarDto dto)
        {
            return new Bar(
                dto.Name,
                dto.Address,
                dto.PhoneNumber,
                dto.WebSiteURL
                );
        }
    }
}

