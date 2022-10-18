using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    internal class Ingredient
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Ingredient(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
