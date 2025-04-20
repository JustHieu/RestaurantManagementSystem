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
    public partial class managerColdStorageUC : UserControl
    {
        
        public managerColdStorageUC()
        {
            InitializeComponent();
            SetupListView();
            LoadIngredients();
        }
        private void ingredientListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (ingredientListView.SelectedItems.Count > 0)
            {
                DisplayIngredientInformation(ingredientListView.SelectedItems[0]);
            }
        }
        private void DisplayIngredientInformation(ListViewItem item)
        {
             Database db = new Database();
            string connectionString = db.Connectstring();
            try
            {
                // Lấy ID từ item được chọn
                int selectedId = int.Parse(item.SubItems[0].Text);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Ingredient WHERE ID = @ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", selectedId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Gán dữ liệu lên các TextBox
                        idTextBox.Text = reader["ID"].ToString();
                        nameTextBox.Text = reader["Name"].ToString();
                        quantityTextBox.Text = reader["Quantity"].ToString();
                        priceTextBox.Text = reader["Price"].ToString();
                        /*importDateTimePicker.Value = Convert.ToDateTime(reader["ImportDate"]);
                        expiryDateTimePicker.Value = Convert.ToDateTime(reader["ExpiryDate"]);*/
                        placeImportTextBox.Text = reader["Original"].ToString();
                        contactTextBox.Text = reader["PhoneNumber"].ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị thông tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SetupListView()
        {
            ingredientListView.View = View.Details;
            ingredientListView.FullRowSelect = true;
            ingredientListView.GridLines = true;

            // Thêm các cột vào ListView
            ingredientListView.Columns.Add("ID", 100, HorizontalAlignment.Center);
            ingredientListView.Columns.Add("Name", 200, HorizontalAlignment.Center);
            ingredientListView.Columns.Add("Quantity (g)", 150, HorizontalAlignment.Center);
            ingredientListView.Columns.Add("Price ($)", 150, HorizontalAlignment.Center);
            ingredientListView.Columns.Add("Original", 200, HorizontalAlignment.Center);
            ingredientListView.Columns.Add("Phone Number", 150, HorizontalAlignment.Center);
        }

        // Hàm tải nguyên liệu lên ListView
        private void LoadIngredients()
        {
            Database db = new Database();
            string connectionString = db.Connectstring();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Id, Name, Quantity, Price, Original, PhoneNumber FROM Ingredient";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    ingredientListView.Items.Clear(); // Xóa dữ liệu cũ trước khi tải mới

                    while (reader.Read())
                    {
                        // Lấy dữ liệu từ cơ sở dữ liệu
                        string id = reader["Id"].ToString();
                        string name = reader["Name"].ToString();
                        string quantity = reader["Quantity"].ToString();
                        string price = reader["Price"].ToString();
                        string original = reader["Original"].ToString();
                        string phoneNumber = reader["PhoneNumber"].ToString();

                        // Tạo một dòng mới trong ListView
                        ListViewItem item = new ListViewItem(id);
                        item.SubItems.Add(name);
                        item.SubItems.Add(quantity);
                        item.SubItems.Add(price);
                        item.SubItems.Add(original);
                        item.SubItems.Add(phoneNumber);

                        // Thêm dòng vào ListView
                        ingredientListView.Items.Add(item);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải nguyên liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
             Database db = new Database();
            string connectionString = db.Connectstring();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Ingredient (Name, Quantity, Price, Original, PhoneNumber) VALUES (@Name, @Quantity, @Price, @Original, @PhoneNumber)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", nameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Quantity", decimal.Parse(quantityTextBox.Text));
                    cmd.Parameters.AddWithValue("@Price", decimal.Parse(priceTextBox.Text));
                    cmd.Parameters.AddWithValue("@Original", placeImportTextBox.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", contactTextBox.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm nguyên liệu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadIngredients();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm nguyên liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void ClearFields()
        {
            nameTextBox.Text = "";
            quantityTextBox.Text = "";
            priceTextBox.Text = "";
            placeImportTextBox .Text = "";
            contactTextBox.Text = "";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (ingredientListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Database db = new Database();
            string connectionString = db.Connectstring();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    int selectedId = int.Parse(ingredientListView.SelectedItems[0].Text);
                    string query = "DELETE FROM Ingredient WHERE Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", selectedId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa nguyên liệu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadIngredients();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa nguyên liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void managerColdStorageUC_Load(object sender, EventArgs e)
        {
            LoadIngredients();
            ingredientListView.MouseClick += ingredientListView_MouseClick;
        }
    }
}
