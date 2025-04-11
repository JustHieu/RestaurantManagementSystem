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
        public int TableID { get; private set; }
        public event EventHandler OnTableSelected;
        public bool IsSelected { get; private set; }

        public void SetSelected(bool selected)
        {
            IsSelected = selected;
            this.BackColor = selected ? Color.LightBlue : Color.White;  // Đổi màu để biết bàn đang được chọn
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
    }
}
