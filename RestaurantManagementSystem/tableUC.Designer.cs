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
            this.addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.idTableLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
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
            // addBtn
            // 
            this.addBtn.AutoRoundedCorners = true;
            this.addBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBtn.BorderColor = System.Drawing.SystemColors.Window;
            this.addBtn.BorderThickness = 2;
            this.addBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.addBtn.Font = new System.Drawing.Font("SF Pro Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(49, 117);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(160, 38);
            this.addBtn.TabIndex = 16;
            this.addBtn.Text = "CHECK";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.statusPanel);
            this.guna2Panel1.Controls.Add(this.addBtn);
            this.guna2Panel1.Controls.Add(this.idTableLabel);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(262, 170);
            this.guna2Panel1.TabIndex = 19;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // statusPanel
            // 
            this.statusPanel.BackColor = System.Drawing.Color.Transparent;
            this.statusPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.statusPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusPanel.Location = new System.Drawing.Point(190, 12);
            this.statusPanel.Margin = new System.Windows.Forms.Padding(2);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(60, 27);
            this.statusPanel.TabIndex = 21;
            this.statusPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.statusPanel_Paint);
            // 
            // idTableLabel
            // 
            this.idTableLabel.BackColor = System.Drawing.Color.Transparent;
            this.idTableLabel.Font = new System.Drawing.Font("SF Pro Display", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTableLabel.ForeColor = System.Drawing.Color.Black;
            this.idTableLabel.Location = new System.Drawing.Point(52, 52);
            this.idTableLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idTableLabel.Name = "idTableLabel";
            this.idTableLabel.Size = new System.Drawing.Size(167, 46);
            this.idTableLabel.TabIndex = 20;
            this.idTableLabel.Text = "label2";
            this.idTableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.idTableLabel.Click += new System.EventHandler(this.idTableLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Philosopher", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(78, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 19;
            // 
            // tableUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.idLabel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(20);
            this.Name = "tableUC";
            this.Size = new System.Drawing.Size(262, 170);
            this.Load += new System.EventHandler(this.tableUC_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private Guna.UI2.WinForms.Guna2Button addBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idTableLabel;
        private System.Windows.Forms.Panel statusPanel;
    }
}
