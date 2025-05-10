using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class managerInfoUC : UserControl
    {
        private int _employeeID;
        private string _username;
        private Database db = new Database();
        public managerInfoUC(int employeeID, string username)
        {
            InitializeComponent();
            _employeeID = employeeID;
            _username = username;
            LoadData();
        }
        public void LoadData()
        {
            string connectionString = db.Connectstring();

            // Câu lệnh SQL để truy vấn thông tin nhân viên theo EmployeeID
            string query = "SELECT Name, Sex, Position, BirthOfDay, PhoneNumber, Address, Picture, status " +
                           "FROM Employee WHERE ID = @EmployeeID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Mở kết nối tới cơ sở dữ liệu
                    connection.Open();

                    // Tạo đối tượng SqlCommand để thực thi câu lệnh SQL
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Thêm tham số EmployeeID vào câu lệnh SQL
                        cmd.Parameters.AddWithValue("@EmployeeID", _employeeID);

                        // Thực thi câu lệnh và lấy dữ liệu
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Đọc dữ liệu từ kết quả truy vấn và hiển thị lên form
                                nameLabel.Text = reader["Name"].ToString();
                                nameTextBox.Text = reader["Name"].ToString();
                                genderLabel.Text = reader["Sex"].ToString();
                                roleLabel.Text = reader["Position"].ToString();
                                dobTextBox.Text = Convert.ToDateTime(reader["BirthOfDay"]).ToString("dd/MM/yyyy");
                                phoneTextBox.Text = reader["PhoneNumber"].ToString();
                                addressTextBox.Text = reader["Address"].ToString();
                                usernameTextBox.Text = _username;
                                passwordTextBox.Text = getPassword(_username);
                                statusLabel.Text = reader["status"].ToString();
                                if (statusLabel.Text == "Active")
                                {
                                    statusLabel.ForeColor = Color.Olive;
                                }
                                else if (statusLabel.Text == "Deactive")
                                {
                                    statusLabel.ForeColor = Color.Red;
                                }
                                // Hiển thị ảnh (nếu có đường dẫn ảnh trong Picture)
                                string picturePath = reader["Picture"].ToString();
                                if (!string.IsNullOrEmpty(picturePath))
                                {
                                    pictureBox.Image = Image.FromFile(picturePath);  // Hiển thị ảnh từ đường dẫn
                                }

                                
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employee data: " + ex.Message);
            }
        
        
        }
        public string getPassword(string username)
        {
            string connectionString = db.Connectstring();

            string query = "SELECT Password FROM Account WHERE Username = @Username";

            string password = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

                        // Thực thi câu lệnh và lấy dữ liệu
                        var result = cmd.ExecuteScalar(); // Lấy giá trị đầu tiên từ truy vấn

                        // Nếu kết quả không phải DBNull (có kết quả trả về)
                        if (result != DBNull.Value)
                        {
                            password = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (nếu có lỗi trong quá trình truy vấn)
                MessageBox.Show("Error: " + ex.Message);
            }

            return password;  // Trả về mật khẩu (hoặc null nếu không tìm thấy username)
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string connectionString = db.Connectstring();

            DateTime birthDate;
            string dateFormat = "dd/MM/yyyy"; 

            if (!DateTime.TryParseExact(dobTextBox.Text, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out birthDate))
            {
                MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng nhập lại ngày sinh theo định dạng dd/MM/yyyy.");
                return;
            }


            // Câu lệnh SQL để cập nhật thông tin nhân viên
            string query = "UPDATE Employee SET Name = @Name, Address = @Address, BirthOfDay = @BirthOfDay WHERE ID = @EmployeeID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Mở kết nối tới cơ sở dữ liệu
                    connection.Open();

                    // Khai báo SqlCommand để thực thi câu lệnh SQL
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Thêm tham số vào câu lệnh SQL để tránh SQL Injection
                        cmd.Parameters.AddWithValue("@Name", nameTextBox.Text);  // Tên từ TextBox
                        cmd.Parameters.AddWithValue("@Address", addressTextBox.Text);  // Địa chỉ từ TextBox
                        cmd.Parameters.AddWithValue("@BirthOfDay", birthDate);  // Ngày sinh từ TextBox sau khi kiểm tra hợp lệ
                        cmd.Parameters.AddWithValue("@EmployeeID", _employeeID);  // EmployeeID từ form hoặc biến toàn cục

                        // Thực thi câu lệnh SQL để cập nhật
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Kiểm tra xem có dòng nào bị thay đổi hay không
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thông tin nhân viên thành công.");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Không có thay đổi nào được thực hiện.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            string connectionString = db.Connectstring();

            string oldPassword = getPassword(_username);

            string newPassword = passwordTextBox.Text.Trim();

            if (newPassword == oldPassword)
            {
                MessageBox.Show("Mật khẩu mới phải khác với mật khẩu cũ.");
                return;
            }

            string queryUpdatePassword = "UPDATE Account SET Password = @NewPassword WHERE Username = @Username";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmdUpdatePassword = new SqlCommand(queryUpdatePassword, connection))
                    {
                        cmdUpdatePassword.Parameters.AddWithValue("@NewPassword", newPassword); // Set the new password
                        cmdUpdatePassword.Parameters.AddWithValue("@Username", _username); // Set the username

                        int rowsAffected = cmdUpdatePassword.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Mật khẩu đã được cập nhật thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Không thể cập nhật mật khẩu. Vui lòng thử lại.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thay đổi mật khẩu: " + ex.Message);
            }
        }

        private void changePhonenumberBtn_Click(object sender, EventArgs e)
        {
            string connectionString = db.Connectstring();
            string phoneNumber = phoneTextBox.Text.Trim();

            if (string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Số điện thoại không thể để trống.");
                return;
            }

            if (phoneNumber.Length < 10 || phoneNumber.Length > 11)
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập lại.");
                return;
            }

            string query = "UPDATE Employee SET PhoneNumber = @PhoneNumber WHERE ID = @EmployeeID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber); // Set the new phone number
                        cmd.Parameters.AddWithValue("@EmployeeID", _employeeID); // EmployeeID from the form or class

                        // Execute the query to update the phone number
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật số điện thoại thành công.");
                            LoadData(); 
                        }
                        else
                        {
                            MessageBox.Show("Không thể cập nhật số điện thoại. Vui lòng thử lại.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật số điện thoại: " + ex.Message);
            }

        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void roleLabel_Click(object sender, EventArgs e)
        {

        }

        private void genderLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
