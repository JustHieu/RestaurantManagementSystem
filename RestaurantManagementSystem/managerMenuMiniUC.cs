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
    public partial class managerMenuMiniUC : UserControl
    {
        public managerMenuMiniUC()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void managerMenuMiniUC_Load(object sender, EventArgs e)
        {

        }
        public void SetName(string name)
        {
            nameLabel.Text = name;
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            nameLabel.Dock = DockStyle.Fill;
        }

        public void SetPrice(string price)
        {
            priceLabel.Text = price;
        }

        public void SetIngredients(string ingredients)
        {
            ingredientLabel.Text = ingredients;
        }

        public void SetDishImage(Image image)
        {
            DishPictureBox.Image = image;
            DishPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
