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

        public async Task<BarDto> GetRandomBar()
        {
            int barCount = await Context.Bars.CountAsync();

            Random random = new Random();
            int randomIndex = random.Next(0, barCount);

            var randomBar = await Context.Bars
                .Skip(randomIndex)
                .Take(1)
                .FirstOrDefaultAsync();

            return randomBar;
        }
    }
}

