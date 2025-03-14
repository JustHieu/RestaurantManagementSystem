using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RestaurantManagementSystem
{
    public partial class FirstForm : Form
    {


        public FirstForm()
        {
            InitializeComponent();
            homeButton.MouseEnter += HomeButton_MouseEnter;
            homeButton.MouseLeave += HomeButton_MouseLeave;
            aboutButton.MouseEnter += AboutButton_MouseEnter;
            aboutButton.MouseLeave += AboutButton_MouseLeave;
            menuButton.MouseEnter += MenuButton_MouseEnter;
            menuButton.MouseLeave += MenuButton_MouseLeave;
            contactButton.MouseEnter += ContactButton_MouseEnter;
            contactButton.MouseLeave += ContactButton_MouseLeave;

        }

        

        private void FirstForm_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {

        }
        private void HomeButton_MouseEnter(object sender, EventArgs e)
        {
            
            homeButton.ForeColor = Color.FromArgb(239, 116, 43);  
        }

        private void HomeButton_MouseLeave(object sender, EventArgs e)
        {
            homeButton.ForeColor = Color.White;  
        }
        private void AboutButton_MouseEnter(object sender, EventArgs e)
        {

            aboutButton.ForeColor = Color.FromArgb(239, 116, 43);
        }

        private void AboutButton_MouseLeave(object sender, EventArgs e)
        {
            aboutButton.ForeColor = Color.White;
        }
        private void MenuButton_MouseEnter(object sender, EventArgs e)
        {

            menuButton.ForeColor = Color.FromArgb(239, 116, 43);
        }

        private void MenuButton_MouseLeave(object sender, EventArgs e)
        {
            menuButton.ForeColor = Color.White;
        }
        private void ContactButton_MouseEnter(object sender, EventArgs e)
        {

            contactButton.ForeColor = Color.FromArgb(239, 116, 43);
        }

        private void ContactButton_MouseLeave(object sender, EventArgs e)
        {
            contactButton.ForeColor = Color.White;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {

        }
    }
}

