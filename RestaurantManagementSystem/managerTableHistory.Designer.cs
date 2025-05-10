namespace RestaurantManagementSystem
{
    partial class managerTableHistory
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
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.seachButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.Location = new System.Drawing.Point(176, 201);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(1339, 614);
            this.flowPanel.TabIndex = 0;
            // 
            // searchTextBox
            // 
            this.searchTextBox.AutoRoundedCorners = true;
            this.searchTextBox.BorderRadius = 25;
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
            this.searchTextBox.Location = new System.Drawing.Point(503, 43);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PlaceholderText = "Search";
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.Size = new System.Drawing.Size(641, 52);
            this.searchTextBox.TabIndex = 61;
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
            this.seachButton.Location = new System.Drawing.Point(1141, 43);
            this.seachButton.Name = "seachButton";
            this.seachButton.Size = new System.Drawing.Size(94, 52);
            this.seachButton.TabIndex = 62;
            this.seachButton.Click += new System.EventHandler(this.seachButton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1483, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 675);
            this.panel1.TabIndex = 67;
            // 
            // managerTableHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.seachButton);
            this.Controls.Add(this.flowPanel);
            this.Name = "managerTableHistory";
            this.Size = new System.Drawing.Size(2015, 901);
            this.Load += new System.EventHandler(this.managerTableHistory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private Guna.UI2.WinForms.Guna2TextBox searchTextBox;
        private Guna.UI2.WinForms.Guna2Button seachButton;
        private System.Windows.Forms.Panel panel1;
    }
}
