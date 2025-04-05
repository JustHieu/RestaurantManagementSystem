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

        // Chuỗi kết nối
        private string connectionString = "Data Source=.\\SQLExpress;Initial Catalog=RestaurantData;Persist Security Info=True;User ID=sa;Password=123";

        // Hàm tải món khai vị
        private void LoadStartersItems()
        {
            LoadFoodItems("SELECT Name, Descrip, Price FROM Dish WHERE Type = 'Start Dish'", flowLayoutPanelStarters);
        }

        // Hàm tải món chính
        private void LoadMainDishesItems()
        {
            LoadFoodItems("SELECT Name, Descrip, Price FROM Dish WHERE Type = 'Main Dish'", flowLayoutPanelMainDishes);
        }

        // Hàm tải đồ uống
        private void LoadBeverageItems()
        {
            LoadFoodItems("SELECT Name, Descrip, Price FROM Dish WHERE Type = 'Beverages'", flowLayoutPanelBeverage);
        }

        // Hàm tải món ăn vào FlowLayoutPanel
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
                        string description = reader["Descrip"].ToString(); // Đổi từ "Description" thành "Descrip"
                        string price = reader["Price"].ToString();

                        // Tạo đối tượng món ăn và hiển thị
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

        private void menuUC_Load(object sender, EventArgs e)
        {

        }
    }
}
