using Microsoft.AspNetCore.Mvc;
using ProjectTasksManagement.API.Utilities;
using ProjectTasksManagement.Application.GenericResponse;

namespace ProjectTasksManagement.API.Controllers
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

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            //var t = ApiResponse<IEnumerable<WeatherForecast>>.Success(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            // {
            //     Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            //     TemperatureC = Random.Shared.Next(-20, 55),
            //     Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            // })
            // .ToArray());
            // return t.ToActionResult();
            var t = ApiResponse<IEnumerable<WeatherForecast>>.Failure(Error.BadRequest("this item not found"));
            return t.ToActionResult();
        }
    }
}
