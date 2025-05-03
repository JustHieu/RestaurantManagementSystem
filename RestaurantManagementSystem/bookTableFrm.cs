using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace RestaurantManagementSystem
{
    public partial class bookTableFrm : Form
    {
        private HashSet<int> existingDishIDs = new HashSet<int>();
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
            Database db = new Database();
            string connectionString = db.Connectstring();
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
            Database db = new Database();
            string connectionString = db.Connectstring();
            string query  = @"
                           SELECT d.Id, d.Name, SUM(td.quantity) AS quantity, SUM(td.price) AS totalPrice
                            FROM TableDetail td
                            JOIN Dish d ON td.dishID = d.Id
                            WHERE td.idTable = @TableID AND td.idBooking = @idBooking
                            GROUP BY d.Id, d.Name
                            ";
                                    

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
                        decimal totalPrice = reader.GetDecimal(3);
                        decimal unitPrice = totalPrice / quantity; 

                        foodOrderUC orderItem = new foodOrderUC();
                        orderItem.SetData(dishID, name, unitPrice, quantity); 
                        showPanel.Controls.Add(orderItem);
                        

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
            Database db = new Database();
            string connectionString = db.Connectstring();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // 1. Kiểm tra xem món đã tồn tại chưa
                    string checkQuery = @"SELECT quantity FROM TableDetail 
                                  WHERE idBooking = @idBooking AND idTable = @idTable AND dishID = @dishID";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@idBooking", idBooking);
                    checkCmd.Parameters.AddWithValue("@idTable", tableId);
                    checkCmd.Parameters.AddWithValue("@dishID", item.DishID);

                    object result = checkCmd.ExecuteScalar();

                    if (result != null) // Đã tồn tại → cộng dồn
                    {
                        int oldQuantity = Convert.ToInt32(result);
                        int newQuantity = oldQuantity + item.Quantity;

                        string updateQuery = @"UPDATE TableDetail 
                                       SET quantity = @quantity, price = @price 
                                       WHERE idBooking = @idBooking AND idTable = @idTable AND dishID = @dishID";

                        SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@quantity", newQuantity);
                        updateCmd.Parameters.AddWithValue("@price", newQuantity * item.Price);
                        updateCmd.Parameters.AddWithValue("@idBooking", idBooking);
                        updateCmd.Parameters.AddWithValue("@idTable", tableId);
                        updateCmd.Parameters.AddWithValue("@dishID", item.DishID);
                        updateCmd.ExecuteNonQuery();
                    }
                    else // Chưa có → thêm mới
                    {
                        string insertQuery = @"INSERT INTO TableDetail 
                    (idBooking, idTable, dishID, quantity, price) 
                    VALUES (@idBooking, @idTable, @dishID, @quantity, @price)";
                        SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                        insertCmd.Parameters.AddWithValue("@idBooking", idBooking);
                        insertCmd.Parameters.AddWithValue("@idTable", tableId);
                        insertCmd.Parameters.AddWithValue("@dishID", item.DishID);
                        insertCmd.Parameters.AddWithValue("@quantity", item.Quantity);
                        insertCmd.Parameters.AddWithValue("@price", item.Quantity * item.Price);
                        insertCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi lưu món ăn: " + ex.Message);
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
                if (!existingDishIDs.Contains(orderItem.DishID))
                {
                    SaveOrderToDatabase(orderItem);
                    UpdateDishSold(orderItem.DishID, orderItem.Quantity);
                }
            }
            orderPanel.Controls.Clear();
            LoadOrderDetails(); // Cập nhật lại showPanel sau khi thêm món

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UpdateDishSold(int dishID, int quantity)
        {
            Database db = new Database();
            string connectionString = db.Connectstring();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Kiểm tra nếu món ăn đã tồn tại trong bảng DishSold
                    string checkQuery = "SELECT TotalQuantity FROM DishSold WHERE DishID = @dishID";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@dishID", dishID);
                    object result = checkCmd.ExecuteScalar();

                    if (result != null)  // Đã tồn tại -> cập nhật số lượng
                    {
                        int currentQuantity = Convert.ToInt32(result);
                        string updateQuery = "UPDATE DishSold SET TotalQuantity = @newQuantity WHERE DishID = @dishID";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@newQuantity", currentQuantity + quantity);
                        updateCmd.Parameters.AddWithValue("@dishID", dishID);
                        updateCmd.ExecuteNonQuery();
                    }
                    else  // Chưa có -> thêm mới
                    {
                        string insertQuery = "INSERT INTO DishSold (DishID, TotalQuantity) VALUES (@dishID, @quantity)";
                        SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                        insertCmd.Parameters.AddWithValue("@dishID", dishID);
                        insertCmd.Parameters.AddWithValue("@quantity", quantity);
                        insertCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật DishSold: " + ex.Message);
            }
        }


    }
}
