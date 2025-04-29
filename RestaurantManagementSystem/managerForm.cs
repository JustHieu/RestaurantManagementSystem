using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RestaurantManagementSystem
{
    public partial class managerForm : Form
    {
        private string _username;
        Database db = new Database();
        public managerForm(string username="")
        {
            InitializeComponent();
            menuButton_Click(null, EventArgs.Empty);
            _username = username;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            managerMenuUC menu = new managerMenuUC();
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

        private void tableHistoryButton_Click(object sender, EventArgs e)
        {
            managerTableHistory menu = new managerTableHistory();
            showPanel.Controls.Clear();
            menu.Dock = DockStyle.Fill;
            showPanel.Controls.Add(menu);
            ResetButtonColors();
            tableStatusPanel.Visible = true;
            Guna.UI2.WinForms.Guna2Button clickedButton = sender as Guna.UI2.WinForms.Guna2Button;
            if (clickedButton != null)
            {
                clickedButton.FillColor = Color.FromArgb(50, 58, 68);
                titleLabel.Text = "TABLE HISTORY";
            }
        }

        private void coldStorageButton_Click(object sender, EventArgs e)
        {
            managerColdStorageUC cs = new managerColdStorageUC();
            showPanel.Controls.Clear();
            cs.Dock = DockStyle.Fill;
            showPanel.Controls.Add(cs);

            ResetButtonColors();
            coldStoragePanel.Visible = true;
            Guna.UI2.WinForms.Guna2Button clickedButton = sender as Guna.UI2.WinForms.Guna2Button;
            if (clickedButton != null)
            {
                clickedButton.FillColor = Color.FromArgb(50, 58, 68);
                titleLabel.Text = "COLD STORAGE";
            }
        }
        private void ResetButtonColors()
        {
            menuButton.FillColor = Color.FromArgb(20, 28, 38);
            tableHistoryButton.FillColor = Color.FromArgb(20, 28, 38);
            coldStorageButton.FillColor = Color.FromArgb(20, 28, 38);
            manageStaffButton.FillColor = Color.FromArgb(20, 28, 38);
            usedIngredientBtn.FillColor = Color.FromArgb(20, 28, 38);
            statisticalButton.FillColor = Color.FromArgb(20, 28, 38);
            accountSettingBtn.FillColor = Color.FromArgb(20, 28, 38);
            menuPanel.Visible = false;
            tableStatusPanel.Visible = false;
            coldStoragePanel.Visible = false;
            manageStaffPanel.Visible = false;
            statisticalPanel.Visible = false;
            settingPanel.Visible = false;
            usedPanel.Visible = false;
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manageStaffButton_Click(object sender, EventArgs e)
        {
            manageStaffUC ms = new manageStaffUC();
            showPanel.Controls.Clear();
            ms.Dock = DockStyle.Fill;
            showPanel.Controls.Add(ms);

            ResetButtonColors();
            manageStaffPanel.Visible = true;
            Guna.UI2.WinForms.Guna2Button clickedButton = sender as Guna.UI2.WinForms.Guna2Button;
            if (clickedButton != null)
            {
                clickedButton.FillColor = Color.FromArgb(50, 58, 68);
                titleLabel.Text = "MANAGE STAFF";
            }
        }

        private void statisticalButton_Click(object sender, EventArgs e)
        {
            managerStatisticalUC s = new managerStatisticalUC();
            showPanel.Controls.Clear();
            s.Dock = DockStyle.Fill;
            showPanel.Controls.Add(s);

            // Sửa lỗi form bị mất Maximized
            this.WindowState = FormWindowState.Maximized;

            ResetButtonColors();
            statisticalPanel.Visible = true;
            Guna.UI2.WinForms.Guna2Button clickedButton = sender as Guna.UI2.WinForms.Guna2Button;
            if (clickedButton != null)
            {
                clickedButton.FillColor = Color.FromArgb(50, 58, 68);
                titleLabel.Text = "DASHBOARD";
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void accountSettingBtn_Click(object sender, EventArgs e)
        {
            int employeeID = getEmployeeID(_username);
            managerInfoUC s = new managerInfoUC(employeeID,_username);
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
            string connectionString = db.Connectstring() ;

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

        private void usedIngredientBtn_Click(object sender, EventArgs e)
        {
            managerUsedIngredient s = new managerUsedIngredient();
            showPanel.Controls.Clear();
            s.Dock = DockStyle.Fill;
            showPanel.Controls.Add(s);

            ResetButtonColors();
            usedPanel.Visible = true;
            Guna.UI2.WinForms.Guna2Button clickedButton = sender as Guna.UI2.WinForms.Guna2Button;
            if (clickedButton != null)
            {
                clickedButton.FillColor = Color.FromArgb(50, 58, 68);
                titleLabel.Text = "Used Ingredient";
            }
        }
    }
}
