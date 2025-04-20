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
        }

        private void completeButton_Click(object sender, EventArgs e)
        {

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
        private void AddToOrder(foodItemUC item)
        {
            bool itemExists = false;

            // Kiểm tra nếu món ăn đã có trong giỏ hàng (orderFlowLayoutPanel)
            foreach (Control control in orderFlowLayoutPanel.Controls)
            {
                if (control is showTableDetailUC orderItem && orderItem.FoodName == item.FoodName)
                {
                    // Nếu món ăn đã có, tăng số lượng lên
                    orderItem.UpdateQuantity(1);  // Tăng số lượng lên 1
                    itemExists = true;
                    break;
                }
            }

            // Nếu món ăn chưa có trong giỏ hàng, thêm vào giỏ hàng
            if (!itemExists)
            {
                showTableDetailUC newItem = new showTableDetailUC();
                newItem.SetData(item.FoodName, 1, item.FoodPrice);  // Số lượng ban đầu là 1
                orderFlowLayoutPanel.Controls.Add(newItem);
            }
        }


    }
}
