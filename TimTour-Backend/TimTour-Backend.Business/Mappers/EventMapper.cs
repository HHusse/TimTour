using System;
using TimTour_Backend.Business.Data;
using TimTour_Backend.Data.DataModel;
namespace TimTour_Backend.Business.Mappers
{
    public class EventMapper
    {
        public static Event MapToEvent(EventDto dto)
        {
            return new Event(
                dto.Name,
                MapToEventType(dto.Type),
                dto.Date,
                dto.Time,
                dto.Location,
                dto.LocationAddress
                );
        }

        private static EventType MapToEventType(int type)
        {
            return (EventType)type;
        }
    }
}

