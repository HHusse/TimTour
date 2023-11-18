using System;
using Microsoft.EntityFrameworkCore;
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

        public async Task<EventDto> GetRandomEvent()
        {
            int eventCount = await Context.Events.CountAsync();

            Random random = new Random();
            int randomIndex = random.Next(0, eventCount);

            var randomEvent = await Context.Events
                .Skip(randomIndex)
                .Take(1)
                .FirstOrDefaultAsync();

            return randomEvent;
        }

        public async Task<EventDto> GetRandomEventByType(int type)
        {
            int eventCount = await Context.Events
                .Where(r => r.Type == type)
                .CountAsync();

            if (eventCount == 0)
            {
                return null;
            }

            Random random = new Random();
            int randomIndex = random.Next(0, eventCount);

            var randomEvent = await Context.Events
                .Where(r => r.Type == type)
                .Skip(randomIndex)
                .Take(1)
                .FirstOrDefaultAsync();

            return randomEvent;
        }
    }
}

