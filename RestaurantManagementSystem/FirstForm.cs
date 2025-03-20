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

        public event EventHandler ShowOtherUserControl;
        public FirstForm()
        {
            InitializeComponent();
           

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
        
        private void menuButton_Click(object sender, EventArgs e)
        {

        }

        private void aboutUsButton_Click(object sender, EventArgs e)
        {
            mainFrm mainFrm = new mainFrm();
            
        }
        
    }
}

