using System;
namespace TimTour_Backend.Business.Data
{
    public class Event
    {
        public Event(string name, EventType type, string date, string time, string location, string locationAddress)
        {
            Name = name;
            Type = type;
            Date = date;
            Time = time;
            Location = location;
            LocationAddress = locationAddress;
        }

        public string Name { get; set; }
        public EventType Type { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Location { get; set; }
        public string LocationAddress { get; set; }
    }
}

