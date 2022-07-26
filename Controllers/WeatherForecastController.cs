using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace QueryParams.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Get([FromQuery] TestRequestObject testRequestObject)
        {
            return Ok();
        }

        public class TestRequestObject
        {
            public List<int> Ids { get; set; } = new List<int>();

            public List<Status> Statuses { get; set; } = new List<Status>();
        }

        public enum Status
        {
            Ready,
            Progressing,
            Done
        }
    }
}