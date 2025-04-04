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

        private string connectionString = "Data Source=.;Initial Catalog=RestaurantDB;Persist Security Info=True;User ID=sa;Password=123";


        private void startersButton_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            startersButton.FillColor = Color.FromArgb(255, 128, 0);
            LoadFoodItems("SELECT Name, Description, Price, Picture FROM Starters", foodFlowLayoutPanel);
        }

        private void mainDishesButton_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            mainDishesButton.FillColor = Color.FromArgb(255, 128, 0);
            LoadFoodItems("SELECT Name, Description, Price, Picture FROM MainDishes", foodFlowLayoutPanel);
        }

        private void beverageButton_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            beverageButton.FillColor = Color.FromArgb(255, 128, 0);
            LoadFoodItems("SELECT Name, Description, Price, Picture FROM Beverage", foodFlowLayoutPanel);
        }
        private void ResetButtonColors()
        {
            startersButton.FillColor = Color.FromArgb(20, 28, 38);
            mainDishesButton.FillColor = Color.FromArgb(20, 28, 38);
            beverageButton.FillColor = Color.FromArgb(20, 28, 38);

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

                    panel.Controls.Clear();

                    //while (reader.Read())
                    //{
                    //    string name = reader["Name"].ToString();
                    //    string description = reader["Description"].ToString();
                    //    string price = reader["Price"].ToString();
                    //    string image = reader["Image"].ToString();
                    //    string imagePath = Path.Combine(Application.StartupPath, "Images", image);
                    //    Image img = Image.FromFile(imagePath);

                    //    foodItemUC item = new foodItemUC();
                    //    item.SetData(name, description, price + "$", img);
                    //    item.OnAddClicked += FoodItem_OnAddClicked;
                    //    panel.Controls.Add(item);

                    //}
                    while (reader.Read())
                    {
                        string name = reader["Name"].ToString();
                        string description = reader["Description"].ToString();
                        string price = reader["Price"].ToString();
                        string imageFileName = reader["Picture"].ToString();

                        // Đường dẫn ảnh tương đối
                        string imagePath = Path.Combine(Application.StartupPath, "Images", imageFileName);

                        try
                        {
                            Image img = Image.FromFile(imagePath);

                            foodItemUC item = new foodItemUC();
                            item.SetData(name, description, price + "$", img);
                            item.OnAddClicked += FoodItem_OnAddClicked;
                            panel.Controls.Add(item);
                        }
                        catch (FileNotFoundException)
                        {
                            MessageBox.Show($"Không tìm thấy hình ảnh tại đường dẫn: {imagePath}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FoodItem_OnAddClicked(object sender, EventArgs e)
        {

            foodItemUC item = sender as foodItemUC;
            if (item != null)
            {
                string foodName = item.FoodName;
                double price = double.Parse(item.FoodPrice.Replace("$", ""));
                //orderFlowLayoutPanel.ControlAdded 
                //using (SqlConnection conn = new SqlConnection(connectionString))
                //{
                //    conn.Open();
                //    // Kiểm tra món đã tồn tại trong giỏ hàng chưa
                //    string checkQuery = "SELECT Quantity FROM OrderDetails WHERE OrderID = @OrderID AND FoodName = @FoodName";
                //    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                //    checkCmd.Parameters.AddWithValue("@OrderID", currentOrderID);
                //    checkCmd.Parameters.AddWithValue("@FoodName", foodName);

                //    object result = checkCmd.ExecuteScalar();

                //    if (result != null) // Nếu món đã có -> Cập nhật số lượng
                //    {
                //        string updateQuery = "UPDATE OrderDetails SET Quantity = Quantity + 1 WHERE OrderID = @OrderID AND FoodName = @FoodName";
                //        SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                //        updateCmd.Parameters.AddWithValue("@OrderID", currentOrderID);
                //        updateCmd.Parameters.AddWithValue("@FoodName", foodName);
                //        updateCmd.ExecuteNonQuery();
                //    }
                //    else // Nếu chưa có -> Thêm mới
                //    {
                //        string insertQuery = "INSERT INTO OrderDetails (OrderID, FoodName, Price, Quantity) VALUES (@OrderID, @FoodName, @Price, 1)";
                //        SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                //        insertCmd.Parameters.AddWithValue("@OrderID", currentOrderID);
                //        insertCmd.Parameters.AddWithValue("@FoodName", foodName);
                //        insertCmd.Parameters.AddWithValue("@Price", price);
                //        insertCmd.ExecuteNonQuery();
                //    }
                //}
            }
        }

        private void deleteAllButton_Click(object sender, EventArgs e)
        {
            orderFlowLayoutPanel.Controls.Clear();
        }

        private void completeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
