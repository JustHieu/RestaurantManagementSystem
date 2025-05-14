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
        public void SetData(string ingredientName, decimal quantity, DateTime usedTime)
        {
            nameLabel.Text = ingredientName;
            quantityLabel.Text = quantity + "g";  // hoặc "ml"
            timeLabel.Text = usedTime.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
