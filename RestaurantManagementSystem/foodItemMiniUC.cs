﻿using System;
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
    public partial class foodItemMiniUC : UserControl
    {
        public foodItemMiniUC()
        {
            InitializeComponent();
        }
        public void SetData(string name, string description, string price)
        {

            lblDescription.Text = description;
            lblName.Text = name;
            lblPrice.Text = price;
        }
    }
}
