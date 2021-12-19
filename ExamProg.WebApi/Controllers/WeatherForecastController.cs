using ExamProg.WebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExamProg.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
	private readonly WeatherForecastService weatherForecastService;

	public WeatherForecastController(WeatherForecastService weatherForecastService)
	{
		this.weatherForecastService = weatherForecastService;
	}


	[HttpGet]
	public IEnumerable<WeatherForecast> Get(int count = 5)
	{
		return this.weatherForecastService.GetRandom(count);
	}
}