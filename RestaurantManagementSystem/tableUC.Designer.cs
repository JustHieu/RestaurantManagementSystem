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
            this.idTableLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.BackColor = System.Drawing.SystemColors.Window;
            this.idLabel.Font = new System.Drawing.Font("Philosopher", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.idLabel.Location = new System.Drawing.Point(104, 78);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(0, 50);
            this.idLabel.TabIndex = 17;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBtn.BorderThickness = 2;
            this.addBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.addBtn.Font = new System.Drawing.Font("Philosopher", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.Black;
            this.addBtn.Location = new System.Drawing.Point(80, 181);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(172, 45);
            this.addBtn.TabIndex = 16;
            this.addBtn.Text = "CHECK";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Panel1.Controls.Add(this.idTableLabel);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.addBtn);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(328, 230);
            this.guna2Panel1.TabIndex = 19;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // idTableLabel
            // 
            this.idTableLabel.AutoSize = true;
            this.idTableLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTableLabel.ForeColor = System.Drawing.Color.Black;
            this.idTableLabel.Location = new System.Drawing.Point(3, 10);
            this.idTableLabel.Name = "idTableLabel";
            this.idTableLabel.Size = new System.Drawing.Size(155, 52);
            this.idTableLabel.TabIndex = 20;
            this.idTableLabel.Text = "label2";
            this.idTableLabel.Click += new System.EventHandler(this.idTableLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Philosopher", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(107, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 50);
            this.label1.TabIndex = 19;
            // 
            // statusPanel
            // 
            this.statusPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusPanel.Location = new System.Drawing.Point(249, 3);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(82, 39);
            this.statusPanel.TabIndex = 21;
            this.statusPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.statusPanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RestaurantManagementSystem.Properties.Resources.dining_room__2_1;
            this.pictureBox1.Location = new System.Drawing.Point(58, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tableUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.idLabel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(28, 30, 28, 30);
            this.Name = "tableUC";
            this.Size = new System.Drawing.Size(334, 236);
            this.Load += new System.EventHandler(this.tableUC_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private Guna.UI2.WinForms.Guna2Button addBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idTableLabel;
        private System.Windows.Forms.Panel statusPanel;
    }
}
