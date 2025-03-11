using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManagementSystem
{
    public class Dessert : Food
    {
        public Dessert(string name, string description, double prices, List<Ingredient> ingredients) : base(name, description, prices, ingredients) { }
        public override string Info()
        {
            return "";
        }
    }
}