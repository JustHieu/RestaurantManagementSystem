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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNV1DataSet3.DIADIEM_PHONG' table. You can move, or remove it, as needed.
            this.dIADIEM_PHONGTableAdapter1.Fill(this.qLNV1DataSet3.DIADIEM_PHONG);
            // TODO: This line of code loads data into the 'qLNV1DataSet1.DIADIEM_PHONG' table. You can move, or remove it, as needed.
            this.dIADIEM_PHONGTableAdapter.Fill(this.qLNV1DataSet1.DIADIEM_PHONG);

        }
    }
}
