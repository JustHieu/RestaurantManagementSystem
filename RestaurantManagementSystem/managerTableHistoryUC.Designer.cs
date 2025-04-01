namespace RestaurantManagementSystem
{
    partial class managerTableHistoryUC
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.searchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.deleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.fromDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.toDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.seachButton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(85, 149);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1609, 767);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // searchTextBox
            // 
            this.searchTextBox.AutoRoundedCorners = true;
            this.searchTextBox.BorderRadius = 23;
            this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextBox.CustomizableEdges.BottomRight = false;
            this.searchTextBox.CustomizableEdges.TopRight = false;
            this.searchTextBox.DefaultText = "";
            this.searchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextBox.Location = new System.Drawing.Point(841, 67);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PlaceholderText = "Search";
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.Size = new System.Drawing.Size(378, 48);
            this.searchTextBox.TabIndex = 45;
            // 
            // deleteButton
            // 
            this.deleteButton.AutoRoundedCorners = true;
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.BorderRadius = 23;
            this.deleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteButton.Font = new System.Drawing.Font("Philosopher", 10.2F, System.Drawing.FontStyle.Bold);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(1503, 76);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(191, 48);
            this.deleteButton.TabIndex = 48;
            this.deleteButton.Text = "DELETE";
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.AutoRoundedCorners = true;
            this.fromDateTimePicker.BackColor = System.Drawing.SystemColors.Control;
            this.fromDateTimePicker.Checked = true;
            this.fromDateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.fromDateTimePicker.CustomizableEdges.BottomLeft = false;
            this.fromDateTimePicker.CustomizableEdges.BottomRight = false;
            this.fromDateTimePicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fromDateTimePicker.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Bold);
            this.fromDateTimePicker.ForeColor = System.Drawing.Color.White;
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateTimePicker.Location = new System.Drawing.Point(160, 110);
            this.fromDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.fromDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(233, 42);
            this.fromDateTimePicker.TabIndex = 55;
            this.fromDateTimePicker.Value = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.AutoRoundedCorners = true;
            this.toDateTimePicker.BackColor = System.Drawing.SystemColors.Control;
            this.toDateTimePicker.Checked = true;
            this.toDateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.toDateTimePicker.CustomizableEdges.BottomLeft = false;
            this.toDateTimePicker.CustomizableEdges.BottomRight = false;
            this.toDateTimePicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toDateTimePicker.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Bold);
            this.toDateTimePicker.ForeColor = System.Drawing.Color.White;
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateTimePicker.Location = new System.Drawing.Point(479, 110);
            this.toDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.toDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(233, 42);
            this.toDateTimePicker.TabIndex = 56;
            this.toDateTimePicker.Value = new System.DateTime(2025, 3, 24, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 27);
            this.label1.TabIndex = 57;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(433, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 27);
            this.label2.TabIndex = 58;
            this.label2.Text = "To:";
            // 
            // seachButton
            // 
            this.seachButton.AutoRoundedCorners = true;
            this.seachButton.CustomizableEdges.BottomLeft = false;
            this.seachButton.CustomizableEdges.TopLeft = false;
            this.seachButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.seachButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.seachButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.seachButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.seachButton.FillColor = System.Drawing.Color.Gainsboro;
            this.seachButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.seachButton.ForeColor = System.Drawing.Color.White;
            this.seachButton.Image = global::RestaurantManagementSystem.Properties.Resources.search;
            this.seachButton.Location = new System.Drawing.Point(1216, 67);
            this.seachButton.Name = "seachButton";
            this.seachButton.Size = new System.Drawing.Size(94, 48);
            this.seachButton.TabIndex = 46;
            // 
            // managerTableHistoryUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.seachButton);
            this.Controls.Add(this.listView1);
            this.Name = "managerTableHistoryUC";
            this.Size = new System.Drawing.Size(1675, 932);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private Guna.UI2.WinForms.Guna2TextBox searchTextBox;
        private Guna.UI2.WinForms.Guna2Button seachButton;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
        private Guna.UI2.WinForms.Guna2DateTimePicker fromDateTimePicker;
        private Guna.UI2.WinForms.Guna2DateTimePicker toDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
