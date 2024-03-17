using DeliverySystem.BusinessLogic.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace DeliverySystem.WebAPI.Controllers
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
        private readonly IDeliveryQueueService _deliveryQueueService;

        public WeatherForecastController(IDeliveryQueueService deliveryQueueService)
        {
            _deliveryQueueService = deliveryQueueService;
        }

        [HttpGet("get-forecast/by-date/{date}")]
        public IEnumerable<WeatherForecast> Get(DateTime date, bool isNeeded)
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("get-forecast/by-day/{day}")]
        public List<WeatherForecast> GetByDay(int day)
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToList();
        }

        [HttpPost]
        public ActionResult Save(WeatherForecast weatherForecast)
        {
            _deliveryQueueService.AddRequest(new BusinessLogic.Models.DeliveryRequest() { Id = "20" });
            return Ok();
        }
    }
}
