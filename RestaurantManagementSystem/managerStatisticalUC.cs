using LiveCharts.Wpf;
using LiveCharts;
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
    public partial class managerStatisticalUC : UserControl
    {
        public managerStatisticalUC()
        {
            InitializeComponent();
            statisticalButton.Click += statisticalButton_Click;
        }

        private void LoadChart()
        {
         
        }

        private void statisticalButton_Click(object sender, EventArgs e)
        {
            LoadChart();
        }
    }
}
