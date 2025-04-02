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
        public menuUC()
        {
            InitializeComponent();
            LoadStartersItems();
            LoadMainDishesItems();
            LoadBeverageItems();
        }
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=RestaurantDB;Persist Security Info=True;User ID=sa;Password=123";

        private void LoadStartersItems()
        {
            LoadFoodItems("SELECT Name, Description, Price FROM Starters", flowLayoutPanelStarters);
        }

        private void LoadMainDishesItems()
        {
            LoadFoodItems("SELECT Name, Description, Price FROM MainDishes", flowLayoutPanelMainDishes);
        }
        private void LoadBeverageItems()
        {
            LoadFoodItems("SELECT Name, Description, Price FROM Beverage", flowLayoutPanelBeverage);
        }

        private void LoadFoodItems(string query, FlowLayoutPanel panel)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    panel.Controls.Clear(); // Xóa các item cũ trước khi load mới

                    while (reader.Read())
                    {
                        string name = reader["Name"].ToString();
                        string description = reader["Description"].ToString();
                        string price = reader["Price"].ToString();

                        foodItemMiniUC item = new foodItemMiniUC();
                        item.SetData(name, description, "$" + price);
                        panel.Controls.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
