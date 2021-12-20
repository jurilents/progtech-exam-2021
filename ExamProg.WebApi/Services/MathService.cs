using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamProg.WebApi.Services
{
	public class MathService
	{
		public int ArithmeticProgression(int n)
		{
			if (n <= 0)
				throw new ArgumentException("Element index must be greater then 0.", nameof(n));

			const int d = 2;
			const int a = 3;
			return a + (n - 1) * d;
		}

		public int FindMax(IEnumerable<int> array)
		{
			if (array is null)
				throw new ArgumentNullException(nameof(array));

			return array.Max();
		}
	}
}