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
            this.ingListView.MouseClick += new MouseEventHandler(this.ingListView_MouseClick);
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
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an ingredient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ingredientId = listView1.SelectedItems[0].SubItems[0].Text;
            string ingredientName = listView1.SelectedItems[0].SubItems[1].Text;

            string quantityStr = Microsoft.VisualBasic.Interaction.InputBox(
                $"Enter the quantity needed for '{ingredientName}':", "Số lượng", "1");

            if (string.IsNullOrWhiteSpace(quantityStr) || !int.TryParse(quantityStr, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Invalid quantity. Please enter a positive number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

        private void cookingIngredientsForm_Load_1(object sender, EventArgs e)
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
                    SELECT d.IngredientID, i.Name, d.QuantityRequired
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
                            ListViewItem item = new ListViewItem(reader["IngredientID"].ToString());
                            item.SubItems.Add(reader["Name"].ToString());
                            item.SubItems.Add(Math.Floor(Convert.ToDecimal(reader["QuantityRequired"])).ToString());
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
                MessageBox.Show("You haven't added any ingredients!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(db.Connectstring()))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    using (SqlCommand deleteCmd = new SqlCommand(
                        "DELETE FROM DishIngredientAssignment WHERE DishID = @DishID", conn, transaction))
                    {
                        deleteCmd.Parameters.AddWithValue("@DishID", dishID);
                        deleteCmd.ExecuteNonQuery();
                    }

                    foreach (ListViewItem item in ingListView.Items)
                    {
                        if (!int.TryParse(item.SubItems[0].Text, out int ingredientId))
                        {
                            throw new Exception($"Invalid ingredient ID: {item.SubItems[0].Text}");
                        }
                        if (!decimal.TryParse(item.SubItems[2].Text, out decimal quantityRequired) || quantityRequired <= 0)
                        {
                            throw new Exception($"Invalid quantity for ingredient: {item.SubItems[1].Text}");
                        }

                        using (SqlCommand insertCmd = new SqlCommand(@"
                            INSERT INTO DishIngredientAssignment (DishID, IngredientID, QuantityRequired)
                            VALUES (@DishID, @IngredientID, @QuantityRequired)", conn, transaction))
                        {
                            insertCmd.Parameters.AddWithValue("@DishID", dishID);
                            insertCmd.Parameters.AddWithValue("@IngredientID", ingredientId);
                            insertCmd.Parameters.AddWithValue("@QuantityRequired", (int)quantityRequired);
                            insertCmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Update successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error saving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
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
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (ingListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select the ingredient you want to delete.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this ingredient?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            ListViewItem selectedItem = ingListView.SelectedItems[0];
            if (!int.TryParse(selectedItem.SubItems[0].Text, out int ingredientId))
            {
                MessageBox.Show("Invalid ingredient ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(db.Connectstring()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(
                    "DELETE FROM DishIngredientAssignment WHERE DishID = @DishID AND IngredientID = @IngredientID", conn))
                {
                    cmd.Parameters.AddWithValue("@DishID", dishID);
                    cmd.Parameters.AddWithValue("@IngredientID", ingredientId);
                    cmd.ExecuteNonQuery();
                }
            }

            ingListView.Items.Remove(selectedItem);
            MessageBox.Show("Ingredient deleted successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
