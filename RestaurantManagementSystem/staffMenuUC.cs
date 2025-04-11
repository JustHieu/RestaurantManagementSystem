using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace RestaurantManagementSystem
{
    public partial class staffMenuUC : UserControl
    {
        public staffMenuUC()
        {
            InitializeComponent();
            startersButton_Click(null, EventArgs.Empty);
            //arrangeComboBox.SelectedIndex = 0;
        }

        private string connectionString = "Data Source=.;Initial Catalog=RestaurantData;Persist Security Info=True;User ID=sa;Password=123";


        private void startersButton_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            startersButton.FillColor = Color.FromArgb(255, 128, 0);
            //LoadFoodItems("SELECT Name, Description, Price, Picture FROM Starters", foodFlowLayoutPanel);
        }

        private void mainDishesButton_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            mainDishesButton.FillColor = Color.FromArgb(255, 128, 0);
            //LoadFoodItems("SELECT Name, Description, Price, Picture FROM MainDishes", foodFlowLayoutPanel);
        }

        private void beverageButton_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            beverageButton.FillColor = Color.FromArgb(255, 128, 0);
            //LoadFoodItems("SELECT Name, Description, Price, Picture FROM Beverage", foodFlowLayoutPanel);
        }
        private void ResetButtonColors()
        {
            startersButton.FillColor = Color.FromArgb(20, 28, 38);
            mainDishesButton.FillColor = Color.FromArgb(20, 28, 38);
            beverageButton.FillColor = Color.FromArgb(20, 28, 38);

        }
        private void LoadFoodItems(string query, FlowLayoutPanel panel)
        {
           
        }
        private void FoodItem_OnAddClicked(object sender, EventArgs e)
        {

           
            
        }

        private void deleteAllButton_Click(object sender, EventArgs e)
        {
            orderFlowLayoutPanel.Controls.Clear();
        }

        private void completeButton_Click(object sender, EventArgs e)
        {

        }

        private void staffMenuUC_Load(object sender, EventArgs e)
        {

        }
    }
}
