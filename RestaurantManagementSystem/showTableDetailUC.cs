using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class showTableDetailUC : UserControl
    {

        public decimal TotalPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string FoodName { get; set; }

        public showTableDetailUC()
        {
            InitializeComponent();
        }
        public int DishID { get; private set; }

        public void SetData(string name, int quantity, decimal price, int dishID)
        {
            FoodName = name;
            Quantity = quantity;
            Price = price;
            DishID = dishID; // gán ID món ăn
            nameLabel.Text = name;
            priceLabel.Text = $"{price:C}";
            quantityLabel.Text = quantity.ToString();
        }

        private void showTableDetailUC_Load(object sender, EventArgs e)
        {

        }
        public decimal GetTotalPrice()
        {
            return TotalPrice;
        }
        public void UpdateQuantity(int additionalQuantity)
        {
            Quantity += additionalQuantity;
            priceLabel.Text = (Price * Quantity).ToString("C"); // Cập nhật lại tổng giá
            quantityLabel.Text = Quantity.ToString();  // Cập nhật lại số lượng
            TotalPrice = Price * Quantity;  // Cập nhật lại giá trị tổng
        }

    }
}
