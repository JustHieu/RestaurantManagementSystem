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
    public partial class mainFrm : Form
    {
        public mainFrm()
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

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void homeButton_Click(object sender, EventArgs e)
        {
            FirstForm firstForm = new FirstForm();
            firstForm.ShowOtherUserControl += FirstForm_ShowInMainFormPanel;  // Đăng ký sự kiện
            firstForm.ShowBookTableUserControl += FirstForm_ShowBookTableUserControl;
            ShowFormInPanel(firstForm);
        }

        private void FirstForm_ShowBookTableUserControl(object sender, EventArgs e)
        {
            showFrm.Controls.Clear();
            bookTableUC bform = new bookTableUC();
            bform.Dock = DockStyle.Fill;
            showFrm.Controls.Add(bform);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ShowFormInPanel(Form form)
        {
            showFrm.Controls.Clear(); // Xóa các form cũ
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            showFrm.Controls.Add(form);
            form.Show();
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {

            FirstForm firstForm = new FirstForm();
            firstForm.ShowOtherUserControl += FirstForm_ShowInMainFormPanel;  // Đăng ký sự kiện
            firstForm.ShowBookTableUserControl += FirstForm_ShowBookTableUserControl;
            ShowFormInPanel(firstForm);
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            ShowUserControl(new aboutUC());
        }
        private void ShowUserControl(UserControl userControl)
        {
            showFrm.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            showFrm.Controls.Add(userControl);
        }
        private void FirstForm_ShowInMainFormPanel(object sender, EventArgs e)
        {
            // Xóa bất kỳ Form nào đang có trong Panel
            showFrm.Controls.Clear();

            // Tạo và hiển thị UserControl trong Panel của MainForm
            aboutUC aboutUserControl = new aboutUC();
            aboutUserControl.Dock = DockStyle.Fill;
            showFrm.Controls.Add(aboutUserControl);
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            menuUC menu = new menuUC();
            showFrm.Controls.Clear();
            menu.Dock = DockStyle.Fill;
            showFrm.Controls.Add(menu);
        }

        private void contactButton_Click(object sender, EventArgs e)
        {
            contactUC contact = new contactUC();
            showFrm.Controls.Clear();
            contact.Dock = DockStyle.Fill;
            showFrm.Controls.Add(contact);
        }

        private void bookTableButton_Click(object sender, EventArgs e)
        {
            bookTableUC bform = new bookTableUC();
            showFrm.Controls.Clear();
            bform.Dock = DockStyle.Fill;
            showFrm.Controls.Add(bform);
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            signInForm loginForm = new signInForm();

            // Khi đóng loginForm, form này (this) sẽ Show trở lại
            
            this.Hide();
            loginForm.Show();
            loginForm.FormClosed += (s, args) =>
            {
                this.Show();
            };

        }
    }
}
