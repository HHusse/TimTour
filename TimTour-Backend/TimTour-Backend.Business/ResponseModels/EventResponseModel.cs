using System;
using TimTour_Backend.Business.Data;
using TimTour_Backend.Business.Mappers;

namespace TimTour_Backend.Business.ResponseModels
{
    public class EventResponseModel
    {
        public EventResponseModel(string name, EventType type, string date, string time, string location, string locationAddress)
        {
            Name = name;
            Type = EventTypeMapper.Mapper.First(t => t.Key == type).Value;
            Date = date;
            Time = time;
            Location = location;
            LocationAddress = locationAddress;
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Location { get; set; }
        public string LocationAddress { get; set; }
    }
}

