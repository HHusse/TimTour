using TimTour_Backend.Business.Data;
using TimTour_Backend.Business.Mappers;
using TimTour_Backend.Data;
using TimTour_Backend.Data.DataModel;
using TimTour_Backend.Data.Repository;

namespace TimTour_Backend.Business.Actions
{
    public class MuseumAction
    {
        private readonly TimTourContext Context;
        public MuseumAction(TimTourContext context)
        {
            Context = context;
        }

        public async Task<List<Museum>> Run()
        {
            List<Museum> museums = new List<Museum>();
            MuseumRepository museumRepository = new MuseumRepository(Context);
            List<MuseumDto> dtoMuseums = await museumRepository.GetAll();

            dtoMuseums.ForEach(m => museums.Add(MuseumMapper.MapToMuseum(m)));

            return museums;
        }
    }
}

