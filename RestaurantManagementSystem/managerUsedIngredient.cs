using Guna.UI2.WinForms;
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
    public partial class managerUsedIngredient : UserControl
    {
        private Database db = new Database();
        public managerUsedIngredient()
        {
            InitializeComponent();
        }
        private void LoadUsedIngredientData()
        {
            string connectionString = db.Connectstring();
            string query = "SELECT id, idTable, DishName, Name, Quantity, Price, Amount, UsedTime FROM UsedIngredient";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    guna2DataGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu nguyên liệu đã dùng: " + ex.Message);
            }
        }

        private void FilterUsedIngredientByDate()
        {
            string connectionString = db.Connectstring();
            string query = "SELECT id, idTable, DishName, Name, Quantity, Price, Amount, UsedTime " +
                           "FROM UsedIngredient " +
                           "WHERE UsedTime BETWEEN @fromDate AND @toDate";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@fromDate", fromDateTimePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@toDate", toDateTimePicker.Value.Date.AddDays(1).AddTicks(-1));
                    // .AddDays(1).AddTicks(-1) để lấy hết ngày toDate

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    guna2DataGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lọc dữ liệu nguyên liệu: " + ex.Message);
            }
        }

        private void managerUsedIngredient_Load(object sender, EventArgs e)
        {
            LoadUsedIngredientData();
        }

        private void seachButton_Click_1(object sender, EventArgs e)
        {
            FilterUsedIngredientByDate();
        }
    }
}
