using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    
    public partial class foodOrderUC : UserControl
    {
        public string FoodName { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }
        public int DishID { get; private set; }
        public event EventHandler OnDeleteFood;
        public foodOrderUC()
        {
            InitializeComponent();
        }
        public void SetData(int dishID, string name, decimal price, int quantity)
        {
            DishID = dishID;
            FoodName = name;
            Price = price;
            Quantity = quantity;

            nameLabel.Text = name;
            priceLabel.Text = (price * quantity).ToString("C");
            quantityLabel.Text = quantity.ToString();
        }

        public void UpdateQuantity(int additionalQuantity)
        {
            Quantity += additionalQuantity;
            priceLabel.Text = (Price * Quantity).ToString("C");
            quantityLabel.Text = Quantity.ToString();
        }

        private void foodOrderUC_Load(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            OnDeleteFood?.Invoke(this, EventArgs.Empty);
        }
    }
}
