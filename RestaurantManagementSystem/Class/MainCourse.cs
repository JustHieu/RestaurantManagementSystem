using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace RestaurantManagementSystem
{
    public class MainCourse : Food
    {
        public MainCourse(string name, string description, double prices, List<Ingredient> ingredients) : base(name, description, prices, ingredients) { }
        public override string Info()
        {
            return "";
        }

    }
}