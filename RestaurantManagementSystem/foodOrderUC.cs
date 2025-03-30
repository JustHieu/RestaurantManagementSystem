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
    
    public partial class foodOrderUC : UserControl
    {
        public string FoodName { get; private set; }
        public string FoodPrice { get; private set; }

        public event EventHandler OnAddClicked;
        public foodOrderUC()
        {
            InitializeComponent();
        }
        public void SetData(string name, string description, string price, Image image)
        {
            FoodName = name;
            FoodPrice = price;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            OnAddClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
