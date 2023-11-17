using System;
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
    }
}

