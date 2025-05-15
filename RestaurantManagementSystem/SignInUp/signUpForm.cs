using Azure.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    
    public partial class signUpForm : Form
    {
        
        private int _id;
        public bool formCheck = false;
       
        public signUpForm(int id)
        {
            InitializeComponent();
            _id = id;   
        }

        private void signUpForm_Load(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            int radius = 34; // Độ bo tròn, bạn có thể điều chỉnh

            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.X, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            formCheck = true;
            this.Close();
            signInForm signInForm = new signInForm();
            signInForm.Show();
            
        }

        private void closeSignUpForm_Click(object sender, EventArgs e)
        {
            formCheck = false;
            this.Close();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            string connectionString = db.Connectstring();
            string email = emailTextbox.Text.Trim();
            string password = passwordTextbox.Text.Trim();
            string confirm = confirmPass.Text.Trim();

            if ( string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirm))
            {
                MessageBox.Show("Email or password fields cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if username (email) already exists
                    string checkQuery = "SELECT COUNT(*) FROM Account WHERE Username = @Username";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@Username", email);
                        int userCount = (int)checkCommand.ExecuteScalar();
                        if (userCount > 0)
                        {
                            MessageBox.Show("This email is already registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Insert new account with EmployeeID
                    string insertQuery = "INSERT INTO Account (Username, Password, Role, EmployeeID, status) " +
                                        "VALUES (@Username, @Password, @Role, @EmployeeID, @Status)";
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@Username", email);
                        insertCommand.Parameters.AddWithValue("@Password", password); // Consider hashing
                        insertCommand.Parameters.AddWithValue("@Role", "Staff"); // Default role
                        insertCommand.Parameters.AddWithValue("@EmployeeID", _id);
                        insertCommand.Parameters.AddWithValue("@Status", "Active");

                        int rowsAffected = insertCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            formCheck = true;
                            this.Close();
                            signInForm signInForm = new signInForm();
                            signInForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Failed to create account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
