using System;
using Microsoft.AspNetCore.Mvc;
using TimTour_Backend.Business.Actions;
using TimTour_Backend.Data;

namespace TimTour_Backend.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantsController : ControllerBase
    {
        private readonly TimTourContext Context;
        public RestaurantsController(TimTourContext context)
        {
            Context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetRestaurantsAsync()
        {
            RestaurantAction action = new RestaurantAction(Context);

            return Ok(await action.Run());
        }
    }
}

