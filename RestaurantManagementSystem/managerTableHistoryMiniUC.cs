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
    public partial class managerTableHistoryMiniUC : UserControl
    {
        public managerTableHistoryMiniUC()
        {
            InitializeComponent();
            this.MouseEnter += new EventHandler(UserControl_MouseEnter);
            this.MouseLeave += new EventHandler(UserControl_MouseLeave);
        }
        public void setIdThanhToan(int id)
        {
            idThanhToan.Text = id.ToString();
        }
        public void Tag(int id)
        {
            idTable.Text = id.ToString();
        }
        public void setamount(decimal amount)
        {
            totalAmount.Text = amount.ToString();

        }
        public void setDate(DateTime date) { 
            time.Text = date.ToString();
        }
        private void UserControl_MouseEnter(object sender, EventArgs e)
        {
            
            this.BackColor = Color.FromArgb(209,209,209); 
        }

        private void UserControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White; 
        }
    }
}
