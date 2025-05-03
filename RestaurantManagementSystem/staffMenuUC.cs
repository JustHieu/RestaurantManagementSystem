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

namespace RestaurantManagementSystem
{
    public partial class staffMenuUC : UserControl
    {
        Database db = new Database();
        public staffMenuUC()
        {
            InitializeComponent();
            startersButton_Click(null, EventArgs.Empty);
            //arrangeComboBox.SelectedIndex = 0;
            LoadMenuItems();
            LoadOccupiedTablesToComboBox();
        }

        

        private void startersButton_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            startersButton.FillColor = Color.FromArgb(255, 128, 0);
            LoadMenuItems("Start Dish", "Type");     
        }

        private void mainDishesButton_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            mainDishesButton.FillColor = Color.FromArgb(255, 128, 0);
            LoadMenuItems("Main Dish", "Type");
        }

        private void beverageButton_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            beverageButton.FillColor = Color.FromArgb(255, 128, 0);
            LoadMenuItems("Beverages", "Type");
        }
        private void ResetButtonColors()
        {
            startersButton.FillColor = Color.FromArgb(20, 28, 38);
            mainDishesButton.FillColor = Color.FromArgb(20, 28, 38);
            beverageButton.FillColor = Color.FromArgb(20, 28, 38);

        }
        private void LoadOccupiedTablesToComboBox()
        {
            tableCB.Items.Clear();

            string query = "SELECT idTable FROM Tables WHERE status = 'Full'";
            using (SqlConnection conn = new SqlConnection(db.Connectstring()))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tableCB.Items.Add(reader.GetInt32(0));  // Thêm ID bàn
                }
                reader.Close();
            }

            if (tableCB.Items.Count > 0)
                tableCB.SelectedIndex = 0;
        }

        private void LoadMenuItems(string keyword = "", string searchType = "Name")
        {
            string connectionString = db.Connectstring();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Dish";

                    // Kiểm tra searchType để quyết định lọc theo 'Type' hoặc 'Name'
                    if (!string.IsNullOrEmpty(keyword))
                    {
                        if (searchType == "Type")
                        {
                            query += " WHERE Type LIKE @Keyword";  // Lọc theo loại món ăn
                        }
                        else if (searchType == "Name")
                        {
                            query += " WHERE Name LIKE @Keyword";  // Lọc theo tên món ăn
                        }
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Thêm tham số tìm kiếm nếu có
                    if (!string.IsNullOrEmpty(keyword))
                    {
                        cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                    }

                    SqlDataReader reader = cmd.ExecuteReader();
                    foodFlowLayoutPanel.Controls.Clear();

                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["Id"]);
                        string name = reader["Name"].ToString();
                        string description = reader["Descrip"].ToString();
                        decimal price = Convert.ToDecimal(reader["Price"]);
                        string picturePath = reader["Picture"].ToString();
                        string dishType = reader["Type"].ToString();  // Lấy loại món ăn

                        // Tạo một UserControl cho mỗi món ăn
                        foodItemUC itemUC = new foodItemUC();
                        //showTableDetailUC itemAdd = new showTableDetailUC();
                        //itemAdd.SetData(name,1,price);
                        itemUC.SetData(id, name, description, price, picturePath);
                        itemUC.OnAddFood += (s, e) => AddToOrder(itemUC);

                        // Hiển thị món ăn lên giao diện
                        foodFlowLayoutPanel.Controls.Add(itemUC);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FoodItem_OnAddClicked(object sender, EventArgs e)
        {

           
            
        }

        private void deleteAllButton_Click(object sender, EventArgs e)
        {
            orderFlowLayoutPanel.Controls.Clear();
            orderFlowLayoutPanel.Controls.Clear();
            currentTotalAmount = 0;  // ✅ Reset tổng tiền
            totalLabel.Text = "0 $"; // ✅ Reset hiển thị
        }
        private int GetLatestBookingID(int tableId)
        {
            string query = "SELECT TOP 1 idBooking FROM BookingKey WHERE idTable = @tableId ORDER BY time DESC";
            using (SqlConnection conn = new SqlConnection(db.Connectstring()))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tableId", tableId);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }
        private int GetDishIDByName(string name)
        {
            string query = "SELECT Id FROM Dish WHERE Name = @Name";
            using (SqlConnection conn = new SqlConnection(db.Connectstring()))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }

        private void SaveDishToTableDetail(int bookingID, int tableID, showTableDetailUC item)
        {
            string query = "INSERT INTO TableDetail (idBooking, idTable, dishID, quantity, price) " +
                           "VALUES (@idBooking, @idTable, @dishID, @quantity, @price)";

            int dishID = GetDishIDByName(item.FoodName);
            if (dishID == -1) return;

            using (SqlConnection conn = new SqlConnection(db.Connectstring()))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idBooking", bookingID);
                cmd.Parameters.AddWithValue("@idTable", tableID);
                cmd.Parameters.AddWithValue("@dishID", dishID);
                cmd.Parameters.AddWithValue("@quantity", item.Quantity);
                cmd.Parameters.AddWithValue("@price", item.Price * item.Quantity);
                cmd.ExecuteNonQuery();
            }
        }
        private void UpdateDishSold(int dishID, int quantity)
        {
            string connectionString = db.Connectstring();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            IF EXISTS (SELECT 1 FROM DishSold WHERE DishID = @DishID)
                UPDATE DishSold SET TotalQuantity = TotalQuantity + @Qty WHERE DishID = @DishID
            ELSE
                INSERT INTO DishSold (DishID, TotalQuantity) VALUES (@DishID, @Qty)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DishID", dishID);
                cmd.Parameters.AddWithValue("@Qty", quantity);
                cmd.ExecuteNonQuery();
            }
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            if (tableCB.SelectedItem == null)
            {
                MessageBox.Show("Please select a table to add items.");
                return;
            }

            int selectedTableID = Convert.ToInt32(tableCB.SelectedItem);

            // Lấy idBooking mới nhất của bàn
            int bookingID = GetLatestBookingID(selectedTableID);
            if (bookingID == -1)
            {
                MessageBox.Show("No active booking found for this table.");
                return;
            }

            foreach (showTableDetailUC item in orderFlowLayoutPanel.Controls)
            {
                SaveDishToTableDetail(bookingID, selectedTableID, item);        
                UpdateDishSold(item.DishID, item.Quantity);                       
            }
           

            orderFlowLayoutPanel.Controls.Clear();
            MessageBox.Show("✅ Order updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            currentTotalAmount = 0;
            totalLabel.Text = "0 $";
        }

        private void staffMenuUC_Load(object sender, EventArgs e)
        {

        }

        private void seachButton_Click(object sender, EventArgs e)
        {
            string keyword = searchTextBox.Text.Trim();
            LoadMenuItems(keyword, "Name");
        }

        private void arrangeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = arrangeComboBox.SelectedItem.ToString();

            List<FoodItem> foodItems = GetFoodItems(); // Giả sử bạn có một hàm để lấy danh sách các món ăn

            if (selectedOption == "A -> Z")
            {
                // Sắp xếp theo tên từ A đến Z
                foodItems = foodItems.OrderBy(f => f.Name).ToList();
            }
            else if (selectedOption == "Z -> A")
            {
                // Sắp xếp theo tên từ Z đến A 
                foodItems = foodItems.OrderByDescending(f => f.Name).ToList();
            }

            // Cập nhật lại giao diện sau khi sắp xếp
            DisplayFoodItems(foodItems); // Giả sử bạn có một hàm để hiển thị các món ăn lên giao diện
        }
        private List<FoodItem> GetFoodItems()
        {
            List<FoodItem> foodItems = new List<FoodItem>();

            string connectionString = db.Connectstring();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Dish";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    FoodItem foodItem = new FoodItem
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        Description = reader["Descrip"].ToString(),
                        Price = Convert.ToDecimal(reader["Price"]),
                        PicturePath = reader["Picture"].ToString(),
                        Type = reader["Type"].ToString()
                    };
                    foodItems.Add(foodItem);
                }
                reader.Close();
            }
            return foodItems;
        }

        private void DisplayFoodItems(List<FoodItem> foodItems)
        {
            foodFlowLayoutPanel.Controls.Clear();

            foreach (var item in foodItems)
            {
                foodItemUC itemUC = new foodItemUC();
                itemUC.SetData(item.Id, item.Name, item.Description, item.Price, item.PicturePath);
                foodFlowLayoutPanel.Controls.Add(itemUC);
            }
        }
        private decimal currentTotalAmount = 0;

        private void AddToOrder(foodItemUC item)
        {
            bool itemExists = false;

            foreach (Control control in orderFlowLayoutPanel.Controls)
            {
                if (control is showTableDetailUC orderItem && orderItem.FoodName == item.FoodName)
                {
                    orderItem.UpdateQuantity(1);
                    currentTotalAmount += item.FoodPrice; // ✅ Cộng giá
                    itemExists = true;
                    break;
                }
            }

            if (!itemExists)
            {
                showTableDetailUC newItem = new showTableDetailUC();
                newItem.SetData(item.FoodName, 1, item.FoodPrice, item.DishID);
                orderFlowLayoutPanel.Controls.Add(newItem);
                currentTotalAmount += item.FoodPrice; // ✅ Cộng giá
            }

            totalLabel.Text = currentTotalAmount.ToString("C0");
        }
           
    }
}
