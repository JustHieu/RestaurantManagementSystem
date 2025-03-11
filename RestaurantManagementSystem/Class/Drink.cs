using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;

namespace RestaurantManagementSystem
{
    public class Drink : Food
    {
        public Drink(string name, string description, double prices, List<Ingredient> ingredients): base(name, description, prices, ingredients) { }
        public override string Info()
        {
            return "";
        }
    }
}