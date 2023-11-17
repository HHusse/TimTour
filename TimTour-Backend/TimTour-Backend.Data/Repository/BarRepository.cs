using System;
using Microsoft.EntityFrameworkCore;
using TimTour_Backend.Data.DataModel;

namespace TimTour_Backend.Data.Repository
{
    public class BarRepository
    {
        private readonly TimTourContext Context;
        public BarRepository(TimTourContext context)
        {
            Context = context;
        }

        public async Task<List<BarDto>> GetAll()
        {
            return Context.Bars.ToList();
        }
    }
}

