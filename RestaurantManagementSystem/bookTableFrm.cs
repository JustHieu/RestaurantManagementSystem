using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantManagementSystem
{
    public partial class bookTableFrm : Form
    {
        private int tableId;
        private int idBooking;
        public bookTableFrm(int idTable, int bookingId)
        {
            InitializeComponent();
            this.tableId = idTable;
            this.idBooking = bookingId;
            LoadOrderDetails();  // Load đúng thông tin của bàn
            LoadMenu();          // Load menu món ăn
        }

        private SqlDataReader GetMenuData()
        {
            string connectionString = "Data Source=.;Initial Catalog=RestaurantData;Persist Security Info=True;User ID=sa;Password=123";
            string query = "SELECT Id, Name, Descrip, Price, Picture FROM Dish";

            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
                return null;
            }
        }

        // Hàm load menu từ cơ sở dữ liệu
        private void LoadMenu()
        {
            menuPanel.Controls.Clear();
            SqlDataReader reader = GetMenuData();

            while (reader != null && reader.Read())
            {
                int dishID = reader.GetInt32(0);
                string name = reader.GetString(1);
                string descrip = reader.IsDBNull(2) ? "No description" : reader.GetString(2);
                decimal price = reader.GetDecimal(3);
                string imagePath = reader.IsDBNull(4) ? "default.jpg" : reader.GetString(4);

                foodItemUC item = new foodItemUC();
                item.SetData(dishID, name, descrip, price, imagePath);
                item.OnAddFood += (s, e) => AddToOrder(item);

                menuPanel.Controls.Add(item);
            }
            reader?.Close();
        }
        private void LoadOrderDetails()
        {
            string connectionString = "Data Source=.;Initial Catalog=RestaurantData;Persist Security Info=True;User ID=sa;Password=123";
            string query = "SELECT d.Id, d.Name, td.quantity, td.price " +
                           "FROM TableDetail td " +
                           "JOIN Dish d ON td.dishID = d.Id " +
                           "WHERE td.idTable = @TableID AND td.idBooking = @idBooking";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TableID", tableId);
                    cmd.Parameters.AddWithValue("@idBooking", idBooking);  // Thêm idBooking vào câu lệnh SQL

                    SqlDataReader reader = cmd.ExecuteReader();
                    orderPanel.Controls.Clear();

                    while (reader.Read())
                    {
                        int dishID = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        int quantity = reader.GetInt32(2);
                        decimal price = reader.GetDecimal(3);

                        // Tạo đối tượng foodOrderUC
                        foodOrderUC orderItem = new foodOrderUC();
                        orderItem.SetData(dishID, name, price, quantity);

                        // Thêm vào orderPanel
                        orderPanel.Controls.Add(orderItem);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading order details: " + ex.Message);
            }
        }

        private void AddToOrder(foodItemUC item)
        {
            foreach (foodOrderUC orderItem in orderPanel.Controls)
            {
                if (orderItem.FoodName == item.FoodName)
                {
                    orderItem.UpdateQuantity(1);
                    return;
                }
            }

            foodOrderUC newItem = new foodOrderUC();
            newItem.SetData(item.DishID, item.FoodName, item.FoodPrice, 1);
            newItem.OnDeleteFood += (s, e) => RemoveFromOrder(newItem);
            orderPanel.Controls.Add(newItem);
        }
        private void RemoveFromOrder(foodOrderUC item)
        {
            orderPanel.Controls.Remove(item);
            MessageBox.Show("Removed: " + item.FoodName);
        }
        // Hàm lưu món ăn vào cơ sở dữ liệu
        private void SaveOrderToDatabase(foodOrderUC item)
        {
            string connectionString = "Data Source=.;Initial Catalog=RestaurantData;Persist Security Info=True;User ID=sa;Password=123";
            string query = "INSERT INTO TableDetail (idBooking, idTable, dishID, quantity, price) " +
                           "VALUES (@idBooking, @idTable, @dishID, @quantity, @price)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Truyền đúng idBooking và idTable
                    cmd.Parameters.AddWithValue("@idBooking", idBooking);
                    cmd.Parameters.AddWithValue("@idTable", tableId);
                    cmd.Parameters.AddWithValue("@dishID", item.DishID);
                    cmd.Parameters.AddWithValue("@quantity", item.Quantity);
                    cmd.Parameters.AddWithValue("@price", item.Price * item.Quantity);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Order saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving order: " + ex.Message);
            }
        }


        // Nút tải lại menu
        private void btnLoadMenu_Click(object sender, EventArgs e)
        {
            LoadMenu();
        }

        private void menuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bookTableFrm_Load(object sender, EventArgs e)
        {

        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            foreach (foodOrderUC orderItem in orderPanel.Controls)
            {
                SaveOrderToDatabase(orderItem);  // Đảm bảo hàm này nhận đúng idBooking
            }
            MessageBox.Show("Order completed!");
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
