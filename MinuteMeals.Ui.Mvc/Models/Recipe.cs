using System.ComponentModel.DataAnnotations.Schema;

namespace MinuteMeals.Ui.Mvc.Models
{
    [Table(nameof(Recipe))]
    public class Recipe
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string Ingredients { get; set; }
        public required string Steps { get; set; }
        public int CookingTimeInMinutes { get; set; }
    }
}
