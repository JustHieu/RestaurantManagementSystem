using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManagementSystem
{
    public abstract class Food
    {
        private string name;
        private string description; // mô tả
        private double prices;
        private List<Ingredient> ingredients;
        public Food(string name, string description, double prices, List<Ingredient> ingredients)
        {
            this.Name = name;
            this.Description = description;
            this.Prices = prices;
            this.Ingredients = ingredients;
        }

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public double Prices { get => prices; set => prices = value; }
        public List<Ingredient> Ingredients { get => ingredients; set => ingredients = value; }

        public abstract string Info();
    }
}