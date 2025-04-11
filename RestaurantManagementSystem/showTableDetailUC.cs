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
    public partial class showTableDetailUC : UserControl
    {
        public decimal TotalPrice { get; private set; }
        public showTableDetailUC()
        {
            InitializeComponent();
        }

        private void showTableDetailUC_Load(object sender, EventArgs e)
        {

        }
        public void SetData(string name, int quantity, decimal price)
        {
            nameLabel.Text = name;
            quantityLabel.Text = quantity.ToString();
            priceLabel.Text = price.ToString("C");
            TotalPrice = price * quantity;
        }
        public decimal GetTotalPrice()
        {
            return TotalPrice;
        }

    }
}
