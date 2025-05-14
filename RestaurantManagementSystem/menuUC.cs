using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class menuUC : UserControl
    {
        Database db = new Database();
        public menuUC()
        {
            InitializeComponent();
            LoadStartersItems();
            LoadMainDishesItems();
            LoadBeverageItems();
        }

        private void LoadStartersItems()
        {
            LoadFoodItems("SELECT Name, Descrip, Price FROM Dish WHERE Type = 'Start Dish'", flowLayoutPanelStarters);
        }

        private void LoadMainDishesItems()
        {
            LoadFoodItems("SELECT Name, Descrip, Price FROM Dish WHERE Type = 'Main Dish'", flowLayoutPanelMainDishes);
        }

        private void LoadBeverageItems()
        {
            LoadFoodItems("SELECT Name, Descrip, Price FROM Dish WHERE Type = 'Beverages'", flowLayoutPanelBeverage);
        }

        private void LoadFoodItems(string query, FlowLayoutPanel panel)
        {
            string connectionString = db.Connectstring();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    panel.Controls.Clear();

                    while (reader.Read())
                    {
                        string name = reader["Name"].ToString();
                        string description = reader["Descrip"].ToString(); 
                        string price = reader["Price"].ToString();

                        foodItemMiniUC item = new foodItemMiniUC();
                        item.SetData(name, description, "$" + price);
                        panel.Controls.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data loading error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuUC_Load(object sender, EventArgs e)
        {

        }
    }
}
