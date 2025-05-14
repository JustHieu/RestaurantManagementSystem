using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace RestaurantManagementSystem
{
    public partial class keyAccessFrom : Form
    {

        public keyAccessFrom()
        {
            InitializeComponent();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
           
        }
        private int GetTableIdByBooking(int idBooking)
        {
            Database db = new Database();
            string connectionString = db.Connectstring();
            string query = "SELECT idTable FROM BookingKey WHERE idBooking = @idBooking";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idBooking", idBooking);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("No table found for the provided booking ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return -1; 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to retrieve table ID: " + ex.Message);
                return -1;
            }
        }


        private void OpenOrderForm(int tableId, int idBooking)
        {
            try
            {
                bookTableFrm orderForm = new bookTableFrm(tableId, idBooking);
                orderForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening booking form: " + ex.Message);
            }
        }

        public void IsVisible(Boolean a)
        {
            check.Visible=a;
        }

        private void closeLoginForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int CheckKeyAccess(string accessKey)
        {
            Database db = new Database();
            string connectionString = db.Connectstring();
            string query = "SELECT idBooking FROM BookingKey WHERE accessKey = @accessKey";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@accessKey", accessKey);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Invalid access key!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking access key: " + ex.Message);
                return -1;
            }
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            string key = keyTxt.Text.Trim();
            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Please enter the access key!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idBooking = CheckKeyAccess(key); 
            if (idBooking != -1)
            {
                int tableId = GetTableIdByBooking(idBooking); 
                if (tableId != -1)
                {
                    MessageBox.Show("Access granted! Welcome to table number: " + tableId);
                    OpenOrderForm(tableId, idBooking); 
                }
                else
                {
                    MessageBox.Show("No table found for the given access key!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid access key! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void keyAccessFrom_Load(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            int radius = 33;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.X, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }

        private void check_Click(object sender, EventArgs e)
        {
            Form1 bookTable = new Form1();
            bookTable.Show();
            this.Hide();
            bookTable.FormClosed += (s, args) => this.Show();
        }

    }
}
