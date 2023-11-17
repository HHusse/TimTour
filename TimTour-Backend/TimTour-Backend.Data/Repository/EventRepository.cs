using System;
using TimTour_Backend.Data.DataModel;

namespace TimTour_Backend.Data.Repository
{
    public class EventRepository
    {
        private readonly TimTourContext Context;
        public EventRepository(TimTourContext context)
        {
            Context = context;
        }

        public async Task<List<EventDto>> GetAll()
        {
            return Context.Events.ToList();
        }

        public async Task<List<EventDto>> GetEventsByType(int type)
        {
            return Context.Events.Where(e => e.Type == type).ToList();
        }
    }
}

