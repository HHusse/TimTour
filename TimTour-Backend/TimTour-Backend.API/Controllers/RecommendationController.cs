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
    public class RecommendationController : ControllerBase
    {
        private readonly TimTourContext Context;
        public RecommendationController(TimTourContext context)
        {
            Context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetMuseumsAsync()
        {
            RecommendationAction action = new RecommendationAction(Context);

            return Ok(await action.Run());
        }

        [HttpGet("filtred")]
        public async Task<ActionResult> GetMuseumsAsync(string restaurantType, string eventType)
        {
            try
            {
                EventType searchedEventType = EventTypeMapper.Mapper.First(t => t.Value == eventType).Key;
                RestaurantType searchedRestaurantType = RestaurantTypeMapper.Mapper.First(t => t.Value == restaurantType).Key;
                RecommendationAction action = new RecommendationAction(Context);

                return Ok(await action.Run((int)searchedRestaurantType, (int)searchedEventType));
            }
            catch (InvalidOperationException)
            {
                var response = new { message = $"Bad parameter [type] does not contain [{restaurantType}] or [{eventType}]" };
                return BadRequest(response);
            }

        }
    }
}

