using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManagementSystem
{
    public class Menu
    {
        private List<Food> foods;

        public List<Food> Foods { get => foods; set => foods = value; }
        public string ShowMenu()
        {
            string menu = "";
            foreach(Food food in foods)
            {
                menu += $"Name: {food.Name.ToString()} - Price: {food.Prices.ToString()}\n";
            }
            return menu;
        }
    }
}