using Microsoft.EntityFrameworkCore;
using MinuteMeals.Ui.Mvc.Models;

namespace MinuteMeals.Ui.Mvc.Core
{
    public class RecipeManagerDbContext : DbContext
    {
        public RecipeManagerDbContext(DbContextOptions<RecipeManagerDbContext> options) : base(options)
        {

        }

        public DbSet<Recipe> Recipe => Set<Recipe>();

        public void Seed()
        {
            var recipes = new List<Recipe>()
            {
                new Recipe { Name = "Lemon Herb Salmon", Steps = "Season salmon, bake with lemon and herbs", Ingredients = "Salmon fillets, lemon, thyme, rosemary, olive oil, salt, pepper", CookingTimeInMinutes = 25 },
                new Recipe { Name = "Stuffed Bell Peppers", Steps = "Stuff peppers with filling, bake until tender", Ingredients = "Bell peppers, ground turkey, rice, tomatoes, onions, garlic, cheese", CookingTimeInMinutes = 35 },
                new Recipe { Name = "Avocado Toast with Poached Egg", Steps = "Toast bread, mash avocado, poach egg, assemble", Ingredients = "Bread, avocado, egg, salt, pepper, chili flakes", CookingTimeInMinutes = 10 },
                new Recipe { Name = "Quinoa Salad with Feta", Steps = "Cook quinoa, mix with veggies and feta", Ingredients = "Quinoa, cucumber, tomatoes, red onion, feta cheese, olive oil, lemon", CookingTimeInMinutes = 15 },
                new Recipe { Name = "Garlic Butter Shrimp Pasta", Steps = "Cook pasta, sauté shrimp in garlic butter, combine", Ingredients = "Spaghetti, shrimp, garlic, butter, parsley, parmesan", CookingTimeInMinutes = 20 },
                new Recipe { Name = "Sweet Potato & Black Bean Tacos", Steps = "Roast sweet potatoes, fill tortillas, add toppings", Ingredients = "Sweet potatoes, black beans, tortillas, avocado, cilantro, lime", CookingTimeInMinutes = 30 },
                new Recipe { Name = "Honey Garlic Glazed Chicken", Steps = "Sear chicken, add honey garlic sauce, simmer", Ingredients = "Chicken thighs, honey, garlic, soy sauce, apple cider vinegar", CookingTimeInMinutes = 25 },
                new Recipe { Name = "Berry Chia Pudding", Steps = "Mix ingredients, refrigerate until thickened", Ingredients = "Chia seeds, almond milk, mixed berries, honey, vanilla extract", CookingTimeInMinutes = 5 },
                new Recipe { Name = "Spinach and Mushroom Frittata", Steps = "Sauté mushrooms and spinach, add eggs, bake", Ingredients = "Eggs, spinach, mushrooms, feta, salt, pepper", CookingTimeInMinutes = 20 },
                new Recipe { Name = "Mango Coconut Smoothie Bowl", Steps = "Blend ingredients, pour into bowl, add toppings", Ingredients = "Mango, coconut milk, banana, chia seeds, granola", CookingTimeInMinutes = 5 }
            };

            Recipe.AddRange(recipes);

            SaveChanges();
        }
    }
}
