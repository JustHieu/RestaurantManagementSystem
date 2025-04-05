using Microsoft.Win32;
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
using System.IO;

namespace RestaurantManagementSystem
{
    public partial class manageStaffUC : UserControl
    {

        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=RestaurantData;Persist Security Info=True;User ID=sa;Password=123";
        private string imagePath = "";

        public manageStaffUC()
        {
            InitializeComponent();
            SetupStaffListView();
            LoadStaffData();
        }
        private void staffListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (staffListView.SelectedItems.Count > 0)
            {
                DisplayEmployeeInformation(staffListView.SelectedItems[0]);
            }
        }

        private void DisplayEmployeeInformation(ListViewItem item)
        {
            try
            {
                int selectedId = int.Parse(item.SubItems[0].Text);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Employee WHERE ID = @ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", selectedId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        nameTextBox.Text = reader["Name"].ToString();
                        sexComboBox.SelectedItem = reader["Sex"].ToString();
                        positionComboBox.SelectedItem = reader["Position"].ToString();
                        birthDatePicker.Value = Convert.ToDateTime(reader["BirthOfDay"]);
                        phoneNumberTextBox.Text = reader["PhoneNumber"].ToString();
                        addressTextBox.Text = reader["Address"].ToString();

                        string picturePath = reader["Picture"].ToString();
                        if (File.Exists(picturePath))
                        {
                            staffImage.Image = Image.FromFile(picturePath);
                            staffImage.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                       /* else
                        {
                            staffImage.Image = Properties.Resources.no_image;
                        }*/
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị thông tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadStaffData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT ID, Name, Sex, Position, BirthOfDay, PhoneNumber, Address FROM Employee";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Xóa dữ liệu cũ trước khi thêm mới
                    staffListView.Items.Clear();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["ID"].ToString());
                        item.SubItems.Add(reader["Name"].ToString());
                        item.SubItems.Add(reader["Sex"].ToString());
                        item.SubItems.Add(reader["Position"].ToString());
                        item.SubItems.Add(Convert.ToDateTime(reader["BirthOfDay"]).ToString("dd/MM/yyyy"));
                        item.SubItems.Add(reader["PhoneNumber"].ToString());
                        item.SubItems.Add(reader["Address"].ToString());

                        staffListView.Items.Add(item);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void manageStaffUC_Load(object sender, EventArgs e)
        {
            LoadStaffData();
            staffListView.MouseClick += staffListView_MouseClick;
        }
        private void SetupStaffListView()
        {
            staffListView.View = View.Details;
            staffListView.FullRowSelect = true;
            staffListView.GridLines = true;

            // Thiết lập các cột
            staffListView.Columns.Add("ID", 50, HorizontalAlignment.Center);
            staffListView.Columns.Add("Name", 150, HorizontalAlignment.Left);
            staffListView.Columns.Add("Sex", 80, HorizontalAlignment.Center);
            staffListView.Columns.Add("Position", 100, HorizontalAlignment.Center);
            staffListView.Columns.Add("Birth Of Day", 100, HorizontalAlignment.Center);
            staffListView.Columns.Add("Phone Number", 120, HorizontalAlignment.Left);
            staffListView.Columns.Add("Address", 200, HorizontalAlignment.Left);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string finalImagePath = string.IsNullOrEmpty(imagePath) ? "default.jpg" : imagePath;

                    string query = "INSERT INTO Employee (Name, Sex, Position, BirthOfDay, PhoneNumber, Address, Picture) VALUES (@Name, @Sex, @Position, @BirthOfDay, @PhoneNumber, @Address, @Picture)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", nameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Sex", sexComboBox.SelectedItem?.ToString() ?? "Male");
                    cmd.Parameters.AddWithValue("@Position", positionComboBox.SelectedItem?.ToString() ?? "Staff");
                    cmd.Parameters.AddWithValue("@BirthOfDay", birthDatePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumberTextBox.Text);
                    cmd.Parameters.AddWithValue("@Address", addressTextBox.Text);
                    cmd.Parameters.AddWithValue("@Picture", finalImagePath);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadStaffData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ClearFields()
        {
            nameTextBox.Text = "";
            sexComboBox.SelectedIndex = 0;
            positionComboBox.SelectedIndex = 0;
            birthDatePicker.Value = DateTime.Today;
            phoneNumberTextBox.Text = "";
            addressTextBox.Text = "";
            staffImage.Image = null;
            imagePath = "";
        }

        private void insertImageButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog FileDialog = new System.Windows.Forms.OpenFileDialog

            {
                Title = "Chọn ảnh món ăn",
                Filter = "Hình ảnh|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            };

            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = FileDialog.FileName;
                staffImage.Image = Image.FromFile(imagePath);
                staffImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (staffListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
               
                int selectedId;
                if (!int.TryParse(staffListView.SelectedItems[0].SubItems[0].Text, out selectedId))
                {
                    MessageBox.Show("Không thể lấy ID của nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lấy đường dẫn ảnh từ cơ sở dữ liệu nếu chưa chọn ảnh mới
                string finalImagePath = imagePath;

                if (string.IsNullOrEmpty(finalImagePath))
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "SELECT Picture FROM Employee WHERE ID = @ID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@ID", selectedId);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            finalImagePath = reader["Picture"].ToString();
                        }
                        reader.Close();
                    }
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Câu lệnh UPDATE
                    string query = @"UPDATE Employee 
                             SET Name = @Name, 
                                 Sex = @Sex, 
                                 Position = @Position, 
                                 BirthOfDay = @BirthOfDay, 
                                 PhoneNumber = @PhoneNumber, 
                                 Address = @Address, 
                                 Picture = @Picture 
                             WHERE ID = @ID";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Đảm bảo giá trị hợp lệ từ ComboBox
                    string sexValue = sexComboBox.SelectedItem != null ? sexComboBox.SelectedItem.ToString() : "Male";
                    string positionValue = positionComboBox.SelectedItem != null ? positionComboBox.SelectedItem.ToString() : "Staff";

                    // Thêm tham số từ các TextBox và ComboBox
                    cmd.Parameters.AddWithValue("@Name", nameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Sex", sexValue);
                    cmd.Parameters.AddWithValue("@Position", positionValue);
                    cmd.Parameters.AddWithValue("@BirthOfDay", birthDatePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumberTextBox.Text);
                    cmd.Parameters.AddWithValue("@Address", addressTextBox.Text);
                    cmd.Parameters.AddWithValue("@Picture", finalImagePath);
                    cmd.Parameters.AddWithValue("@ID", selectedId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        LoadStaffData();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên cần cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void checkButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (staffListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    int selectedId = int.Parse(staffListView.SelectedItems[0].SubItems[0].Text);
                    string query = "DELETE FROM Employee WHERE ID = @ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", selectedId);
                    cmd.ExecuteNonQuery();

                    // Tìm ID lớn nhất sau khi xóa
                    string maxIdQuery = "SELECT ISNULL(MAX(ID), 0) FROM Employee";
                    SqlCommand maxIdCmd = new SqlCommand(maxIdQuery, conn);
                    int maxId = (int)maxIdCmd.ExecuteScalar();

                    // Đặt lại giá trị tự tăng
                    string reseedQuery = $"DBCC CHECKIDENT ('Employee', RESEED, {maxId})";
                    SqlCommand reseedCmd = new SqlCommand(reseedQuery, conn);
                    reseedCmd.ExecuteNonQuery();

                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadStaffData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
