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
        private class IngredientUsage
        {
            public int IngredientId { get; set; }
            public string IngredientName { get; set; }
            public decimal TotalQuantityNeeded { get; set; }
        }

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
            Database db = new Database();
            string connectionString = db.Connectstring();
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
            // 1. Tổng hợp nguyên liệu cần cho toàn bộ đơn hàng
            List<IngredientUsage> totalUsages = new List<IngredientUsage>();
            Database db = new Database();
            string connectionString = db.Connectstring();

            foreach (foodOrderUC orderItem in orderPanel.Controls)
            {
                int dishId = orderItem.DishID;
                int quantityOrder = orderItem.Quantity;

                // Lấy danh sách nguyên liệu và số lượng cần cho từng món
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                SELECT DA.IngredientID, I.Name, DA.QuantityRequired
                FROM DishIngredientAssignment DA
                JOIN Ingredient I ON DA.IngredientID = I.Id
                WHERE DA.DishID = @DishID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@DishID", dishId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int ingrId = Convert.ToInt32(reader["IngredientID"]);
                            string ingrName = reader["Name"].ToString();
                            decimal qtyNeededForOne = Convert.ToDecimal(reader["QuantityRequired"]);
                            decimal qtyTotal = qtyNeededForOne * quantityOrder;

                            // Nếu đã có trong list thì cộng dồn
                            var exist = totalUsages.FirstOrDefault(x => x.IngredientId == ingrId);
                            if (exist == null)
                            {
                                totalUsages.Add(new IngredientUsage
                                {
                                    IngredientId = ingrId,
                                    IngredientName = ingrName,
                                    TotalQuantityNeeded = qtyTotal
                                });
                            }
                            else
                            {
                                exist.TotalQuantityNeeded += qtyTotal;
                            }
                        }
                    }
                }
            }

            // 2. Kiểm tra kho nguyên liệu
            List<string> notEnough = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                foreach (var usage in totalUsages)
                {
                    string query = "SELECT Quantity FROM Ingredient WHERE Id = @IngrID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IngrID", usage.IngredientId);
                    decimal currentQty = Convert.ToDecimal(cmd.ExecuteScalar());

                    if (currentQty < usage.TotalQuantityNeeded)
                    {
                        notEnough.Add($"{usage.IngredientName} (cần {usage.TotalQuantityNeeded}, còn {currentQty})");
                    }
                }
            }

            // 3. Nếu thiếu nguyên liệu, báo lỗi & không lưu đơn
            if (notEnough.Count > 0)
            {
                MessageBox.Show("Nguyên liệu không đủ: \n" + string.Join("\n", notEnough), "Thiếu nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Nếu đủ, trừ nguyên liệu và lưu order
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Trừ nguyên liệu
                    foreach (var usage in totalUsages)
                    {
                        string updateQuery = "UPDATE Ingredient SET Quantity = Quantity - @UsedQty WHERE Id = @IngrID";
                        SqlCommand cmd = new SqlCommand(updateQuery, conn, transaction);
                        cmd.Parameters.AddWithValue("@UsedQty", usage.TotalQuantityNeeded);
                        cmd.Parameters.AddWithValue("@IngrID", usage.IngredientId);
                        cmd.ExecuteNonQuery();
                    }

                    // Lưu chi tiết món ăn
                    foreach (foodOrderUC orderItem in orderPanel.Controls)
                    {
                        // Chỉ lưu nếu chưa lưu (tuỳ vào flow của bạn, tránh lưu lặp)
                        string insertQuery = @"INSERT INTO TableDetail (idBooking, idTable, dishID, quantity, price) 
                                      VALUES (@idBooking, @idTable, @dishID, @quantity, @price)";
                        SqlCommand cmd = new SqlCommand(insertQuery, conn, transaction);
                        cmd.Parameters.AddWithValue("@idBooking", idBooking);
                        cmd.Parameters.AddWithValue("@idTable", tableId);
                        cmd.Parameters.AddWithValue("@dishID", orderItem.DishID);
                        cmd.Parameters.AddWithValue("@quantity", orderItem.Quantity);
                        cmd.Parameters.AddWithValue("@price", orderItem.Price * orderItem.Quantity);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Đặt món thành công và trừ kho nguyên liệu!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    orderPanel.Controls.Clear();
                    // Cập nhật bảng DishSold (thống kê số lượng bán)
                    foreach (foodOrderUC orderItem in orderPanel.Controls)
                    {
                        string checkQuery = "SELECT COUNT(*) FROM DishSold WHERE DishID = @DishID";
                        SqlCommand checkCmd = new SqlCommand(checkQuery, conn, transaction);
                        checkCmd.Parameters.AddWithValue("@DishID", orderItem.DishID);
                        int exists = (int)checkCmd.ExecuteScalar();

                        if (exists > 0)
                        {
                            string updateSold = "UPDATE DishSold SET TotalQuantity = TotalQuantity + @Qty WHERE DishID = @DishID";
                            SqlCommand updateCmd = new SqlCommand(updateSold, conn, transaction);
                            updateCmd.Parameters.AddWithValue("@Qty", orderItem.Quantity);
                            updateCmd.Parameters.AddWithValue("@DishID", orderItem.DishID);
                            updateCmd.ExecuteNonQuery();
                        }
                        else
                        {
                            string insertSold = "INSERT INTO DishSold (DishID, TotalQuantity) VALUES (@DishID, @Qty)";
                            SqlCommand insertCmd = new SqlCommand(insertSold, conn, transaction);
                            insertCmd.Parameters.AddWithValue("@Qty", orderItem.Quantity);
                            insertCmd.Parameters.AddWithValue("@DishID", orderItem.DishID);
                            insertCmd.ExecuteNonQuery();
                        }
                    }

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi khi hoàn tất đơn hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    orderPanel.Controls.Clear();

                }

            }


        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void orderPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
