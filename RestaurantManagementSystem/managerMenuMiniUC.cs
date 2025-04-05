using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            DishPictureBox.Click += (s, e) => this.OnClick(e);
            nameLabel.Click += (s, e) => this.OnClick(e);
            priceLabel.Click += (s, e) => this.OnClick(e);
            ingredientLabel.Click += (s, e) => this.OnClick(e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void managerMenuMiniUC_Load(object sender, EventArgs e)
        {
            MakePictureBoxRoundedCorners(DishPictureBox, 19);
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

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nameLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void ingredientLabel_Click(object sender, EventArgs e)
        {

        }
        private GraphicsPath GetRoundedRect(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;  // Tính đường kính cho góc bo tròn

            // Vẽ cung tròn cho góc trái trên
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            // Vẽ cung tròn cho góc phải trên
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            // Vẽ đường thẳng từ cuối cung góc phải trên xuống góc dưới bên phải
            path.AddLine(rect.Right, rect.Y + radius, rect.Right, rect.Bottom);
            // Vẽ đường thẳng từ góc dưới bên phải sang góc dưới bên trái
            path.AddLine(rect.Right, rect.Bottom, rect.X, rect.Bottom);
            // Vẽ đường thẳng từ góc dưới bên trái lên cuối cung góc trái trên
            path.AddLine(rect.X, rect.Bottom, rect.X, rect.Y + radius);
            path.CloseFigure();
            return path;
        }

        private void MakePictureBoxRoundedCorners(PictureBox pictureBox, int cornerRadius)
        {
            // Tạo vùng bo góc và gán cho PictureBox
            pictureBox.Region = new Region(GetRoundedRect(new Rectangle(0, 0, pictureBox.Width, pictureBox.Height), cornerRadius));
        }


    }
}
