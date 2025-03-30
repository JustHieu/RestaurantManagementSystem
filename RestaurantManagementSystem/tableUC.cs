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
        public int TableId { get; private set; }
        public bool State { get; private set; }

        public event EventHandler<int> OnTableClicked;

        public tableUC()
        {
            InitializeComponent();
            table11Button.Click += table11Button_Click;
        }

        public void SetData(Table table)
        {
            TableId = table.IdTable;
            State = table.StateTable;
            if (State)
            {
                table11Button.FillColor = Color.Red;
            }
            else
            {
                table11Button.FillColor = Color.FromArgb(74, 48, 55);
            }
            table11Button.Text = "Table " + TableId;
        }

        private void table11Button_Click(object sender, EventArgs e)
        {
            //    table11Button.FillColor = Color.LightGray;
            OnTableClicked.Invoke(this, TableId);
        }
    }
}
