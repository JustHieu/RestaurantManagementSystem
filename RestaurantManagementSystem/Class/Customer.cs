using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManagementSystem
{
    public class Customer
    {
        private string name;
        private string phone;
        private List<Food> dishes;
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public List<Food> Dishes { get => dishes; set => dishes = value; }

        public Customer(string name, string phone, List<Food> dishes = null)
        {
            this.Name = name;
            this.Phone = phone;
            this.dishes = dishes;
            Dishes = dishes;
        }
        public override string ToString() {
            return $"Name: {this.Name} - Dishes: {this.Dishes}";
        }
    }
}