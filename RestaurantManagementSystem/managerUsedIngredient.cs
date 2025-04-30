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
    public partial class managerUsedIngredient : UserControl
    {
        Database db = new Database();


        public managerUsedIngredient()
        {
            InitializeComponent();
            SetupListView();
            LoadUsedIngredientsToListView();
            usedIngredientsListView.DrawColumnHeader += usedIngredientsListView_DrawColumnHeader;
            usedIngredientsListView.DrawSubItem += usedIngredientsListView_DrawSubItem;
        }
        private void usedIngredientsListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // Căn giữa cả tiêu đề cột
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine;
            e.DrawBackground();
            TextRenderer.DrawText(e.Graphics, e.Header.Text, e.Font, e.Bounds, e.ForeColor, flags);
        }

        private void usedIngredientsListView_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            // Căn giữa nội dung từng cell
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine;
            e.DrawBackground();
            TextRenderer.DrawText(e.Graphics, e.SubItem.Text, e.SubItem.Font, e.Bounds, e.SubItem.ForeColor, flags);
        }

        private void SetupListView()
        {
            usedIngredientsListView.View = View.Details;
            usedIngredientsListView.Columns.Clear();
            usedIngredientsListView.Columns.Add("INGREDIENTS NAME", 250, HorizontalAlignment.Left);
            usedIngredientsListView.Columns.Add("TOTAL AMOUNT (Gram)", 160, HorizontalAlignment.Right);
            usedIngredientsListView.Columns.Add("TOTAL PRICE ($)", 190, HorizontalAlignment.Right);
            usedIngredientsListView.FullRowSelect = true;
            usedIngredientsListView.GridLines = true;
            
        }





        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadUsedIngredientsToListView()
        {
            string connectionString = db.Connectstring();
            decimal totalAmount = 0;

            usedIngredientsListView.Items.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                SELECT Name AS IngredientName, 
                       SUM(Quantity) AS TotalQuantity, 
                       SUM(Price * Quantity) AS TotalPrice
                FROM UsedIngredient
                GROUP BY Name
                ORDER BY IngredientName";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader["IngredientName"].ToString();
                            string qty = string.Format("{0:N2}", reader["TotalQuantity"]);
                            string price = string.Format("{0:N0}", reader["TotalPrice"]);

                            // Thêm vào ListView
                            ListViewItem item = new ListViewItem(name);
                            item.SubItems.Add(qty);
                            item.SubItems.Add(price);

                            usedIngredientsListView.Items.Add(item);

                            // Tính tổng giá
                            decimal rowPrice = 0;
                            if (decimal.TryParse(reader["TotalPrice"].ToString(), out rowPrice))
                                totalAmount += rowPrice;
                        }
                    }
                }

                label2.Text = $"{totalAmount:N0}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị nguyên liệu đã dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void managerUsedIngredient_Load(object sender, EventArgs e)
        {
            SetupListView();
            LoadUsedIngredientsToListView();
        }

        private void managerUsedIngredient_Load_1(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void usedIngredientsView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
