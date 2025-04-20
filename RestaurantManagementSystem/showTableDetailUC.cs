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
        public decimal TotalPrice { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }
        public string FoodName { get; private set; }

        public showTableDetailUC()
        {
            InitializeComponent();
        }

        private void showTableDetailUC_Load(object sender, EventArgs e)
        {

        }
        public void SetData(string name, int quantity, decimal price)
        {
            Quantity = quantity;
            Price = price;
            FoodName = name;
            nameLabel.Text = name;
            quantityLabel.Text = quantity.ToString();  // Cập nhật số lượng
            priceLabel.Text = price.ToString("C");
            TotalPrice = price * quantity;
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
