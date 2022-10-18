using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    internal class Cook
    {
        public string Name { get; set; }

        public List<Dish> Occupation = new List<Dish>();

        public Cook(string name)
        {
            Name = name;
        }
    }
}
