using Microsoft.AspNetCore.Mvc;
using MinuteMeals.Ui.Mvc.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using MinuteMeals.Ui.Mvc.Core;

namespace MinuteMeals.Ui.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly RecipeManagerDbContext _recipeManagerDbContext;

        public HomeController(RecipeManagerDbContext database)
        {
            _recipeManagerDbContext = database;
        }

        public IActionResult Index()
        {
            var recipes = _recipeManagerDbContext.Recipe.ToList();
            return View(recipes);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Recipes()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
