using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    internal class Dish
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        List<Ingredient> ingredients { get; set; }
        public double Price { get; set; }
        public int? CookingTime { get; set; }


        public Dish(string? name, List<Ingredient> ingredients, int? cookingTime)
        {
            Name = name;
            ingredients.ForEach(item => Description += item.Name + " ");
            this.ingredients = ingredients;
            CookingTime = cookingTime;
            ingredients.ForEach(item => Price += item.Price + item.Price * 0.2);
            
        }
    }
}
