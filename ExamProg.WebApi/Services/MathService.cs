namespace ExamProg.WebApi.Services;

public class MathService
{
	public IEnumerable<int> ArithmeticProgression(int a = 3,int d = 2)
	{
		int sum = 0;
		for (; a <= d; a++)
		{
			sum += a;
			yield return sum;
		}
	}
}