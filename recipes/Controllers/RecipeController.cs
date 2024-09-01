using Microsoft.AspNetCore.Mvc;
using recipes.Models;

namespace recipes.Controllers
{
	public class RecipeController : Controller
	{
		private static List<Recipe> _recipes = new List<Recipe>();
		private static int _Id = 0;
		public RecipeController()
		{
			if (!_recipes.Any())
			{
				_recipes.Add(new Recipe
				{
					id = _Id++,
					Ingredients = new List<string> { "sugar", "coffee", "hot Water", "milk" },
					Phases = new List<string> { "1. add two spoon of sugar to the cup", "2. add one spoon of coffee to the cup", "3. boil hot water and fill the cup", "4. add milk and drink!" }
				});
			}
		}


		public IActionResult Index()
		{
			return View();
		}


		public IActionResult DeleteRecipe(int id)
		{
			var myRecipe = _recipes.FirstOrDefault(recipe => recipe.id == id);
			if (myRecipe == null)
			{
				return NotFound();
			}
			_recipes.Remove(myRecipe);
			return RedirectToAction("Index");
		}

	}
}
}
