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
    public partial class RememberKeyPass : Form
    {
        public RememberKeyPass()
        {
            InitializeComponent();
        }

        private void RememberKeyPass_Load(object sender, EventArgs e)
        {

        }

        private void closeLoginForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            string phone = phoneTxt.Text.Trim();
            string connStr = @"Data Source=.;Initial Catalog=restaurantData;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT TOP 1 accessKey FROM BookingKey WHERE phone = @phone ORDER BY time DESC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@phone", phone);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        keyLb.Text = "Your Key: " + result.ToString();
                    else
                        keyLb.Text = "No key found!";
                }
            }
        }
    }
}
