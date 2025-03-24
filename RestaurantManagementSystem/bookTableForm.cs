using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class bookTableForm : Form
    {
        private mainFrm mainForm;
        public bookTableForm(mainFrm main)
        {
            InitializeComponent();
            this.mainForm = main;
            numberOfPeopleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            numberOfPeopleComboBox.SelectedIndex = 0;
        }
        private Regex emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);
        private Regex phoneRegex = new Regex(@"^\d+$", RegexOptions.Compiled);

        private void exitButton_Click(object sender, EventArgs e)
        {
            mainForm.Show(); 
            this.Close();
        }

        private void bookTableButton_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            // Kiểm tra Name
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                errorProvider1.SetError(nameTextBox, "The field is required.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(nameTextBox, "");
            }

            // Kiểm tra Email
            if (string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                errorProvider1.SetError(emailTextBox, "The field is required.");
                isValid = false;
            }
            else if (!emailRegex.IsMatch(emailTextBox.Text))
            {
                errorProvider1.SetError(emailTextBox, "The e-mail address entered is invalid.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(emailTextBox, "");
            }

            // Kiểm tra Phone
            if (string.IsNullOrWhiteSpace(phoneTextBox.Text))
            {
                errorProvider1.SetError(phoneTextBox, "The field is required.");
                isValid = false;
            }
            else if (!phoneRegex.IsMatch(phoneTextBox.Text))
            {
                errorProvider1.SetError(phoneTextBox, "The telephone number is invalid.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(phoneTextBox, "");
            }

            // Kiểm tra tổng hợp - nếu có lỗi, hiển thị label báo lỗi chung
            if (!isValid)
            {
                finalyLabel.Text = "One or more fields have an error. Please check and try again.";
                finalyLabel.ForeColor = Color.Orange;
                finalyLabel.Visible = true;
            }
            else
            {
                finalyLabel.Text = "Thank you for your message. It has been sent.";
                finalyLabel.ForeColor = Color.Green;
                finalyLabel.Visible = true;

            }
        }
    }
}
