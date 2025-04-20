using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class signUpForm : Form
    {
        public bool formCheck = false;

        public signUpForm()
        {
            InitializeComponent();
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

        }
    }
}
