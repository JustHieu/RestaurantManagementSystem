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
        
        

        public bestSellerUC()
        {
            InitializeComponent();
        }
        public string DishName
        {
            get => nameLabel.Text;
            set => nameLabel.Text = value;
        }

        public string DishPrice
        {
            get => priceLabel.Text;
            set => priceLabel.Text = value;
        }

        private void bestSellerUC_Load(object sender, EventArgs e)
        {

        }
    }
}
