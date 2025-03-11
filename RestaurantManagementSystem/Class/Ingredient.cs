using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManagementSystem
{
    public class Ingredient
    {
        private string name;
        private double prices;

        public string Name { get => name; set => name = value; }
        public double Prices { get => prices; set => prices = value; }
    }
}