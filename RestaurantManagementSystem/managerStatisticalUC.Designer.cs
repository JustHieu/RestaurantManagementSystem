namespace RestaurantManagementSystem
{
    partial class managerStatisticalUC
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
            this.Labelq = new System.Windows.Forms.Label();
            this.expenditureLabel = new System.Windows.Forms.Label();
            this.revenueLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.fromDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statisticalButton = new Guna.UI2.WinForms.Guna2Button();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Labelq
            // 
            this.Labelq.AutoSize = true;
            this.Labelq.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelq.ForeColor = System.Drawing.Color.Red;
            this.Labelq.Location = new System.Drawing.Point(127, 419);
            this.Labelq.Name = "Labelq";
            this.Labelq.Size = new System.Drawing.Size(174, 27);
            this.Labelq.TabIndex = 50;
            this.Labelq.Text = "Total Expenditure:";
            // 
            // expenditureLabel
            // 
            this.expenditureLabel.AutoSize = true;
            this.expenditureLabel.Font = new System.Drawing.Font("Philosopher", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenditureLabel.ForeColor = System.Drawing.Color.Red;
            this.expenditureLabel.Location = new System.Drawing.Point(125, 472);
            this.expenditureLabel.Name = "expenditureLabel";
            this.expenditureLabel.Size = new System.Drawing.Size(32, 38);
            this.expenditureLabel.TabIndex = 51;
            this.expenditureLabel.Text = "$";
            // 
            // revenueLabel
            // 
            this.revenueLabel.AutoSize = true;
            this.revenueLabel.Font = new System.Drawing.Font("Philosopher", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueLabel.Location = new System.Drawing.Point(125, 656);
            this.revenueLabel.Name = "revenueLabel";
            this.revenueLabel.Size = new System.Drawing.Size(32, 38);
            this.revenueLabel.TabIndex = 53;
            this.revenueLabel.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 600);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 27);
            this.label2.TabIndex = 52;
            this.label2.Text = "Total Revenue:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 27);
            this.label1.TabIndex = 62;
            this.label1.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 27);
            this.label3.TabIndex = 61;
            this.label3.Text = "From:";
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.AutoRoundedCorners = true;
            this.toDateTimePicker.BackColor = System.Drawing.Color.White;
            this.toDateTimePicker.Checked = true;
            this.toDateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.toDateTimePicker.FillColor = System.Drawing.Color.WhiteSmoke;
            this.toDateTimePicker.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Bold);
            this.toDateTimePicker.ForeColor = System.Drawing.Color.Black;
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateTimePicker.Location = new System.Drawing.Point(161, 155);
            this.toDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.toDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(233, 42);
            this.toDateTimePicker.TabIndex = 60;
            this.toDateTimePicker.Value = new System.DateTime(2025, 3, 24, 0, 0, 0, 0);
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.AutoRoundedCorners = true;
            this.fromDateTimePicker.BackColor = System.Drawing.Color.White;
            this.fromDateTimePicker.Checked = true;
            this.fromDateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.fromDateTimePicker.FillColor = System.Drawing.Color.WhiteSmoke;
            this.fromDateTimePicker.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Bold);
            this.fromDateTimePicker.ForeColor = System.Drawing.Color.Black;
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateTimePicker.Location = new System.Drawing.Point(161, 70);
            this.fromDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.fromDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(233, 42);
            this.fromDateTimePicker.TabIndex = 59;
            this.fromDateTimePicker.Value = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.statisticalButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.toDateTimePicker);
            this.panel1.Controls.Add(this.fromDateTimePicker);
            this.panel1.Controls.Add(this.revenueLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.expenditureLabel);
            this.panel1.Controls.Add(this.Labelq);
            this.panel1.Location = new System.Drawing.Point(104, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 800);
            this.panel1.TabIndex = 63;
            // 
            // statisticalButton
            // 
            this.statisticalButton.AutoRoundedCorners = true;
            this.statisticalButton.BorderRadius = 23;
            this.statisticalButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.statisticalButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.statisticalButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.statisticalButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.statisticalButton.FillColor = System.Drawing.Color.RoyalBlue;
            this.statisticalButton.Font = new System.Drawing.Font("Philosopher", 10.2F, System.Drawing.FontStyle.Bold);
            this.statisticalButton.ForeColor = System.Drawing.Color.White;
            this.statisticalButton.Location = new System.Drawing.Point(94, 275);
            this.statisticalButton.Name = "statisticalButton";
            this.statisticalButton.Size = new System.Drawing.Size(266, 48);
            this.statisticalButton.TabIndex = 63;
            this.statisticalButton.Text = "STATISTICAL";
            this.statisticalButton.Click += new System.EventHandler(this.statisticalButton_Click);
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(624, 102);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(979, 800);
            this.cartesianChart1.TabIndex = 65;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // managerStatisticalUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.panel1);
            this.Name = "managerStatisticalUC";
            this.Size = new System.Drawing.Size(1675, 932);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Labelq;
        private System.Windows.Forms.Label expenditureLabel;
        private System.Windows.Forms.Label revenueLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker toDateTimePicker;
        private Guna.UI2.WinForms.Guna2DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Panel panel1;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private Guna.UI2.WinForms.Guna2Button statisticalButton;
    }
}
