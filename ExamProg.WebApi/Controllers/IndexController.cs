using Microsoft.AspNetCore.Mvc;

namespace ExamProg.WebApi.Controllers;

[ApiController]
[Route("/")]
[ApiExplorerSettings(IgnoreApi = true)]
public class IndexController : ControllerBase
{
	[HttpGet]
	public IActionResult Get()
	{
		return Redirect("/swagger");
	}
}