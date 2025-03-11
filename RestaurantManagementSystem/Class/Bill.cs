using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;

namespace RestaurantManagementSystem
{
    public class Bill
    {
        private string id;
        private string idCustomer;
        private string tableNumber;
        private double totalAmount;

        public string Id { get => id; set => id = value; }
        public string TableNumber { get => tableNumber; set => tableNumber = value; }
        public double TotalAmount { get => totalAmount; set => totalAmount = value; }
        public string IdCustomer { get => idCustomer; set => idCustomer = value; }
    }
}