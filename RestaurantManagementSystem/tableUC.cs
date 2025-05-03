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
    public partial class tableUC : UserControl
    {
        private bool isOccupied = false;

        public void SetStatus(bool occupied)
        {
            isOccupied = occupied;
            statusPanel.Invalidate(); // Gọi lại vẽ
        }

        public int TableID { get; private set; }
        public event EventHandler OnTableSelected;
        public bool IsSelected { get; private set; }

        public void SetSelected(bool selected)
        {
            IsSelected = selected;
            this.BackColor = selected ? Color.Black : Color.Black;  // Đổi màu để biết bàn đang được chọn
        }

        public tableUC()
        {
            InitializeComponent();
            //table11Button.Click += table11Button_Click;
        }

        public void SetTableID(int id)
        {
            TableID = id;
            idTableLabel.Text = "Table " + id.ToString();
        }

        private void table11Button_Click(object sender, EventArgs e)
        {
            //    table11Button.FillColor = Color.LightGray;
            //OnTableClicked.Invoke(this, TableId);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            SetSelected(true);
            OnTableSelected?.Invoke(this, EventArgs.Empty);
        }

        private void tableUC_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void statusPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Hình chữ nhật bo góc
            Rectangle rect = new Rectangle(0, 0, statusPanel.Width - 1, statusPanel.Height - 1);
            Color fillColor = isOccupied ? Color.LightGreen : Color.WhiteSmoke;
            Color circleColor = isOccupied ? Color.Green : Color.Red;
            Brush fillBrush = new SolidBrush(fillColor);
            Brush circleBrush = new SolidBrush(circleColor);

            g.FillRectangle(fillBrush, rect);

            // Vẽ hình tròn (switch thumb)
            int circleSize = statusPanel.Height - 4;
            int circleX = isOccupied ? rect.Width - circleSize - 2 : 2;
            int circleY = 2;
            g.FillEllipse(circleBrush, new Rectangle(circleX, circleY, circleSize, circleSize));
        }

        private void idTableLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
