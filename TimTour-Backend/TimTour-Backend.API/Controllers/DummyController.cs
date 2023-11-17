using System;
using Microsoft.AspNetCore.Mvc;

namespace TimTour_Backend.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DummyController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> GetHelloAsync()
        {
            return Ok();
        }
    }
}

