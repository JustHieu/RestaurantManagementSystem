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
            this.numberOfPeopleComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.timeDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.specialRequestsTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.phoneTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.nameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.bookTableButton.Location = new System.Drawing.Point(666, 721);
            this.bookTableButton.Name = "bookTableButton";
            this.bookTableButton.Size = new System.Drawing.Size(244, 52);
            this.bookTableButton.TabIndex = 37;
            this.bookTableButton.Text = "BOOK A TABLE NOW";
            this.bookTableButton.Click += new System.EventHandler(this.bookTableButton_Click);
            // 
            // numberOfPeopleComboBox
            // 
            this.numberOfPeopleComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numberOfPeopleComboBox.BorderColor = System.Drawing.Color.White;
            this.numberOfPeopleComboBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.numberOfPeopleComboBox.BorderThickness = 0;
            this.numberOfPeopleComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.numberOfPeopleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numberOfPeopleComboBox.FillColor = System.Drawing.Color.LightGray;
            this.numberOfPeopleComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numberOfPeopleComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numberOfPeopleComboBox.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Bold);
            this.numberOfPeopleComboBox.ForeColor = System.Drawing.Color.Black;
            this.numberOfPeopleComboBox.ItemHeight = 30;
            this.numberOfPeopleComboBox.Items.AddRange(new object[] {
            "1 Person",
            "2 Person",
            "3 Person",
            "4 Person",
            "5 Person",
            "6 Person",
            "7 Person",
            "8 Person"});
            this.numberOfPeopleComboBox.Location = new System.Drawing.Point(412, 341);
            this.numberOfPeopleComboBox.Name = "numberOfPeopleComboBox";
            this.numberOfPeopleComboBox.Size = new System.Drawing.Size(228, 36);
            this.numberOfPeopleComboBox.TabIndex = 30;
            // 
            // timeDateTimePicker
            // 
            this.timeDateTimePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timeDateTimePicker.BorderColor = System.Drawing.Color.White;
            this.timeDateTimePicker.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.timeDateTimePicker.Checked = true;
            this.timeDateTimePicker.CustomFormat = "hh:mm tt";
            this.timeDateTimePicker.FillColor = System.Drawing.Color.White;
            this.timeDateTimePicker.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Bold);
            this.timeDateTimePicker.ForeColor = System.Drawing.Color.Black;
            this.timeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeDateTimePicker.Location = new System.Drawing.Point(944, 341);
            this.timeDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timeDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timeDateTimePicker.Name = "timeDateTimePicker";
            this.timeDateTimePicker.ShowUpDown = true;
            this.timeDateTimePicker.Size = new System.Drawing.Size(228, 36);
            this.timeDateTimePicker.TabIndex = 32;
            this.timeDateTimePicker.Value = new System.DateTime(2025, 3, 24, 0, 0, 0, 0);
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateDateTimePicker.BorderColor = System.Drawing.Color.White;
            this.dateDateTimePicker.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.dateDateTimePicker.Checked = true;
            this.dateDateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.dateDateTimePicker.FillColor = System.Drawing.Color.White;
            this.dateDateTimePicker.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Bold);
            this.dateDateTimePicker.ForeColor = System.Drawing.Color.Black;
            this.dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDateTimePicker.Location = new System.Drawing.Point(682, 341);
            this.dateDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(228, 36);
            this.dateDateTimePicker.TabIndex = 31;
            this.dateDateTimePicker.Value = new System.DateTime(2025, 3, 24, 0, 0, 0, 0);
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
            // phoneTextBox
            // 
            this.phoneTextBox.BackColor = System.Drawing.Color.Silver;
            this.phoneTextBox.BorderColor = System.Drawing.Color.White;
            this.phoneTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.phoneTextBox.BorderThickness = 0;
            this.phoneTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTextBox.DefaultText = "";
            this.phoneTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoneTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneTextBox.FillColor = System.Drawing.Color.LightGray;
            this.phoneTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneTextBox.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Bold);
            this.phoneTextBox.ForeColor = System.Drawing.Color.Black;
            this.phoneTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneTextBox.Location = new System.Drawing.Point(944, 463);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.phoneTextBox.PlaceholderText = "Phone";
            this.phoneTextBox.SelectedText = "";
            this.phoneTextBox.Size = new System.Drawing.Size(228, 38);
            this.phoneTextBox.TabIndex = 35;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.Silver;
            this.emailTextBox.BorderColor = System.Drawing.Color.White;
            this.emailTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.emailTextBox.BorderThickness = 0;
            this.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextBox.DefaultText = "";
            this.emailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.FillColor = System.Drawing.Color.LightGray;
            this.emailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Bold);
            this.emailTextBox.ForeColor = System.Drawing.Color.Black;
            this.emailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.Location = new System.Drawing.Point(682, 463);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.emailTextBox.PlaceholderText = "Email";
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.Size = new System.Drawing.Size(228, 38);
            this.emailTextBox.TabIndex = 34;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.Silver;
            this.nameTextBox.BorderColor = System.Drawing.Color.White;
            this.nameTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.nameTextBox.BorderThickness = 0;
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.DefaultText = "";
            this.nameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.FillColor = System.Drawing.Color.LightGray;
            this.nameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTextBox.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Bold);
            this.nameTextBox.ForeColor = System.Drawing.Color.Black;
            this.nameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTextBox.Location = new System.Drawing.Point(410, 463);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.nameTextBox.PlaceholderText = "Your Name";
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.Size = new System.Drawing.Size(228, 38);
            this.nameTextBox.TabIndex = 33;
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
            this.label4.Font = new System.Drawing.Font("Luxury", 55.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(535, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(623, 117);
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
            this.Controls.Add(this.numberOfPeopleComboBox);
            this.Controls.Add(this.timeDateTimePicker);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.specialRequestsTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finalyLabel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "bookTableUC";
            this.Size = new System.Drawing.Size(1600, 877);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button bookTableButton;
        private Guna.UI2.WinForms.Guna2ComboBox numberOfPeopleComboBox;
        private Guna.UI2.WinForms.Guna2DateTimePicker timeDateTimePicker;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateDateTimePicker;
        private Guna.UI2.WinForms.Guna2TextBox specialRequestsTextBox;
        private Guna.UI2.WinForms.Guna2TextBox phoneTextBox;
        private Guna.UI2.WinForms.Guna2TextBox emailTextBox;
        private Guna.UI2.WinForms.Guna2TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label finalyLabel;
    }
}
