namespace ExamProg.WebApi.Services;

public class WeatherForecastService
{
	private static readonly string[] Summaries =
	{
		"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
	};

	public IEnumerable<WeatherForecast> GetRandom(int count)
	{
		if (count <= 0)
			throw new ArgumentException("Count must greater then 0", nameof(count));

		return Enumerable.Range(1, count).Select(index => new WeatherForecast
			{
				Date = DateTime.Now.AddDays(index),
				TemperatureC = Random.Shared.Next(-20, 55),
				Summary = Summaries[Random.Shared.Next(Summaries.Length)]
			})
			.ToArray();
	}
}