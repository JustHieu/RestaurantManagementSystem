using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RestaurantManagementSystem
{
    public partial class foodItemUC : UserControl
    {
        public string FoodName { get; private set; }
        public decimal FoodPrice { get; private set; }
        public int DishID { get; private set; }

        public event EventHandler OnAddFood;


        public foodItemUC()
        {
            InitializeComponent();
            addBtn.MouseEnter += BntAdd_MouseEnter;
            addBtn.MouseLeave += BntAdd_MouseLeave;
        }
        private void BntAdd_MouseEnter(object sender, EventArgs e)
        {

            addBtn.FillColor = Color.Gray;
        }

        private void BntAdd_MouseLeave(object sender, EventArgs e)
        {
            addBtn.FillColor = Color.DarkGray;
        }
        public void SetData(int dishID, string name, string description, decimal price, string imagePath)
        {
            DishID = dishID;
            FoodName = name;
            FoodPrice = price;

            nameLabel.Text = name;
            descripLabel.Text = description;
            priceLabel.Text = price.ToString("C");

            try
            {
                if (File.Exists(imagePath))
                {
                    dishImage.Image = Image.FromFile(imagePath);
                }
                else
                {
                    //dishImage.Image = Properties.Resources.defaultImage;
                }
            }
            catch
            {
                //dishImage.Image = Properties.Resources.defaultImage;
            }
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

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void foodItemUC_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
            OnAddFood?.Invoke(this, EventArgs.Empty);
        }
    }
}
