using System;
using TimTour_Backend.Business.Data;

namespace TimTour_Backend.Business.Mappers
{
    public class EventTypeMapper
    {
        public static Dictionary<EventType, string> Mapper = new Dictionary<EventType, string>() {
            { EventType.NONE, "none"},
            { EventType.OPERA, "opera"},
            { EventType.SHOW, "show"},
            { EventType.THEATRE, "theatre"},
            { EventType.MUSIC, "music"}
        };
    }
}

