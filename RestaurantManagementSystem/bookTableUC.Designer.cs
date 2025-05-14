namespace RestaurantManagementSystem
{
    partial class bookTableUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bookTableButton = new Guna.UI2.WinForms.Guna2Button();
            this.comboBoxPersonNumber = new Guna.UI2.WinForms.Guna2ComboBox();
            this.timePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.datePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.specialRequestsTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.finalyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookTableButton
            // 
            this.bookTableButton.AutoRoundedCorners = true;
            this.bookTableButton.BackColor = System.Drawing.Color.Transparent;
            this.bookTableButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bookTableButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bookTableButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bookTableButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bookTableButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(0)))));
            this.bookTableButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.bookTableButton.ForeColor = System.Drawing.Color.White;
            this.bookTableButton.Location = new System.Drawing.Point(666, 713);
            this.bookTableButton.Name = "bookTableButton";
            this.bookTableButton.Size = new System.Drawing.Size(244, 52);
            this.bookTableButton.TabIndex = 37;
            this.bookTableButton.Text = "BOOK A TABLE NOW";
            this.bookTableButton.Click += new System.EventHandler(this.bookTableButton_Click);
            // 
            // comboBoxPersonNumber
            // 
            this.comboBoxPersonNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxPersonNumber.BorderColor = System.Drawing.Color.White;
            this.comboBoxPersonNumber.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.comboBoxPersonNumber.BorderThickness = 0;
            this.comboBoxPersonNumber.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxPersonNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPersonNumber.FillColor = System.Drawing.Color.LightGray;
            this.comboBoxPersonNumber.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxPersonNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxPersonNumber.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxPersonNumber.ForeColor = System.Drawing.Color.Black;
            this.comboBoxPersonNumber.ItemHeight = 30;
            this.comboBoxPersonNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4 ",
            "5",
            "6 ",
            "7 ",
            "8 "});
            this.comboBoxPersonNumber.Location = new System.Drawing.Point(412, 341);
            this.comboBoxPersonNumber.Name = "comboBoxPersonNumber";
            this.comboBoxPersonNumber.Size = new System.Drawing.Size(228, 36);
            this.comboBoxPersonNumber.TabIndex = 30;
            // 
            // timePicker
            // 
            this.timePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timePicker.BorderColor = System.Drawing.Color.White;
            this.timePicker.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.timePicker.Checked = true;
            this.timePicker.CustomFormat = "hh:mm tt";
            this.timePicker.FillColor = System.Drawing.Color.White;
            this.timePicker.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Bold);
            this.timePicker.ForeColor = System.Drawing.Color.Black;
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(944, 341);
            this.timePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(228, 36);
            this.timePicker.TabIndex = 32;
            this.timePicker.Value = new System.DateTime(2025, 3, 24, 0, 0, 0, 0);
            // 
            // datePicker
            // 
            this.datePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.datePicker.BorderColor = System.Drawing.Color.White;
            this.datePicker.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.datePicker.Checked = true;
            this.datePicker.CustomFormat = "MM/dd/yyyy";
            this.datePicker.FillColor = System.Drawing.Color.White;
            this.datePicker.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Bold);
            this.datePicker.ForeColor = System.Drawing.Color.Black;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(682, 341);
            this.datePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(228, 36);
            this.datePicker.TabIndex = 31;
            this.datePicker.Value = new System.DateTime(2025, 4, 4, 0, 0, 0, 0);
            // 
            // specialRequestsTextBox
            // 
            this.specialRequestsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.specialRequestsTextBox.BorderColor = System.Drawing.Color.White;
            this.specialRequestsTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.specialRequestsTextBox.BorderThickness = 0;
            this.specialRequestsTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.specialRequestsTextBox.DefaultText = "";
            this.specialRequestsTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.specialRequestsTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.specialRequestsTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.specialRequestsTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.specialRequestsTextBox.FillColor = System.Drawing.Color.LightGray;
            this.specialRequestsTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.specialRequestsTextBox.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Bold);
            this.specialRequestsTextBox.ForeColor = System.Drawing.Color.Black;
            this.specialRequestsTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.specialRequestsTextBox.Location = new System.Drawing.Point(410, 586);
            this.specialRequestsTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.specialRequestsTextBox.Name = "specialRequestsTextBox";
            this.specialRequestsTextBox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.specialRequestsTextBox.PlaceholderText = "Special Requests";
            this.specialRequestsTextBox.SelectedText = "";
            this.specialRequestsTextBox.Size = new System.Drawing.Size(762, 87);
            this.specialRequestsTextBox.TabIndex = 36;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Silver;
            this.txtPhone.BorderColor = System.Drawing.Color.White;
            this.txtPhone.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txtPhone.BorderThickness = 0;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FillColor = System.Drawing.Color.LightGray;
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Bold);
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Location = new System.Drawing.Point(847, 463);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtPhone.PlaceholderText = "Phone";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(228, 38);
            this.txtPhone.TabIndex = 35;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Silver;
            this.txtName.BorderColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txtName.BorderThickness = 0;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FillColor = System.Drawing.Color.LightGray;
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Bold);
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(527, 463);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtName.PlaceholderText = "Your Name";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(228, 38);
            this.txtName.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(560, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 28;
            this.label2.Text = "________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 55.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(535, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(603, 104);
            this.label4.TabIndex = 27;
            this.label4.Text = "Book A Table";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(930, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 26;
            this.label3.Text = "________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(677, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "ONLINE RESERVATION\r\n";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // finalyLabel
            // 
            this.finalyLabel.AutoSize = true;
            this.finalyLabel.BackColor = System.Drawing.Color.Transparent;
            this.finalyLabel.Font = new System.Drawing.Font("Philosopher", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalyLabel.Location = new System.Drawing.Point(408, 792);
            this.finalyLabel.Name = "finalyLabel";
            this.finalyLabel.Size = new System.Drawing.Size(255, 23);
            this.finalyLabel.TabIndex = 38;
            this.finalyLabel.Text = "-----------------------------------\r\n";
            this.finalyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.finalyLabel.Visible = false;
            // 
            // bookTableUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::RestaurantManagementSystem.Properties.Resources.menuBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.bookTableButton);
            this.Controls.Add(this.comboBoxPersonNumber);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.specialRequestsTextBox);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finalyLabel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "bookTableUC";
            this.Size = new System.Drawing.Size(1600, 877);
            this.Load += new System.EventHandler(this.bookTableUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button bookTableButton;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxPersonNumber;
        private Guna.UI2.WinForms.Guna2DateTimePicker timePicker;
        private Guna.UI2.WinForms.Guna2DateTimePicker datePicker;
        private Guna.UI2.WinForms.Guna2TextBox specialRequestsTextBox;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label finalyLabel;
    }
}
