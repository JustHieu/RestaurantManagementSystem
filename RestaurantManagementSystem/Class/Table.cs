using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManagementSystem
{
    public class Table
    {

        private int idTable;
        private bool stateTable;
        private List<Food> foodInTable;
        public bool StateTable { get => stateTable; set => stateTable = value; }
        public int IdTable { get => idTable; set => idTable = value; }
        public List<Food> FoodInTable { get => foodInTable; set => foodInTable = value; }
    }
}