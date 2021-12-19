using System;
using System.Collections.Generic;
using System.Linq;
using ExamProg.WebApi;
using ExamProg.WebApi.Services;
using Xunit;

namespace ExamProg.Tests;

public class WeatherForecastServiceTests
{
	private readonly WeatherForecastService weatherForecastService;

	public WeatherForecastServiceTests()
	{
		weatherForecastService = new WeatherForecastService();
	}

	[Fact]
	public void GetRandom_CorrectData_Test()
	{
		// arrange
		int count = 10;

		// act
		IEnumerable<WeatherForecast> result = this.weatherForecastService.GetRandom(count);

		// assert
		Assert.Equal(result.Count(), count);
	}

	[Fact]
	public void GetRandom_InvalidData_Test()
	{
		int count = -10;

		Assert.Throws<ArgumentException>(() => this.weatherForecastService.GetRandom(count));
	}
}