using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ConsoleApp1
{
    public class Food
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Food(string name, double price)
        {
            Name = name;
            Price = price;
        }
                
    }
}
