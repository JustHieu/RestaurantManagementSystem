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
    public partial class ingredientFrm : Form
    {
        private int dishId;
        Database db = new Database();
        public ingredientFrm(int dishId)
        {
            InitializeComponent();
            this.dishId = dishId;
        }
        private void ShowIngredients()
        {
            ingredientPanel.Controls.Clear();
            string connectionString = db.Connectstring();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                SELECT I.Name, DA.QuantityRequired
                FROM DishIngredientAssignment DA
                JOIN Ingredient I ON DA.IngredientID = I.Id
                WHERE DA.DishID = @DishId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@DishId", dishId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int y = 10;
                        int rowHeight = 28; // Điều chỉnh cho phù hợp kích cỡ chữ
                        while (reader.Read())
                        {
                            string ingredientName = reader["Name"].ToString();
                            string quantity = reader["QuantityRequired"].ToString();

                            // Label Tên nguyên liệu (dòng trên)
                            Label lblName = new Label()
                            {
                                Text = ingredientName,
                                Location = new Point(20, y),
                                Size = new Size(200, rowHeight),
                                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                                ForeColor = Color.Black,
                                AutoSize = false,
                                TextAlign = ContentAlignment.MiddleLeft
                            };
                            ingredientPanel.Controls.Add(lblName);

                            // Label Số lượng (dòng dưới)
                            Label lblQty = new Label()
                            {
                                Text = quantity,
                                Location = new Point(20, y + rowHeight),
                                Size = new Size(200, rowHeight),
                                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                                ForeColor = Color.OrangeRed,
                                AutoSize = false,
                                TextAlign = ContentAlignment.MiddleLeft
                            };
                            ingredientPanel.Controls.Add(lblQty);

                            y += rowHeight * 2 + 5; // Tăng vị trí y cho nhóm tiếp theo
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị nguyên liệu: " + ex.Message);
            }
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ingredientFrm_Load(object sender, EventArgs e)
        {
            ShowIngredients();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
