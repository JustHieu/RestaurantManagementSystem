using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class managerForm : Form
    {
        public managerForm()
        {
            InitializeComponent();
            menuButton_Click(null, EventArgs.Empty);
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
            managerTableHistoryUC ts = new managerTableHistoryUC();
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
            menuPanel.Visible = false;
            tableStatusPanel.Visible = false;
            coldStoragePanel.Visible = false;
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
                titleLabel.Text = "MANAGE STEFF";
            }
        }

        private void statisticalButton_Click(object sender, EventArgs e)
        {
            managerStatisticalUC s = new managerStatisticalUC();
            showPanel.Controls.Clear();
            s.Dock = DockStyle.Fill;
            showPanel.Controls.Add(s);

            ResetButtonColors();
            statisticalPanel.Visible = true;
            Guna.UI2.WinForms.Guna2Button clickedButton = sender as Guna.UI2.WinForms.Guna2Button;
            if (clickedButton != null)
            {
                clickedButton.FillColor = Color.FromArgb(50, 58, 68);
                titleLabel.Text = "MANAGE STEFF";
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
