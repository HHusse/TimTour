using System;
using Microsoft.AspNetCore.Mvc;
using TimTour_Backend.Business.Actions;
using TimTour_Backend.Data;

namespace TimTour_Backend.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HotelsController : ControllerBase
    {
        private readonly TimTourContext Context;
        public HotelsController(TimTourContext context)
        {
            Context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetHotelsAsync()
        {
            HotelAction action = new HotelAction(Context);

            return Ok(await action.Run());
        }
    }
}

