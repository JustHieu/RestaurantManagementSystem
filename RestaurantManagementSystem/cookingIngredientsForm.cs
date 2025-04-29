using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class cookingIngredientsForm : Form
    {
        private int dishID;
        private Database db = new Database();

        public cookingIngredientsForm(int dishID)
        {
            InitializeComponent();
            this.dishID = dishID;
            this.ingListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ingListView_MouseClick);

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetupListViews()
        {
            listView1.GridLines = true;
            ingListView.GridLines = true;

            listView1.View = View.Details;
            listView1.Columns.Clear();
            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Name", 150);
            listView1.Columns.Add("Quantity", 100);
            listView1.Columns.Add("Price", 100);

            ingListView.View = View.Details;
            ingListView.Columns.Clear();
            ingListView.Columns.Add("Ingredient ID", 100);
            ingListView.Columns.Add("Name", 150);
            ingListView.Columns.Add("Quantity Required", 100);
        }
        private void ingListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (ingListView.SelectedItems.Count > 0)
            {
                var selectedItem = ingListView.SelectedItems[0];

                string ingredientId = selectedItem.SubItems[0].Text;
                string ingredientName = selectedItem.SubItems[1].Text;
                string quantity = selectedItem.SubItems[2].Text;

            }
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string ingredientId = listView1.SelectedItems[0].SubItems[0].Text;
                string ingredientName = listView1.SelectedItems[0].SubItems[1].Text;

                string quantityStr = Microsoft.VisualBasic.Interaction.InputBox(
                    $"Nhập số lượng cần dùng cho '{ingredientName}':", "Số lượng", "1");

                if (int.TryParse(quantityStr, out int quantity) && quantity > 0)
                {
                    // Check nếu nguyên liệu đã có trong ingListView thì update số lượng
                    bool found = false;
                    foreach (ListViewItem existingItem in ingListView.Items)
                    {
                        if (existingItem.SubItems[0].Text == ingredientId)
                        {
                            existingItem.SubItems[2].Text = quantity.ToString();
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        ListViewItem item = new ListViewItem(ingredientId);
                        item.SubItems.Add(ingredientName);
                        item.SubItems.Add(quantity.ToString());
                        ingListView.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Số lượng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void cookingIngredientsForm_Load(object sender, EventArgs e)
        {
            SetupListViews();
            LoadAllIngredients();
            LoadAssignedIngredients();
        }

        private void LoadAllIngredients()
        {
            listView1.Items.Clear();
            using (SqlConnection conn = new SqlConnection(db.Connectstring()))
            {
                conn.Open();
                string query = "SELECT * FROM Ingredient";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Id"].ToString());
                        item.SubItems.Add(reader["Name"].ToString());
                        item.SubItems.Add(reader["Quantity"].ToString());
                        item.SubItems.Add(reader["Price"].ToString());
                        listView1.Items.Add(item);
                    }
                }
            }
        }

        private void LoadAssignedIngredients()
        {
            ingListView.Items.Clear();
            using (SqlConnection conn = new SqlConnection(db.Connectstring()))
            {
                conn.Open();
                string query = @"
                    SELECT d.ID, i.Name, d.QuantityRequired
                    FROM DishIngredientAssignment d
                    JOIN Ingredient i ON d.IngredientID = i.Id
                    WHERE d.DishID = @DishID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DishID", dishID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["ID"].ToString());
                            item.SubItems.Add(reader["Name"].ToString());
                            item.SubItems.Add(reader["QuantityRequired"].ToString());
                            ingListView.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ingListView.Items.Count == 0)
            {
                MessageBox.Show("Bạn chưa thêm nguyên liệu nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(db.Connectstring()))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    // Xóa hết nguyên liệu cũ
                    using (SqlCommand deleteCmd = new SqlCommand(
                        "DELETE FROM DishIngredientAssignment WHERE DishID = @DishID", conn, transaction))
                    {
                        deleteCmd.Parameters.AddWithValue("@DishID", dishID);
                        deleteCmd.ExecuteNonQuery();
                    }

                    // Thêm nguyên liệu mới
                    foreach (ListViewItem item in ingListView.Items)
                    {
                        using (SqlCommand insertCmd = new SqlCommand(@"
                            INSERT INTO DishIngredientAssignment (DishID, IngredientID, QuantityRequired)
                            VALUES (@DishID, @IngredientID, @QuantityRequired)", conn, transaction))
                        {
                            insertCmd.Parameters.AddWithValue("@DishID", dishID);
                            insertCmd.Parameters.AddWithValue("@IngredientID", int.Parse(item.SubItems[0].Text));
                            insertCmd.Parameters.AddWithValue("@QuantityRequired", int.Parse(item.SubItems[2].Text));
                            insertCmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void seachButton_Click(object sender, EventArgs e)
        {
            string keyword = searchTextBox.Text.Trim().ToLower();

            listView1.Items.Clear();

            using (SqlConnection conn = new SqlConnection(db.Connectstring()))
            {
                conn.Open();
                string query = "SELECT * FROM Ingredient WHERE LOWER(Name) LIKE @Keyword";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["Id"].ToString());
                    item.SubItems.Add(reader["Name"].ToString());
                    item.SubItems.Add(reader["Quantity"].ToString());
                    item.SubItems.Add(reader["Price"].ToString());
                    listView1.Items.Add(item);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (ingListView.SelectedItems.Count > 0)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa nguyên liệu này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    ListViewItem selectedItem = ingListView.SelectedItems[0];

                    using (SqlConnection conn = new SqlConnection(db.Connectstring()))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM DishIngredientAssignment WHERE DishID = @DishID AND IngredientID = @IngredientID", conn);
                        cmd.Parameters.AddWithValue("@DishID", dishID);
                        cmd.Parameters.AddWithValue("@IngredientID", selectedItem.SubItems[0].Text);
                        cmd.ExecuteNonQuery();
                    }

                    // Xóa luôn khỏi ListView (cho đẹp)
                    ingListView.Items.Remove(selectedItem);

                    MessageBox.Show("Đã xóa nguyên liệu!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu cần xóa.");
            }
        }

    }
}
