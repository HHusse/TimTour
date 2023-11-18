using System;
using Microsoft.EntityFrameworkCore;
using TimTour_Backend.Data.DataModel;

namespace TimTour_Backend.Data.Repository
{
    public class MuseumRepository
    {
        private readonly TimTourContext Context;
        public MuseumRepository(TimTourContext context)
        {
            Context = context;
        }

        public async Task<List<MuseumDto>> GetAll()
        {
            return Context.Museums.ToList();
        }

        public async Task<MuseumDto> GetRandomMuseum()
        {
            int museumCount = await Context.Museums.CountAsync();

            Random random = new Random();
            int randomIndex = random.Next(0, museumCount);

            var randomMuseum = await Context.Museums
                .Skip(randomIndex)
                .Take(1)
                .FirstOrDefaultAsync();

            return randomMuseum;
        }
    }
}

