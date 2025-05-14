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

            string query = "SELECT Name, Sex, Position, BirthOfDay, PhoneNumber, Address, Picture, status " +
                           "FROM Employee WHERE ID = @EmployeeID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeID", _employeeID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
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
                                string picturePath = reader["Picture"].ToString();
                                if (!string.IsNullOrEmpty(picturePath))
                                {
                                    pictureBox.Image = Image.FromFile(picturePath);  
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

                        var result = cmd.ExecuteScalar(); 

                        if (result != DBNull.Value)
                        {
                            password = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return password; 
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string connectionString = db.Connectstring();

            DateTime birthDate;
            string dateFormat = "dd/MM/yyyy"; 

            if (!DateTime.TryParseExact(dobTextBox.Text, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out birthDate))
            {
                MessageBox.Show("Invalid date of birth. Please enter the date in the format dd/MM/yyyy.");
                return;
            }

            string query = "UPDATE Employee SET Name = @Name, Address = @Address, BirthOfDay = @BirthOfDay WHERE ID = @EmployeeID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", nameTextBox.Text);  
                        cmd.Parameters.AddWithValue("@Address", addressTextBox.Text); 
                        cmd.Parameters.AddWithValue("@BirthOfDay", birthDate);  
                        cmd.Parameters.AddWithValue("@EmployeeID", _employeeID);  

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee information updated successfully.");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("No changes were made.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            string connectionString = db.Connectstring();

            string oldPassword = getPassword(_username);

            string newPassword = passwordTextBox.Text.Trim();

            if (newPassword == oldPassword)
            {
                MessageBox.Show("The new password must be different from the old password.");
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
                        cmdUpdatePassword.Parameters.AddWithValue("@NewPassword", newPassword); 
                        cmdUpdatePassword.Parameters.AddWithValue("@Username", _username); 

                        int rowsAffected = cmdUpdatePassword.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("The password has been updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Unable to update the password. Please try again.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when changing the password: " + ex.Message);
            }
        }

        private void changePhonenumberBtn_Click(object sender, EventArgs e)
        {
            string connectionString = db.Connectstring();
            string phoneNumber = phoneTextBox.Text.Trim();

            if (string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Phone number cannot be empty.");
                return;
            }

            if (phoneNumber.Length < 10 || phoneNumber.Length > 11)
            {
                MessageBox.Show("Invalid phone number. Please enter again.");
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
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber); 
                        cmd.Parameters.AddWithValue("@EmployeeID", _employeeID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("The password has been updated successfully.");
                            LoadData(); 
                        }
                        else
                        {
                            MessageBox.Show("Unable to update the password. Please try again.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating phone number: " + ex.Message);
            }

        }
    }
}
