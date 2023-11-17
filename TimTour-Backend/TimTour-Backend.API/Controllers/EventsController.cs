using System;
using Microsoft.AspNetCore.Mvc;
using TimTour_Backend.Business.Actions;
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

            return Ok(await action.Run());
        }

        [HttpGet("filtred")]
        public async Task<ActionResult> GetEventsFiltredAsync(int type)
        {
            EventAction action = new EventAction(Context);

            return Ok(await action.Run(type));
        }
    }
}

