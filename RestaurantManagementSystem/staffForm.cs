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
    public partial class staffForm : Form
    {
        private string _username;
        Database db = new Database();
        public staffForm(string username)
        {
            InitializeComponent();
            menuButton_Click(null, EventArgs.Empty);
            _username = username;
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            staffMenuUC menu = new staffMenuUC();
            showPanel.Controls.Clear();
            menu.Dock = DockStyle.Fill;
            showPanel.Controls.Add(menu);

            ResetButtonColors();
            menuPanel.Visible = true;
            Guna.UI2.WinForms.Guna2Button clickedButton = sender as Guna.UI2.WinForms.Guna2Button;
            if (clickedButton != null)
            {
                clickedButton.FillColor = Color.FromArgb(50, 58, 68);
                titleLabel.Text = "MENU";
            }
        }

        private void tableStatusButton_Click(object sender, EventArgs e)
        {
            staffTableStatusUC ts = new staffTableStatusUC();
            showPanel.Controls.Clear();
            ts.Dock = DockStyle.Fill;
            showPanel.Controls.Add(ts);

            ResetButtonColors();
            tableStatusPanel.Visible = true;
            Guna.UI2.WinForms.Guna2Button clickedButton = sender as Guna.UI2.WinForms.Guna2Button;
            if (clickedButton != null)
            {
                clickedButton.FillColor = Color.FromArgb(50, 58, 68);
                titleLabel.Text = "TABLE STATUS";
            }
        }

        private void kitchenButton_Click(object sender, EventArgs e)
        {
            staffKitchenUC kc = new staffKitchenUC();
            showPanel.Controls.Clear();
            kc.Dock = DockStyle.Fill;
            showPanel.Controls.Add(kc);

            ResetButtonColors();
           
            Guna.UI2.WinForms.Guna2Button clickedButton = sender as Guna.UI2.WinForms.Guna2Button;
            if (clickedButton != null)
            {
                clickedButton.FillColor = Color.FromArgb(50, 58, 68);
                titleLabel.Text = "KITCHEN";
            }
        }
        private void ResetButtonColors()
        {
            menuButton.FillColor = Color.FromArgb(20, 28, 38);
            tableStatusButton.FillColor = Color.FromArgb(20, 28, 38);
           
            menuPanel.Visible = false;
            tableStatusPanel.Visible = false;
           
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            quitButton.Cursor = Cursors.Hand;
            this.Close();
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            int employeeID = getEmployeeID(_username);
            managerInfoUC s = new managerInfoUC(employeeID, _username);
            showPanel.Controls.Clear();
            s.Dock = DockStyle.Fill;
            showPanel.Controls.Add(s);
            ResetButtonColors();
            settingPanel.Visible = true;
            Guna.UI2.WinForms.Guna2Button clickedButton = sender as Guna.UI2.WinForms.Guna2Button;
            if (clickedButton != null)
            {
                clickedButton.FillColor = Color.FromArgb(50, 58, 68);
                titleLabel.Text = "";
            }
        }
        private int getEmployeeID(string username)
        {
            string connectionString = db.Connectstring();

            string query = "SELECT TOP 1 EmployeeID FROM Account WHERE Username LIKE @Username";

            int employeeID = -1;

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
                            employeeID = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Error: " + ex.Message);
            }

            return employeeID;
        }
    }
}
