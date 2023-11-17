using TimTour_Backend.Business.Data;
using TimTour_Backend.Business.Mappers;
using TimTour_Backend.Data;
using TimTour_Backend.Data.DataModel;
using TimTour_Backend.Data.Repository;

namespace TimTour_Backend.Business.Actions
{
    public class EventAction
    {
        private readonly TimTourContext Context;
        public EventAction(TimTourContext context)
        {
            Context = context;
        }

        public async Task<List<Event>> Run()
        {
            List<Event> events = new List<Event>();
            EventRepository eventRepository = new EventRepository(Context);
            List<EventDto> dtoEvent = await eventRepository.GetAll();

            dtoEvent.ForEach(e => events.Add(EventMapper.MapToEvent(e)));

            return events;
        }

        public async Task<List<Event>> Run(int type)
        {
            List<Event> events = new List<Event>();
            EventRepository eventRepository = new EventRepository(Context);
            List<EventDto> dtoEvent = await eventRepository.GetEventsByType(type);

            dtoEvent.ForEach(e => events.Add(EventMapper.MapToEvent(e)));

            return events;
        }
    }
}

