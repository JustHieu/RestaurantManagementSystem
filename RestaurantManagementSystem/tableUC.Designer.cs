namespace RestaurantManagementSystem
{
    partial class tableUC
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
            this.idLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.idTableLabel = new System.Windows.Forms.Label();
            this.addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.BackColor = System.Drawing.SystemColors.Window;
            this.idLabel.Font = new System.Drawing.Font("Philosopher", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.idLabel.Location = new System.Drawing.Point(76, 52);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(0, 37);
            this.idLabel.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Philosopher", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(-7, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 19;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 20;
            this.guna2CustomGradientPanel1.Controls.Add(this.addBtn);
            this.guna2CustomGradientPanel1.Controls.Add(this.idTableLabel);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Tan;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.BurlyWood;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Tan;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(12, 12);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(217, 133);
            this.guna2CustomGradientPanel1.TabIndex = 21;
            // 
            // idTableLabel
            // 
            this.idTableLabel.AutoSize = true;
            this.idTableLabel.BackColor = System.Drawing.Color.Transparent;
            this.idTableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTableLabel.Location = new System.Drawing.Point(65, 19);
            this.idTableLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idTableLabel.Name = "idTableLabel";
            this.idTableLabel.Size = new System.Drawing.Size(95, 36);
            this.idTableLabel.TabIndex = 20;
            this.idTableLabel.Text = "label2";
            // 
            // addBtn
            // 
            this.addBtn.AutoRoundedCorners = true;
            this.addBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBtn.BorderColor = System.Drawing.Color.Blue;
            this.addBtn.BorderRadius = 24;
            this.addBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addBtn.Font = new System.Drawing.Font("Philosopher", 10.8F);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(39, 69);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(151, 51);
            this.addBtn.TabIndex = 16;
            this.addBtn.Text = "CHECK";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // tableUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(20);
            this.Name = "tableUC";
            this.Size = new System.Drawing.Size(243, 157);
            this.Load += new System.EventHandler(this.tableUC_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Button addBtn;
        private System.Windows.Forms.Label idTableLabel;
    }
}
