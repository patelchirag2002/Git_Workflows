using Microsoft.AspNetCore.Mvc;

namespace Git_Workflows.API.Controllers
{
    [ApiController]
    [Route("api/weather-forecast")]
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

        /// <summary>
        /// Get method for weatherforcast
        /// </summary>
        /// <returns></returns>
        [HttpGet("list")]
        public IEnumerable<WeatherForecast> Get()
        {
            var Description = "Test";
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)],
                Description = Description
            })
            .ToArray();
        }
    }
}
