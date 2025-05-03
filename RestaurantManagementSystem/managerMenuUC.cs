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
using System.IO;
using System.Windows.Input;


namespace RestaurantManagementSystem
{
    public partial class managerMenuUC : UserControl
    {
        Database db = new Database();
        
        private string imagePath = "";
        private int selectedDishId = -1;  

        public managerMenuUC()
        {
            InitializeComponent();
            LoadMenuItems();
        }

      
        private void LoadMenuItems(string keyword = "")
        {
            string connectionString = db.Connectstring();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Id, Name, Descrip, Price, Picture, Type FROM Dish";
                    if (!string.IsNullOrEmpty(keyword))
                    {
                        query += " WHERE Name LIKE @Keyword";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);

                  
                    if (!string.IsNullOrEmpty(keyword))
                    {
                        cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                    }

                    SqlDataReader reader = cmd.ExecuteReader();
                    menuPanel.Controls.Clear();

                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["Id"]);
                        string name = reader["Name"].ToString();
                        string description = reader["Descrip"].ToString();
                        string price = reader["Price"].ToString();
                        string picturePath = reader["Picture"].ToString();
                        string dishType = reader["Type"].ToString();

                        managerMenuMiniUC item = new managerMenuMiniUC();
                        item.Tag = id;
                        item.SetName(name);
                        item.SetPrice("$" + price);
                        item.SetIngredients(description);

                        item.Click += (s, e) =>
                        {
                            selectedDishId = (int)item.Tag;
                            idTextBox.Text = item.Tag.ToString();
                            nameTextBox.Text = name;
                            descriptionTextBox.Text = description;
                            priceTextBox.Text = price;
                            imagePath = picturePath;
                            typeComboBox.SelectedItem = dishType;

                            if (File.Exists(picturePath))
                            {
                                dishImage.Image = Image.FromFile(picturePath);
                                dishImage.SizeMode = PictureBoxSizeMode.StretchImage;
                            }

                            MessageBox.Show("Đã chọn món: " + name + " (ID: " + selectedDishId + ")");
                        };

                        if (File.Exists(picturePath))
                        {
                            item.SetDishImage(Image.FromFile(picturePath));
                        }

                        menuPanel.Controls.Add(item);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string connectionString = db.Connectstring();
            string dishType = typeComboBox.SelectedItem.ToString();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Dish (Name, Descrip, Price, Picture, Type) VALUES (@Name, @Descrip, @Price, @Picture, @Type)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", nameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Descrip", descriptionTextBox.Text);
                    cmd.Parameters.AddWithValue("@Price", decimal.Parse(priceTextBox.Text));
                    cmd.Parameters.AddWithValue("@Picture", imagePath);
                    cmd.Parameters.AddWithValue("@Type", dishType);

                    cmd.ExecuteNonQuery();

                    string getIdQuery = "SELECT TOP 1 Id FROM Dish ORDER BY Id DESC";
                    SqlCommand getIdCmd = new SqlCommand(getIdQuery, conn);
                    int newDishId = (int)getIdCmd.ExecuteScalar();

                    string insertDishSold = "INSERT INTO DishSold (DishID, TotalQuantity) VALUES (@DishID, 0)";
                    SqlCommand insertCmd = new SqlCommand(insertDishSold, conn);
                    insertCmd.Parameters.AddWithValue("@DishID", newDishId);
                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm món ăn mới thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadMenuItems();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm món ăn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (selectedDishId == -1)
            {
                MessageBox.Show("Vui lòng chọn món ăn cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = db.Connectstring();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    
                    string deleteIngredientsQuery = "DELETE FROM DishIngredientAssignment WHERE DishID = @Id";
                    SqlCommand deleteIngredientsCmd = new SqlCommand(deleteIngredientsQuery, conn);
                    deleteIngredientsCmd.Parameters.AddWithValue("@Id", selectedDishId);
                    deleteIngredientsCmd.ExecuteNonQuery();

                  
                    string deleteDishSoldQuery = "DELETE FROM DishSold WHERE DishID = @Id";
                    SqlCommand deleteDishSoldCmd = new SqlCommand(deleteDishSoldQuery, conn);
                    deleteDishSoldCmd.Parameters.AddWithValue("@Id", selectedDishId);
                    deleteDishSoldCmd.ExecuteNonQuery();

                    
                    string deleteDishQuery = "DELETE FROM Dish WHERE Id = @Id";
                    SqlCommand deleteDishCmd = new SqlCommand(deleteDishQuery, conn);
                    deleteDishCmd.Parameters.AddWithValue("@Id", selectedDishId);

                    int rowsAffected = deleteDishCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa món ăn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        LoadMenuItems();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa món ăn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void changeButton_Click(object sender, EventArgs e)
        {
            string connectionString = db.Connectstring();
            string dishType = typeComboBox.SelectedItem.ToString();
            if (selectedDishId == -1)
            {
                MessageBox.Show("Vui lòng chọn món ăn cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Dish SET Name = @Name, Descrip = @Descrip, Price = @Price, Picture = @Picture, Type = @Type WHERE Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", nameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Descrip", descriptionTextBox.Text);
                    cmd.Parameters.AddWithValue("@Price", decimal.Parse(priceTextBox.Text));
                    cmd.Parameters.AddWithValue("@Picture", imagePath);
                    cmd.Parameters.AddWithValue("@Id", selectedDishId);
                    cmd.Parameters.AddWithValue("@Type", dishType);
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Cập nhật món ăn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();  
                    LoadMenuItems();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật món ăn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        private void ClearFields()
        {
            nameTextBox.Text = "";
            descriptionTextBox.Text = "";
            priceTextBox.Text = "";
            dishImage.Image = null;
            imagePath = "";
            selectedDishId = -1;
        }

        private void managerMenuUC_Load(object sender, EventArgs e)
        {

        }

        private void seachBtn_Click(object sender, EventArgs e)
        {
            string keyword = searchTextBox.Text.Trim();
            LoadMenuItems(keyword);
        }

        private void cookingIngredientsButton_Click(object sender, EventArgs e)
        {
            if (selectedDishId == -1)
            {
                MessageBox.Show("Vui lòng chọn một món ăn trước!");
                return;
            }

            cookingIngredientsForm editor = new cookingIngredientsForm(selectedDishId);
            editor.ShowDialog();

        }

        private void insertImageButton_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Chọn ảnh món ăn",
                Filter = "Hình ảnh|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                dishImage.Image = Image.FromFile(imagePath);
                dishImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void menuPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
