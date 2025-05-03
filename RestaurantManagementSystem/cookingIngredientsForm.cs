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
    public partial class cookingIngredientsForm : Form
    {
        private int selectedDishId;
        private Database db = new Database();
        public cookingIngredientsForm(int dishId)
        {
            InitializeComponent();
            selectedDishId = dishId;
            
            this.Load += cookingIngredientsForm_Load;

        }
        private void LoadIngredients()
        {
            ingredientView.Items.Clear();
            string query = @"
            SELECT i.Name, dia.QuantityRequired 
            FROM DishIngredientAssignment dia 
            JOIN Ingredient i ON dia.IngredientID = i.Id 
            WHERE dia.DishID = @DishID";

            using (SqlConnection conn = new SqlConnection(db.Connectstring()))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DishID", selectedDishId);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["Name"].ToString());
                    item.SubItems.Add(reader["QuantityRequired"].ToString());
                    ingredientView.Items.Add(item);
                }

                reader.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void cookingIngredientsForm_Load(object sender, EventArgs e)
        {
            ingredientView.View = View.Details;
            ingredientView.FullRowSelect = true;
            ingredientView.Columns.Clear();
            ingredientView.Columns.Add("Name", 150);
            ingredientView.Columns.Add("Quantity Required", 150);

            LoadIngredients();
        }

        private void IngredientView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ingredientView.SelectedItems.Count > 0)
            {
                var selectedItem = ingredientView.SelectedItems[0];
                nameTxt.Text = selectedItem.Text;
                quantityTxt.Text = selectedItem.SubItems[1].Text;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ingredientView.SelectedItems.Count == 0) return;

            string ingredientName = nameTxt.Text.Trim();
            if (!decimal.TryParse(quantityTxt.Text, out decimal newQuantity)) return;

            string query = @"
            UPDATE dia
            SET dia.QuantityRequired = @Quantity
            FROM DishIngredientAssignment dia
            JOIN Ingredient i ON dia.IngredientID = i.Id
            WHERE dia.DishID = @DishID AND i.Name = @IngredientName";

            using (SqlConnection conn = new SqlConnection(db.Connectstring()))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DishID", selectedDishId);
                cmd.Parameters.AddWithValue("@IngredientName", ingredientName);
                cmd.Parameters.AddWithValue("@Quantity", newQuantity);
                cmd.ExecuteNonQuery();
            }

            LoadIngredients();
            MessageBox.Show("Cập nhật nguyên liệu thành công!");
        }

        private void closeLoginForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quantityTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
