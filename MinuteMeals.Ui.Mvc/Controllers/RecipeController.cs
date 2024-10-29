using Microsoft.AspNetCore.Mvc;
using MinuteMeals.Ui.Mvc.Core;

namespace MinuteMeals.Ui.Mvc.Controllers
{
    public class RecipeController(RecipeManagerDbContext recipeManagerDbContext) : Controller
    {
        // Dependency injection
        private readonly RecipeManagerDbContext _recipeManagerDbContext = recipeManagerDbContext;
        
        // Lijst van recepten
        public IActionResult Index()
        {
            var recipes = _recipeManagerDbContext.Recipe.ToList();
            return View(recipes);
        }
        
        // Details van specifiek recept
        public IActionResult Details(int id)
        {
            var recipe = _recipeManagerDbContext.Recipe.FirstOrDefault(recipe => recipe.Id == id);
            if (recipe == null)
            {
                return NotFound();
            }
            return View(recipe);
        }
    }
}
