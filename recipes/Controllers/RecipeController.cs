using Microsoft.AspNetCore.Mvc;

namespace recipes.Controllers
{
	public class RecipeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
