using System.Collections.Generic;

namespace TestTask
{
    public class Program
    {
        static void Main()
        {

            List<Cook> cooks = new List<Cook>();
            List<Dish> dishes = new List<Dish>();
            List<Ingredient> ingredients = new List<Ingredient>();

            cooks.Add(new Cook("Steve"));
            cooks.Add(new Cook("Alex"));

            ingredients.Add(new Ingredient("Chicken", 10));
            ingredients.Add(new Ingredient("Mushroom", 11));
            ingredients.Add(new Ingredient("Mozzarella", 12));
            ingredients.Add(new Ingredient("Tomato", 13));
            ingredients.Add(new Ingredient("Salami", 14));
            ingredients.Add(new Ingredient("Pepper", 15));

            Console.WriteLine("Hello," + cooks[0].Name + " !");

            dishes.Add(new Dish("Pizza1", new List<Ingredient>() { ingredients[2], ingredients[0] }, 2));
            dishes.Add(new Dish("Pizza2", new List<Ingredient>() { ingredients[2], ingredients[1] }, 2));
            dishes.Add(new Dish("Pizza3", new List<Ingredient>() { ingredients[2], ingredients[3] }, 2));
            dishes.Add(new Dish("Pizza4", new List<Ingredient>() { ingredients[2], ingredients[4] }, 2));
            dishes.Add(new Dish("Pizza5", new List<Ingredient>() { ingredients[2], ingredients[5] }, 2));
            dishes.Add(new Dish("Pizza6", new List<Ingredient>() { ingredients[2], ingredients[0], ingredients[1] }, 3));
            dishes.Add(new Dish("Pizza7", new List<Ingredient>() { ingredients[2], ingredients[0], ingredients[3] }, 3));
            dishes.Add(new Dish("Pizza8", new List<Ingredient>() { ingredients[2], ingredients[0], ingredients[4] }, 3));
            dishes.Add(new Dish("Pizza9", new List<Ingredient>() { ingredients[2], ingredients[0], ingredients[5] }, 3));
            dishes.Add(new Dish("Pizza10", new List<Ingredient>() { ingredients[2], ingredients[0], ingredients[1], ingredients[3] }, 4));

            Console.WriteLine("Menu:");

            foreach (Dish tmp in dishes)
            {
                Console.WriteLine(tmp.Name + ": " + tmp.Price);
                Console.WriteLine(tmp.Description);
            }

            string? order;
            int occupationBlocker;

            do
            {   

                Console.WriteLine("Enter you order or nothing to exit:");

                order = Console.ReadLine();
                if (order == "")
                    break;

                List<string> orderList = order.Split(',', ' ').ToList();

                orderList.ForEach(item => Console.WriteLine(item));

                foreach(var orderedDish in orderList)
                {
                    occupationBlocker = 0;

                    var orderedCook = cooks.OrderBy(item => item.Occupation.Count).First();

                    foreach (Cook cook in cooks)
                    {
                        if (cook.Occupation.Count < 5)
                        {
                            occupationBlocker = 1;
                        }
                    }

                    if (occupationBlocker == 0)
                    {
                        Console.WriteLine("All cooks are occupied");
                        break;
                    }
                    try
                    {
                        orderedCook.Occupation.Add(dishes.First(item => item.Name == orderedDish));
                    }
                    catch
                    {
                        Console.WriteLine("This Dish cannot be find, try again :(");
                        continue;
                    }

                    foreach (Cook tmp in cooks)
                    {
                        Console.WriteLine(tmp.Occupation.Count);
                    }
                }

            } while (1 == 1);

            int? estimatingTime = 0;
            cooks.ForEach(item => item.Occupation.ForEach(task => estimatingTime += task.CookingTime));

            Console.WriteLine("Your estimated cooking finish time: {0}", estimatingTime);
        }
    }
}

