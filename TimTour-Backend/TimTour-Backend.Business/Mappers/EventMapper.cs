using System;
using TimTour_Backend.Business.Data;
using TimTour_Backend.Business.ResponseModels;
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

        public static EventType MapToEventType(int type)
        {
            return (EventType)type;
        }

        public static EventResponseModel MapToEventResonse(Event e)
        {
            return new EventResponseModel(
                e.Name,
                e.Type,
                e.Date,
                e.Time,
                e.Location,
                e.LocationAddress
                );
        }

        public static List<EventResponseModel> MapToEventsResponse(List<Event> events)
        {
            List<EventResponseModel> responseModel = new List<EventResponseModel>();

            events.ForEach(e => responseModel.Add(MapToEventResonse(e)));
            return responseModel;
        }
    }
}

