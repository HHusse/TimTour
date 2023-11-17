using System;
using Microsoft.AspNetCore.Mvc;
using TimTour_Backend.Business.Actions;
using TimTour_Backend.Data;

namespace TimTour_Backend.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BarsController : ControllerBase
    {
        private readonly TimTourContext Context;
        public BarsController(TimTourContext context)
        {
            Context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetBarsAsync()
        {
            BarAction action = new BarAction(Context);

            return Ok(await action.Run());
        }
    }
}

