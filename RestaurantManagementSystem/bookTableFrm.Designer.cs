namespace RestaurantManagementSystem
{
    partial class bookTableFrm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookTableFrm));
            this.menuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.completeButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.orderPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.seachButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.AutoScroll = true;
            this.menuPanel.Location = new System.Drawing.Point(46, 322);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1813, 1184);
            this.menuPanel.TabIndex = 0;
            this.menuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.menuPanel_Paint);
            // 
            // searchTextBox
            // 
            this.searchTextBox.AutoRoundedCorners = true;
            this.searchTextBox.BorderRadius = 43;
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
            this.searchTextBox.Location = new System.Drawing.Point(629, 215);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PlaceholderText = "Search";
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.Size = new System.Drawing.Size(710, 88);
            this.searchTextBox.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.label1.Font = new System.Drawing.Font("Philosopher", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1987, 358);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 64);
            this.label1.TabIndex = 66;
            this.label1.Text = "NEW ORDER";
            // 
            // completeButton
            // 
            this.completeButton.AutoRoundedCorners = true;
            this.completeButton.BorderRadius = 35;
            this.completeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.completeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.completeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.completeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.completeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.completeButton.Font = new System.Drawing.Font("Philosopher", 10.2F, System.Drawing.FontStyle.Bold);
            this.completeButton.ForeColor = System.Drawing.Color.White;
            this.completeButton.Location = new System.Drawing.Point(2151, 1488);
            this.completeButton.Margin = new System.Windows.Forms.Padding(4);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(341, 72);
            this.completeButton.TabIndex = 72;
            this.completeButton.Text = "COMPLETE";
            this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
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
            this.guna2Button3.Location = new System.Drawing.Point(1928, 322);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(749, 254);
            this.guna2Button3.TabIndex = 65;
            // 
            // orderPanel
            // 
            this.orderPanel.BackColor = System.Drawing.Color.White;
            this.orderPanel.Location = new System.Drawing.Point(1928, 573);
            this.orderPanel.Name = "orderPanel";
            this.orderPanel.Size = new System.Drawing.Size(749, 891);
            this.orderPanel.TabIndex = 73;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.guna2Panel1.Location = new System.Drawing.Point(-2, -2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(3016, 135);
            this.guna2Panel1.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("SF Pro Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(1234, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(603, 67);
            this.label4.TabIndex = 75;
            this.label4.Text = "Welcome to Your Table";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
            this.pictureBox2.Image = global::RestaurantManagementSystem.Properties.Resources.avt2;
            this.pictureBox2.Location = new System.Drawing.Point(2349, 358);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(261, 165);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 76;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2748, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.seachButton.FillColor = System.Drawing.SystemColors.ActiveBorder;
            this.seachButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.seachButton.ForeColor = System.Drawing.Color.White;
            this.seachButton.Image = global::RestaurantManagementSystem.Properties.Resources.search;
            this.seachButton.Location = new System.Drawing.Point(1337, 215);
            this.seachButton.Margin = new System.Windows.Forms.Padding(4);
            this.seachButton.Name = "seachButton";
            this.seachButton.Size = new System.Drawing.Size(133, 88);
            this.seachButton.TabIndex = 49;
            // 
            // bookTableFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(2908, 1602);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.orderPanel);
            this.Controls.Add(this.completeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.seachButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bookTableFrm";
            this.Text = "bookTableFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.bookTableFrm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel menuPanel;
        private Guna.UI2.WinForms.Guna2TextBox searchTextBox;
        private Guna.UI2.WinForms.Guna2Button seachButton;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button completeButton;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.FlowLayoutPanel orderPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}