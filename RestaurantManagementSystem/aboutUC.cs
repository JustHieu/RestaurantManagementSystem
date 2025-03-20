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
    public partial class aboutUC : UserControl
    {
        private Timer resizeTimer;
        private int targetWidth;
        private int targetHeight;
        private int targetX;
        private int targetY;
        public aboutUC()
        {
            InitializeComponent();
            aboutPic.MouseEnter += AboutPic_MouseEnter;
            aboutPic.MouseLeave += AboutPic_MouseLeave;
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void aboutUC_Load(object sender, EventArgs e)
        {

        }
        private void AboutPic_MouseEnter(object sender, EventArgs e)
        {
            aboutPic.Size = new Size(aboutPic.Width + 39, aboutPic.Height + 26);
            aboutPic.Location = new Point(
                aboutPic.Location.X - 19,
                aboutPic.Location.Y - 13
            );
        }

        // Sự kiện khi chuột rời khỏi PictureBox
        private void AboutPic_MouseLeave(object sender, EventArgs e)
        {
            aboutPic.Size = new Size(aboutPic.Width - 39, aboutPic.Height - 26);
            aboutPic.Location = new Point(
                aboutPic.Location.X + 19,
                aboutPic.Location.Y + 13
            );
        }
        
    }
}
