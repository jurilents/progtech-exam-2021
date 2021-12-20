using System;
using ExamProg.WebApi.Services;
using Xunit;
using Xunit.Abstractions;

namespace ExamProg.Tests
{
	public class MathServiceTests
	{
		private readonly ITestOutputHelper output;
		private readonly MathService mathService;

		public MathServiceTests(ITestOutputHelper output)
		{
			this.output = output;
			mathService = new MathService();
		}

		[Theory]
		[InlineData(-10)]
		[InlineData(0)]
		[InlineData(1)]
		[InlineData(5)]
		[InlineData(10)]
		public void ArithmeticProgression_Test(int n)
		{
			if (n <= 0)
			{
				Assert.Throws<ArgumentException>(() => this.mathService.ArithmeticProgression(n));
			}
			else
			{
				int actual = this.mathService.ArithmeticProgression(n);

				int expected = 3 + (n - 1) * 2;
				output.WriteLine("expected: " + expected + "\nactual: " + actual);

				Assert.Equal(expected, actual);
			}
		}


		[Theory]
		[InlineData(new[] { 1, 2, 3 }, 3)]
		[InlineData(new[] { -1, 0, -10000 }, 0)]
		[InlineData(null, 0)]
		public void FinMax_Test(int[]? array, int expectedMax)
		{
			if (array is null)
			{
				Assert.Throws<ArgumentNullException>(() => this.mathService.FindMax(array));
			}
			else
			{
				int actual = this.mathService.FindMax(array);
				Assert.Equal(expectedMax, actual);
			}
		}
	}
}