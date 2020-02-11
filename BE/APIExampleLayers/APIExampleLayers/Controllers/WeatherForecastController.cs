using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Recomendation;
using WeatherBusiness;
using APIExampleLayers.DTO;

namespace APIExampleLayers.Controllers
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
        public WeatherDto Get()
        {
            Forecast fore = new Forecast();
            WeatherRecomendation reco = fore.GetRecomendation();
            WeatherDto dto = new WeatherDto() { forecast = reco.message };
            return dto;
        }
    }
}
