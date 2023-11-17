using System;
using Microsoft.AspNetCore.Mvc;
using TimTour_Backend.Business.Actions;
using TimTour_Backend.Data;

namespace TimTour_Backend.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MuseumsController : ControllerBase
    {
        private readonly TimTourContext Context;
        public MuseumsController(TimTourContext context)
        {
            Context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetMuseumsAsync()
        {
            MuseumAction action = new MuseumAction(Context);

            return Ok(await action.Run());
        }
    }
}

