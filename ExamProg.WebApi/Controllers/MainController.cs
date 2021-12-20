using ExamProg.WebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExamProg.WebApi.Controllers
{
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
		public ActionResult Task(int n)
		{
			return Ok(new
			{
					Author = "Yermakov Yurii",
					Result = this.mathService.ArithmeticProgression(n)
			});
		}
	}
}