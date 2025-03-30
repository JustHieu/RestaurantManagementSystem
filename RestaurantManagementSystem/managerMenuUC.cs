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
    public partial class managerMenuUC : UserControl
    {
        public managerMenuUC()
        {
            InitializeComponent();
        }

        private void cookingIngredientsButton_Click(object sender, EventArgs e)
        {
            cookingIngredientsForm form = new cookingIngredientsForm();
            form.Show();
        }
        private void insertImageButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Chọn ảnh";
            openFileDialog1.Filter = "Hình ảnh|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
