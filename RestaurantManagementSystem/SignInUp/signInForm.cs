using RestaurantManagementSystem.SignInUp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class signInForm : Form
    {
        public signInForm()
        {
            InitializeComponent();
            check.MouseEnter += Label3_MouseEnter;
            check.MouseLeave += Label3_MouseLeave;
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
            string role = LoginService.GetUserRole(username, password);

            if (role != null)
            {
                switch (role)
                {
                    case "Manager":
                        managerForm managerForm = new managerForm(username);
                        managerForm.Show();
                        this.Hide(); 
                        managerForm.FormClosed += (s, args) => this.Show();
                        break;

                    case "Staff":
                        staffForm staffForm = new staffForm(username);
                        staffForm.Show();
                        this.Hide(); 
                        staffForm.FormClosed += (s, args) => this.Show();
                        break;

                    case "Customer":
                        
                        break;

                    default:
                        MessageBox.Show("Invalid role!");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Incorrect username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {
            keyAccessFrom bookTable = new keyAccessFrom();
            bookTable.Show();
            this.Hide();
            bookTable.FormClosed += (s, args) => this.Show();
        }
        private void Label3_MouseEnter(object sender, EventArgs e)
        {

            check.ForeColor = Color.FromArgb(28, 39, 49);
        }

        private void Label3_MouseLeave(object sender, EventArgs e)
        {
            check.ForeColor = Color.FromArgb(180, 180, 180);
        }
    }
}
