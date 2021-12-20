using ExamProg.WebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExamProg.WebApi.Controllers;

[ApiController]
[Route("/")]
public class MainController : ControllerBase
{
	private readonly MathService mathService;
	public MainController(MathService mathService)
	{
		this.mathService = mathService;
	}

	[HttpGet]
	[ApiExplorerSettings(IgnoreApi = true)]
	public IActionResult Get()
	{
		return Redirect("/swagger");
	}

	[HttpGet("task")]
	public IEnumerable<int> Task(int a = 3, int d = 2)
	{
		return this.mathService.ArithmeticProgression(a, d).ToList();
	}
}м