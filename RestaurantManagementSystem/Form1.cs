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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeLoginForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            string phone = phoneTxt.Text.Trim();
            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Please enter your phone number.");
                return;
            }

            Database db = new Database();
            string connectionString = db.Connectstring();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT TOP 1 accessKey FROM BookingKey WHERE phone = @Phone ORDER BY time DESC";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Phone", phone);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        label1.Text = result.ToString();
                     
                    }
                    else
                    {
                        label1.Text = "No booking found for this number.";
                        label1.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving key: " + ex.Message);
            }
        }
    }
}
