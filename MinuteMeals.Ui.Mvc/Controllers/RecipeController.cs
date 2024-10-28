using Microsoft.AspNetCore.Mvc;
using MinuteMeals.Ui.Mvc.Core;

namespace MinuteMeals.Ui.Mvc.Controllers
{
    public class RecipeController(RecipeManagerDbContext recipeManagerDbContext) : Controller
    {
        private readonly RecipeManagerDbContext _recipeManagerDbContext = recipeManagerDbContext;
        public IActionResult Index()
        {
            var recipes = _recipeManagerDbContext.Recipe.ToList();
            return View(recipes);
        }
    }
}
