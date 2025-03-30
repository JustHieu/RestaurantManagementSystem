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
    public partial class foodItemUC : UserControl
    {
        public string FoodName { get; private set; }
        public string FoodPrice { get; private set; }

        // Event khi nhấn nút "Thêm"
        public event EventHandler OnAddClicked;
        public foodItemUC()
        {
            InitializeComponent();
            bntAdd.MouseEnter += BntAdd_MouseEnter;
            bntAdd.MouseLeave += BntAdd_MouseLeave;
        }
        private void BntAdd_MouseEnter(object sender, EventArgs e)
        {

            bntAdd.FillColor = Color.Gray;
        }

        private void BntAdd_MouseLeave(object sender, EventArgs e)
        {
            bntAdd.FillColor = Color.DarkGray;
        }
        public void SetData(string name, string description, string price, Image image)
        {
            FoodName = name;
            FoodPrice = price;
            lblDescription.Text = description;
            lblName.Text = name;
            lblPrice.Text = price;
            pictureBox.Image = image;
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            OnAddClicked?.Invoke(this, EventArgs.Empty);
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
