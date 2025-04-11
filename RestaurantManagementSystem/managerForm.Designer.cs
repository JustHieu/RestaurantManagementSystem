namespace RestaurantManagementSystem
{
    partial class managerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(managerForm));
            this.showPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.notificationButton = new System.Windows.Forms.Button();
            this.accountLabel = new System.Windows.Forms.Label();
            this.accontPictureBox = new System.Windows.Forms.PictureBox();
            this.quitButton = new System.Windows.Forms.Button();
            this.menuPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.statisticalPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.statisticalButton = new Guna.UI2.WinForms.Guna2Button();
            this.manageStaffPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.manageStaffButton = new Guna.UI2.WinForms.Guna2Button();
            this.coldStoragePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.tableStatusPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.coldStorageButton = new Guna.UI2.WinForms.Guna2Button();
            this.tableHistoryButton = new Guna.UI2.WinForms.Guna2Button();
            this.menuButton = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.logOutButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accontPictureBox)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // showPanel
            // 
            this.showPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.showPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showPanel.Location = new System.Drawing.Point(373, 114);
            this.showPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showPanel.Name = "showPanel";
            this.showPanel.Size = new System.Drawing.Size(2297, 1398);
            this.showPanel.TabIndex = 18;
            this.showPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.showPanel_Paint);
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.notificationButton);
            this.panel1.Controls.Add(this.accountLabel);
            this.panel1.Controls.Add(this.accontPictureBox);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Controls.Add(this.quitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(373, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2297, 114);
            this.panel1.TabIndex = 17;
            // 
            // notificationButton
            // 
            this.notificationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.notificationButton.FlatAppearance.BorderSize = 0;
            this.notificationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notificationButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.notificationButton.Image = global::RestaurantManagementSystem.Properties.Resources.bell;
            this.notificationButton.Location = new System.Drawing.Point(2135, 27);
            this.notificationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.notificationButton.Name = "notificationButton";
            this.notificationButton.Size = new System.Drawing.Size(63, 68);
            this.notificationButton.TabIndex = 16;
            this.notificationButton.UseVisualStyleBackColor = true;
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountLabel.ForeColor = System.Drawing.Color.White;
            this.accountLabel.Location = new System.Drawing.Point(1911, 45);
            this.accountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(151, 38);
            this.accountLabel.TabIndex = 15;
            this.accountLabel.Text = "MANAGER";
            // 
            // accontPictureBox
            // 
            this.accontPictureBox.Image = global::RestaurantManagementSystem.Properties.Resources.user1;
            this.accontPictureBox.Location = new System.Drawing.Point(1820, 18);
            this.accontPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accontPictureBox.Name = "accontPictureBox";
            this.accontPictureBox.Size = new System.Drawing.Size(82, 87);
            this.accontPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.accontPictureBox.TabIndex = 14;
            this.accontPictureBox.TabStop = false;
            // 
            // quitButton
            // 
            this.quitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.quitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitButton.FlatAppearance.BorderSize = 0;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.quitButton.Image = global::RestaurantManagementSystem.Properties.Resources.quit;
            this.quitButton.Location = new System.Drawing.Point(2232, 21);
            this.quitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(63, 68);
            this.quitButton.TabIndex = 7;
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
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
            this.guna2Panel3.Controls.Add(this.statisticalPanel);
            this.guna2Panel3.Controls.Add(this.statisticalButton);
            this.guna2Panel3.Controls.Add(this.manageStaffPanel);
            this.guna2Panel3.Controls.Add(this.manageStaffButton);
            this.guna2Panel3.Controls.Add(this.coldStoragePanel);
            this.guna2Panel3.Controls.Add(this.tableStatusPanel);
            this.guna2Panel3.Controls.Add(this.menuPanel);
            this.guna2Panel3.Controls.Add(this.coldStorageButton);
            this.guna2Panel3.Controls.Add(this.tableHistoryButton);
            this.guna2Panel3.Controls.Add(this.menuButton);
            this.guna2Panel3.Controls.Add(this.pictureBox2);
            this.guna2Panel3.Controls.Add(this.logOutButton);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(373, 1512);
            this.guna2Panel3.TabIndex = 16;
            // 
            // statisticalPanel
            // 
            this.statisticalPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.statisticalPanel.Location = new System.Drawing.Point(4, 753);
            this.statisticalPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statisticalPanel.Name = "statisticalPanel";
            this.statisticalPanel.Size = new System.Drawing.Size(14, 105);
            this.statisticalPanel.TabIndex = 21;
            this.statisticalPanel.Visible = false;
            // 
            // statisticalButton
            // 
            this.statisticalButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.statisticalButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.statisticalButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.statisticalButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.statisticalButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.statisticalButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticalButton.ForeColor = System.Drawing.Color.White;
            this.statisticalButton.Image = global::RestaurantManagementSystem.Properties.Resources.chart_histogram;
            this.statisticalButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.statisticalButton.ImageOffset = new System.Drawing.Point(20, 0);
            this.statisticalButton.Location = new System.Drawing.Point(0, 753);
            this.statisticalButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statisticalButton.Name = "statisticalButton";
            this.statisticalButton.Size = new System.Drawing.Size(373, 105);
            this.statisticalButton.TabIndex = 22;
            this.statisticalButton.Text = "Statistical";
            this.statisticalButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.statisticalButton.TextOffset = new System.Drawing.Point(30, 0);
            this.statisticalButton.Click += new System.EventHandler(this.statisticalButton_Click);
            // 
            // manageStaffPanel
            // 
            this.manageStaffPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.manageStaffPanel.Location = new System.Drawing.Point(4, 639);
            this.manageStaffPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.manageStaffPanel.Name = "manageStaffPanel";
            this.manageStaffPanel.Size = new System.Drawing.Size(14, 105);
            this.manageStaffPanel.TabIndex = 19;
            this.manageStaffPanel.Visible = false;
            // 
            // manageStaffButton
            // 
            this.manageStaffButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.manageStaffButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.manageStaffButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.manageStaffButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.manageStaffButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.manageStaffButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageStaffButton.ForeColor = System.Drawing.Color.White;
            this.manageStaffButton.Image = global::RestaurantManagementSystem.Properties.Resources.users;
            this.manageStaffButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.manageStaffButton.ImageOffset = new System.Drawing.Point(20, 0);
            this.manageStaffButton.Location = new System.Drawing.Point(0, 639);
            this.manageStaffButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.manageStaffButton.Name = "manageStaffButton";
            this.manageStaffButton.Size = new System.Drawing.Size(373, 105);
            this.manageStaffButton.TabIndex = 20;
            this.manageStaffButton.Text = "Manage Staff ";
            this.manageStaffButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.manageStaffButton.TextOffset = new System.Drawing.Point(30, 0);
            this.manageStaffButton.Click += new System.EventHandler(this.manageStaffButton_Click);
            // 
            // coldStoragePanel
            // 
            this.coldStoragePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.coldStoragePanel.Location = new System.Drawing.Point(4, 525);
            this.coldStoragePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.coldStoragePanel.Name = "coldStoragePanel";
            this.coldStoragePanel.Size = new System.Drawing.Size(14, 105);
            this.coldStoragePanel.TabIndex = 17;
            this.coldStoragePanel.Visible = false;
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
            // coldStorageButton
            // 
            this.coldStorageButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.coldStorageButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.coldStorageButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.coldStorageButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.coldStorageButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.coldStorageButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coldStorageButton.ForeColor = System.Drawing.Color.White;
            this.coldStorageButton.Image = global::RestaurantManagementSystem.Properties.Resources.apps;
            this.coldStorageButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.coldStorageButton.ImageOffset = new System.Drawing.Point(20, 0);
            this.coldStorageButton.Location = new System.Drawing.Point(0, 525);
            this.coldStorageButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.coldStorageButton.Name = "coldStorageButton";
            this.coldStorageButton.Size = new System.Drawing.Size(373, 105);
            this.coldStorageButton.TabIndex = 18;
            this.coldStorageButton.Text = "Cold Storage";
            this.coldStorageButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.coldStorageButton.TextOffset = new System.Drawing.Point(30, 0);
            this.coldStorageButton.Click += new System.EventHandler(this.coldStorageButton_Click);
            // 
            // tableHistoryButton
            // 
            this.tableHistoryButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tableHistoryButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tableHistoryButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tableHistoryButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tableHistoryButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.tableHistoryButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableHistoryButton.ForeColor = System.Drawing.Color.White;
            this.tableHistoryButton.Image = global::RestaurantManagementSystem.Properties.Resources.history;
            this.tableHistoryButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tableHistoryButton.ImageOffset = new System.Drawing.Point(20, 0);
            this.tableHistoryButton.Location = new System.Drawing.Point(0, 411);
            this.tableHistoryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableHistoryButton.Name = "tableHistoryButton";
            this.tableHistoryButton.Size = new System.Drawing.Size(373, 105);
            this.tableHistoryButton.TabIndex = 16;
            this.tableHistoryButton.Text = "Table History";
            this.tableHistoryButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tableHistoryButton.TextOffset = new System.Drawing.Point(30, 0);
            this.tableHistoryButton.Click += new System.EventHandler(this.tableHistoryButton_Click);
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
            this.menuButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(373, 105);
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
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(373, 288);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // logOutButton
            // 
            this.logOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logOutButton.Image = global::RestaurantManagementSystem.Properties.Resources.exit;
            this.logOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutButton.Location = new System.Drawing.Point(60, 1440);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(202, 68);
            this.logOutButton.TabIndex = 4;
            this.logOutButton.Text = "LOG OUT";
            this.logOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // managerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2670, 1512);
            this.Controls.Add(this.showPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "managerForm";
            this.Text = "managerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accontPictureBox)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2Panel coldStoragePanel;
        private Guna.UI2.WinForms.Guna2Panel tableStatusPanel;
        private Guna.UI2.WinForms.Guna2Button coldStorageButton;
        private Guna.UI2.WinForms.Guna2Button tableHistoryButton;
        private Guna.UI2.WinForms.Guna2Button menuButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button logOutButton;
        private Guna.UI2.WinForms.Guna2Panel manageStaffPanel;
        private Guna.UI2.WinForms.Guna2Button manageStaffButton;
        private Guna.UI2.WinForms.Guna2Panel statisticalPanel;
        private Guna.UI2.WinForms.Guna2Button statisticalButton;
    }
}