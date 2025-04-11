namespace RestaurantManagementSystem
{
    partial class staffTableStatusUC
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
            this.tablePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.payButton = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLabel = new System.Windows.Forms.Label();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.detailPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tablePanel
            // 
            this.tablePanel.AutoScroll = true;
            this.tablePanel.BackColor = System.Drawing.Color.White;
            this.tablePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablePanel.Location = new System.Drawing.Point(84, 90);
            this.tablePanel.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Padding = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.tablePanel.Size = new System.Drawing.Size(1329, 1063);
            this.tablePanel.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Philosopher", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(2121, 1098);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 45);
            this.label4.TabIndex = 72;
            this.label4.Text = "$";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalLabel.Font = new System.Drawing.Font("Philosopher", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalLabel.Location = new System.Drawing.Point(1966, 1098);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(40, 45);
            this.totalLabel.TabIndex = 71;
            this.totalLabel.Text = "0";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // payButton
            // 
            this.payButton.AutoRoundedCorners = true;
            this.payButton.BorderRadius = 35;
            this.payButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.payButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.payButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.payButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.payButton.FillColor = System.Drawing.Color.Green;
            this.payButton.Font = new System.Drawing.Font("Philosopher", 10.2F, System.Drawing.FontStyle.Bold);
            this.payButton.ForeColor = System.Drawing.Color.White;
            this.payButton.Location = new System.Drawing.Point(1431, 1081);
            this.payButton.Margin = new System.Windows.Forms.Padding(4);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(341, 72);
            this.payButton.TabIndex = 70;
            this.payButton.Text = "PAY MONEY";
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Philosopher", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(1856, 1098);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 45);
            this.label3.TabIndex = 68;
            this.label3.Text = "Total:";
            // 
            // tableLabel
            // 
            this.tableLabel.AutoSize = true;
            this.tableLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.tableLabel.Font = new System.Drawing.Font("Philosopher", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLabel.Location = new System.Drawing.Point(1720, 175);
            this.tableLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(196, 64);
            this.tableLabel.TabIndex = 65;
            this.tableLabel.Text = "TABLE 1";
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 50;
            this.guna2Button3.CustomizableEdges.BottomLeft = false;
            this.guna2Button3.CustomizableEdges.BottomRight = false;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.guna2Button3.Font = new System.Drawing.Font("Philosopher", 10.2F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(1431, 90);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(850, 249);
            this.guna2Button3.TabIndex = 64;
            // 
            // detailPanel
            // 
            this.detailPanel.Location = new System.Drawing.Point(1431, 338);
            this.detailPanel.Name = "detailPanel";
            this.detailPanel.Size = new System.Drawing.Size(850, 710);
            this.detailPanel.TabIndex = 73;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1431, 1160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 83);
            this.button1.TabIndex = 74;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // staffTableStatusUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.detailPanel);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableLabel);
            this.Controls.Add(this.guna2Button3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "staffTableStatusUC";
            this.Size = new System.Drawing.Size(2303, 1398);
            this.Load += new System.EventHandler(this.staffTableStatusUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel tablePanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalLabel;
        private Guna.UI2.WinForms.Guna2Button payButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tableLabel;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.FlowLayoutPanel detailPanel;
        private System.Windows.Forms.Button button1;
    }
}
