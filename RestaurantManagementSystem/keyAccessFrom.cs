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
                        MessageBox.Show("Không tìm thấy bàn với mã đặt chỗ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return -1;  // Không tìm thấy bàn
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy ID bàn từ ID Booking: " + ex.Message);
                return -1;
            }
        }


        private void OpenOrderForm(int tableId, int idBooking)
        {
            try
            {
                // Mở form đặt bàn với đúng tableId và idBooking
                bookTableFrm orderForm = new bookTableFrm(tableId, idBooking);
                orderForm.Show();
                //this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở form đặt bàn: " + ex.Message);
            }
        }

        public void IsVisible(Boolean a)
        {
            check.Visible=a;
        }




        private void keyTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                        MessageBox.Show("Key không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return -1;  // Key không hợp lệ
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra Access Key: " + ex.Message);
                return -1;
            }
        }



        private void signUpBtn_Click(object sender, EventArgs e)
        {
            string key = keyTxt.Text.Trim();
            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Vui lòng nhập mã truy cập!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idBooking = CheckKeyAccess(key);  // Lấy ID booking từ Access Key
            if (idBooking != -1)
            {
                int tableId = GetTableIdByBooking(idBooking);  // Lấy ID bàn từ ID booking
                if (tableId != -1)
                {
                    MessageBox.Show("Truy cập thành công! Chào mừng bạn đến với bàn số: " + tableId);
                    OpenOrderForm(tableId, idBooking);  // Mở form đặt bàn
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bàn cho mã truy cập!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mã truy cập không hợp lệ! Vui lòng thử lại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
