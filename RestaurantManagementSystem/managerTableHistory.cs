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
    public partial class managerTableHistory : UserControl
    {
        Database db = new Database();
        public managerTableHistory()
        {
            InitializeComponent();
            LoadTableHistory();
        }

        private void managerTableHistory_Load(object sender, EventArgs e)
        {

        }
        private void LoadTableHistory(string keyword = "")
        {
            string connectionString = db.Connectstring();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT idThanhToan, idTable, time, totalAmount FROM PaymentHistory";

                    if (!string.IsNullOrEmpty(keyword))
                    {
                        query += " WHERE idTable LIKE @Keyword";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (!string.IsNullOrEmpty(keyword))
                    {
                        cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                    }

                    SqlDataReader reader = cmd.ExecuteReader();
                    flowPanel.Controls.Clear();

                    while (reader.Read())
                    {
                        int idThanhToan = Convert.ToInt32(reader["idThanhToan"]);
                        int id = Convert.ToInt32(reader["idTable"]);
                        decimal totalAmount = Convert.ToDecimal(reader["totalAmount"]);
                        DateTime bookingTime = Convert.ToDateTime(reader["time"]);

                        managerTableHistoryMiniUC item = new managerTableHistoryMiniUC();
                        item.setIdThanhToan(idThanhToan);
                        item.Tag(id);
                        item.setamount(totalAmount);
                        item.setDate(bookingTime);
                        flowPanel.Controls.Add(item);

                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data loading error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void seachButton_Click(object sender, EventArgs e)
        {
            string keyword = searchTextBox.Text.Trim();
            LoadTableHistory(keyword);
        }
    }
}
