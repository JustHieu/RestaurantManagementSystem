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
    public partial class usedIngredientUC : UserControl
    {
        public usedIngredientUC()
        {
            InitializeComponent();
        }
        public void SetData(string ingredientName, decimal quantity)
        {
            nameLabel.Text = ingredientName;
            quantityLabel.Text = quantity + "g";  // hoặc "ml", tuỳ loại
        }


        private void usedIngredientUC_Load(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
