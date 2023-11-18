using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TimTour_Backend.Business.Actions;
using TimTour_Backend.Business.Data;
using TimTour_Backend.Business.Mappers;
using TimTour_Backend.Data;

namespace TimTour_Backend.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly TimTourContext Context;
        public EventsController(TimTourContext context)
        {
            Context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetEventsAsync()
        {
            EventAction action = new EventAction(Context);

            return Ok(EventMapper.MapToEventsResponse(await action.Run()));
        }

        [HttpGet("filtred")]
        public async Task<ActionResult> GetEventsFiltredAsync(string type)
        {
            try
            {
                EventType searchedType = EventTypeMapper.Mapper.First(t => t.Value == type).Key;
                EventAction action = new EventAction(Context);

                return Ok(EventMapper.MapToEventsResponse(await action.Run((int)searchedType)));
            }
            catch (InvalidOperationException)
            {
                var response = new { message = $"Bad parameter [type] does not contain [{type}]" };
                return BadRequest(response);
            }
        }
    }
}

