using TimTour_Backend.Business.Data;
using TimTour_Backend.Business.Mappers;
using TimTour_Backend.Data;
using TimTour_Backend.Data.DataModel;
using TimTour_Backend.Data.Repository;

namespace TimTour_Backend.Business.Actions
{
    public class BarAction
    {
        private readonly TimTourContext Context;
        public BarAction(TimTourContext context)
        {
            Context = context;
        }

        public async Task<List<Bar>> Run()
        {
            List<Bar> bars = new List<Bar>();
            BarRepository barRepository = new BarRepository(Context);
            List<BarDto> dtoBars = await barRepository.GetAll();

            dtoBars.ForEach(b => bars.Add(BarMapper.MapToBar(b)));

            return bars;
        }
    }
}

