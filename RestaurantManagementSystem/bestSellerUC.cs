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
    public partial class bestSellerUC : UserControl
    {
        public void SetData(string name, decimal price)
        {
            nameLabel.Text = name;
            priceLabel.Text = $"{price}$";
        }

        public bestSellerUC()
        {
            InitializeComponent();
        }

        private void bestSellerUC_Load(object sender, EventArgs e)
        {

        }
    }
}
