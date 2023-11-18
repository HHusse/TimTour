using System;
using Microsoft.AspNetCore.Mvc;
using TimTour_Backend.Business.Actions;
using TimTour_Backend.Business.Data;
using TimTour_Backend.Business.Mappers;
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

            return Ok(RestaurantMapper.MapToRestaurantsResponse(await action.Run()));
        }

        [HttpGet("filtred")]
        public async Task<ActionResult> GetEventsFiltredAsync(string type)
        {
            try
            {
                RestaurantType searchedType = RestaurantTypeMapper.Mapper.First(t => t.Value == type).Key;
                RestaurantAction action = new RestaurantAction(Context);

                return Ok(RestaurantMapper.MapToRestaurantsResponse(await action.Run((int)searchedType)));
            }
            catch (InvalidOperationException)
            {
                var response = new { message = $"Bad parameter [type] does not contain [{type}]" };
                return BadRequest(response);
            }
        }
    }
}

