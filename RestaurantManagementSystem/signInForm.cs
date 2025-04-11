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
    public partial class signInForm : Form
    {
        public signInForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            int radius = 33; 

            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.X, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }

        private void closeLoginForm_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            signUpForm signUpForm = new signUpForm();
            signUpForm.Show();
            
                signUpForm.FormClosed += (s, args) =>
                {
                    
                        this.Show();
                    
                };
            
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            string username = emailTextbox.Text.Trim();
            string password = passwordTextbox.Text.Trim();
            if (username == "a" && password == "123")
            {
                managerForm signUpForm = new managerForm();
                signUpForm.Show();
                this.Hide();  
                signUpForm.FormClosed += (s, args) => this.Show();
            }
            else if (username == "b" && password == "123")
            {
                staffForm staff = new staffForm();
                staff.Show();
                this.Hide();
                staff.FormClosed += (s, args) => this.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           


        }

        private void label3_Click(object sender, EventArgs e)
        {
            keyAccessFrom bookTable = new keyAccessFrom();
            bookTable.Show();
            this.Hide();
            bookTable.FormClosed += (s, args) => this.Show();
        }
    }
}
