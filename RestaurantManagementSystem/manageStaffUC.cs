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

        Database db = new Database();
        
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
            string connectionString = db.Connectstring();
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
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadStaffData()
        {
            string connectionString = db.Connectstring();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Modified query to exclude employees with status 'Deactive'
                    string query = "SELECT ID, Name, Sex, Position, BirthOfDay, PhoneNumber, Address FROM Employee WHERE status = 'Active'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

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
                MessageBox.Show("Error loading employee data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string connectionString = db.Connectstring();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string finalImagePath = string.IsNullOrEmpty(imagePath) ? "default.jpg" : imagePath;

                    // Modified query to return the inserted ID
                    string query = "INSERT INTO Employee (Name, Sex, Position, BirthOfDay, PhoneNumber, Address, Picture) " +
                                  "OUTPUT INSERTED.ID " +
                                  "VALUES (@Name, @Sex, @Position, @BirthOfDay, @PhoneNumber, @Address, @Picture)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", nameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Sex", sexComboBox.SelectedItem?.ToString() ?? "Male");
                    cmd.Parameters.AddWithValue("@Position", positionComboBox.SelectedItem?.ToString() ?? "Staff");
                    cmd.Parameters.AddWithValue("@BirthOfDay", birthDatePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumberTextBox.Text);
                    cmd.Parameters.AddWithValue("@Address", addressTextBox.Text);
                    cmd.Parameters.AddWithValue("@Picture", finalImagePath);

                    // ExecuteScalar to get the new ID
                    int newEmployeeId = (int)cmd.ExecuteScalar();
                    MessageBox.Show("Employee added successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadStaffData();
                    openFormSignUp(newEmployeeId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void openFormSignUp(int id)
        {
            signUpForm signUp = new signUpForm(id);
            signUp.Show();
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
                MessageBox.Show("Please select the employee to update!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
               
                int selectedId;
                if (!int.TryParse(staffListView.SelectedItems[0].SubItems[0].Text, out selectedId))
                {
                    MessageBox.Show("Unable to retrieve the employee's ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string finalImagePath = imagePath;
                string connectionString = db.Connectstring();

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

                    string sexValue = sexComboBox.SelectedItem != null ? sexComboBox.SelectedItem.ToString() : "Male";
                    string positionValue = positionComboBox.SelectedItem != null ? positionComboBox.SelectedItem.ToString() : "Staff";

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
                        MessageBox.Show("Employee information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        LoadStaffData();
                    }
                    else
                    {
                        MessageBox.Show("Employee to update not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (staffListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an employee to check!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Get the selected employee's name from staffListView (SubItems[1] is Name)
                string selectedName = staffListView.SelectedItems[0].SubItems[1].Text;
                string connectionString = db.Connectstring();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Query to get the ID from Employee table based on the name
                    string employeeQuery = "SELECT ID FROM Employee WHERE Name = @Name AND status = 'Active'";
                    SqlCommand employeeCmd = new SqlCommand(employeeQuery, conn);
                    employeeCmd.Parameters.AddWithValue("@Name", selectedName);
                    object result = employeeCmd.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Employee not found in the database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int selectedId = (int)result;

                    // Check if the employee has an account
                    string accountQuery = "SELECT COUNT(*) FROM Account WHERE EmployeeID = @EmployeeID";
                    SqlCommand accountCmd = new SqlCommand(accountQuery, conn);
                    accountCmd.Parameters.AddWithValue("@EmployeeID", selectedId);
                    int accountCount = (int)accountCmd.ExecuteScalar();

                    if (accountCount > 0)
                    {
                        MessageBox.Show("This employee already has an account.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"No account found for {selectedName}. Opening signup form...", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        openFormSignUp(selectedId);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string connectionString = db.Connectstring();
            if (staffListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select the employee to deactivate!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    int selectedId = int.Parse(staffListView.SelectedItems[0].SubItems[0].Text);

                    // Update status to "Deactive" in Employee table
                    string updateEmployeeQuery = "UPDATE Employee SET status = @Status WHERE ID = @ID";
                    SqlCommand updateEmployeeCmd = new SqlCommand(updateEmployeeQuery, conn);
                    updateEmployeeCmd.Parameters.AddWithValue("@Status", "Deactive");
                    updateEmployeeCmd.Parameters.AddWithValue("@ID", selectedId);
                    int employeeRowsAffected = updateEmployeeCmd.ExecuteNonQuery();

                    // Update status to "Deactive" in Account table
                    string updateAccountQuery = "UPDATE Account SET status = @Status WHERE EmployeeID = @EmployeeID";
                    SqlCommand updateAccountCmd = new SqlCommand(updateAccountQuery, conn);
                    updateAccountCmd.Parameters.AddWithValue("@Status", "Deactive");
                    updateAccountCmd.Parameters.AddWithValue("@EmployeeID", selectedId);
                    updateAccountCmd.ExecuteNonQuery();

                    if (employeeRowsAffected > 0)
                    {
                        MessageBox.Show("Employee and associated account(s) deactivated successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        LoadStaffData();
                    }
                    else
                    {
                        MessageBox.Show("Employee to deactivate not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deactivating employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void seachButton_Click(object sender, EventArgs e)
        {
            string keyword = searchTextBox.Text.Trim().ToLower(); 

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter the employee's name to search!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (ListViewItem item in staffListView.Items)
            {
                string name = item.SubItems[0].Text.ToLower();

                if (name.Contains(keyword))
                {
                    item.Selected = true;
                    item.Focused = true;
                    item.EnsureVisible();
                    staffListView.Select();

                    DisplayEmployeeInformation(item);

                    MessageBox.Show($"Found employee: ID = {item.SubItems[0].Text}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            MessageBox.Show("No matching employee found!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
