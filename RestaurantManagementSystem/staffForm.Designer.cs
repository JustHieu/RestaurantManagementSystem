namespace RestaurantManagementSystem
{
    partial class staffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffForm));
            this.showPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.accountLabel = new System.Windows.Forms.Label();
            this.menuPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.kitchenPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.tableStatusPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.notificationButton = new System.Windows.Forms.Button();
            this.accontPictureBox = new System.Windows.Forms.PictureBox();
            this.quitButton = new System.Windows.Forms.Button();
            this.kitchenButton = new Guna.UI2.WinForms.Guna2Button();
            this.tableStatusButton = new Guna.UI2.WinForms.Guna2Button();
            this.menuButton = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.logOutButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accontPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // showPanel
            // 
            this.showPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.showPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showPanel.Location = new System.Drawing.Point(352, 114);
            this.showPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showPanel.Name = "showPanel";
            this.showPanel.Size = new System.Drawing.Size(2269, 1398);
            this.showPanel.TabIndex = 21;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(26, 27);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(160, 57);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "MENU";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.notificationButton);
            this.panel1.Controls.Add(this.accountLabel);
            this.panel1.Controls.Add(this.accontPictureBox);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Controls.Add(this.quitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(352, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2269, 114);
            this.panel1.TabIndex = 20;
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountLabel.ForeColor = System.Drawing.Color.White;
            this.accountLabel.Location = new System.Drawing.Point(1914, 38);
            this.accountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(97, 38);
            this.accountLabel.TabIndex = 13;
            this.accountLabel.Text = "STAFF";
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.menuPanel.Location = new System.Drawing.Point(4, 297);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(14, 105);
            this.menuPanel.TabIndex = 11;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.guna2Panel3.Controls.Add(this.kitchenPanel);
            this.guna2Panel3.Controls.Add(this.tableStatusPanel);
            this.guna2Panel3.Controls.Add(this.menuPanel);
            this.guna2Panel3.Controls.Add(this.kitchenButton);
            this.guna2Panel3.Controls.Add(this.tableStatusButton);
            this.guna2Panel3.Controls.Add(this.menuButton);
            this.guna2Panel3.Controls.Add(this.pictureBox2);
            this.guna2Panel3.Controls.Add(this.logOutButton);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(352, 1512);
            this.guna2Panel3.TabIndex = 19;
            this.guna2Panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel3_Paint);
            // 
            // kitchenPanel
            // 
            this.kitchenPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kitchenPanel.Location = new System.Drawing.Point(4, 525);
            this.kitchenPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kitchenPanel.Name = "kitchenPanel";
            this.kitchenPanel.Size = new System.Drawing.Size(14, 105);
            this.kitchenPanel.TabIndex = 17;
            this.kitchenPanel.Visible = false;
            // 
            // tableStatusPanel
            // 
            this.tableStatusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tableStatusPanel.Location = new System.Drawing.Point(4, 411);
            this.tableStatusPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableStatusPanel.Name = "tableStatusPanel";
            this.tableStatusPanel.Size = new System.Drawing.Size(14, 105);
            this.tableStatusPanel.TabIndex = 15;
            this.tableStatusPanel.Visible = false;
            // 
            // notificationButton
            // 
            this.notificationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.notificationButton.FlatAppearance.BorderSize = 0;
            this.notificationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notificationButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.notificationButton.Image = global::RestaurantManagementSystem.Properties.Resources.bell;
            this.notificationButton.Location = new System.Drawing.Point(2126, 21);
            this.notificationButton.Margin = new System.Windows.Forms.Padding(4);
            this.notificationButton.Name = "notificationButton";
            this.notificationButton.Size = new System.Drawing.Size(63, 68);
            this.notificationButton.TabIndex = 19;
            this.notificationButton.UseVisualStyleBackColor = true;
            // 
            // accontPictureBox
            // 
            this.accontPictureBox.Image = global::RestaurantManagementSystem.Properties.Resources.user1;
            this.accontPictureBox.Location = new System.Drawing.Point(1823, 10);
            this.accontPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.accontPictureBox.Name = "accontPictureBox";
            this.accontPictureBox.Size = new System.Drawing.Size(82, 87);
            this.accontPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.accontPictureBox.TabIndex = 12;
            this.accontPictureBox.TabStop = false;
            // 
            // quitButton
            // 
            this.quitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.quitButton.FlatAppearance.BorderSize = 0;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.quitButton.Image = global::RestaurantManagementSystem.Properties.Resources.quit;
            this.quitButton.Location = new System.Drawing.Point(2232, 21);
            this.quitButton.Margin = new System.Windows.Forms.Padding(4);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(63, 68);
            this.quitButton.TabIndex = 7;
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // kitchenButton
            // 
            this.kitchenButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.kitchenButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.kitchenButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.kitchenButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.kitchenButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.kitchenButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitchenButton.ForeColor = System.Drawing.Color.White;
            this.kitchenButton.Image = global::RestaurantManagementSystem.Properties.Resources.hat_chef;
            this.kitchenButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.kitchenButton.ImageOffset = new System.Drawing.Point(20, 0);
            this.kitchenButton.Location = new System.Drawing.Point(0, 525);
            this.kitchenButton.Margin = new System.Windows.Forms.Padding(4);
            this.kitchenButton.Name = "kitchenButton";
            this.kitchenButton.Size = new System.Drawing.Size(352, 105);
            this.kitchenButton.TabIndex = 18;
            this.kitchenButton.Text = "Kitchen";
            this.kitchenButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.kitchenButton.TextOffset = new System.Drawing.Point(30, 0);
            this.kitchenButton.Click += new System.EventHandler(this.kitchenButton_Click);
            // 
            // tableStatusButton
            // 
            this.tableStatusButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tableStatusButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tableStatusButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tableStatusButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tableStatusButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.tableStatusButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableStatusButton.ForeColor = System.Drawing.Color.White;
            this.tableStatusButton.Image = global::RestaurantManagementSystem.Properties.Resources.apps;
            this.tableStatusButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tableStatusButton.ImageOffset = new System.Drawing.Point(20, 0);
            this.tableStatusButton.Location = new System.Drawing.Point(0, 411);
            this.tableStatusButton.Margin = new System.Windows.Forms.Padding(4);
            this.tableStatusButton.Name = "tableStatusButton";
            this.tableStatusButton.Size = new System.Drawing.Size(352, 105);
            this.tableStatusButton.TabIndex = 16;
            this.tableStatusButton.Text = "Table Status";
            this.tableStatusButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tableStatusButton.TextOffset = new System.Drawing.Point(30, 0);
            this.tableStatusButton.Click += new System.EventHandler(this.tableStatusButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.menuButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.menuButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.menuButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.menuButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.menuButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.menuButton.ForeColor = System.Drawing.Color.White;
            this.menuButton.Image = global::RestaurantManagementSystem.Properties.Resources.book_alt;
            this.menuButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.menuButton.ImageOffset = new System.Drawing.Point(20, 0);
            this.menuButton.Location = new System.Drawing.Point(0, 297);
            this.menuButton.Margin = new System.Windows.Forms.Padding(4);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(352, 105);
            this.menuButton.TabIndex = 14;
            this.menuButton.Text = "Menu";
            this.menuButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.menuButton.TextOffset = new System.Drawing.Point(30, 0);
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(352, 288);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // logOutButton
            // 
            this.logOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Philosopher", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logOutButton.Image = global::RestaurantManagementSystem.Properties.Resources.exit;
            this.logOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutButton.Location = new System.Drawing.Point(55, 1444);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(202, 68);
            this.logOutButton.TabIndex = 4;
            this.logOutButton.Text = "LOG OUT";
            this.logOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // staffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2621, 1512);
            this.Controls.Add(this.showPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "staffForm";
            this.Text = "staffForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accontPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel showPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button notificationButton;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.PictureBox accontPictureBox;
        private System.Windows.Forms.Button quitButton;
        private Guna.UI2.WinForms.Guna2Panel menuPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel kitchenPanel;
        private Guna.UI2.WinForms.Guna2Panel tableStatusPanel;
        private Guna.UI2.WinForms.Guna2Button kitchenButton;
        private Guna.UI2.WinForms.Guna2Button tableStatusButton;
        private Guna.UI2.WinForms.Guna2Button menuButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button logOutButton;
    }
}