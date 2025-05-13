namespace RestaurantManagementSystem
{
    partial class cookingIngredientsForm
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
            this.deleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.ingListView = new System.Windows.Forms.ListView();
            this.saveButton = new Guna.UI2.WinForms.Guna2Button();
            this.cookingingredientsLabel = new System.Windows.Forms.Label();
            this.cancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.searchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.addButton = new Guna.UI2.WinForms.Guna2Button();
            this.seachButton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.BorderRadius = 5;
            this.deleteButton.BorderThickness = 1;
            this.deleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteButton.FillColor = System.Drawing.Color.WhiteSmoke;
            this.deleteButton.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Bold);
            this.deleteButton.ForeColor = System.Drawing.Color.Black;
            this.deleteButton.Location = new System.Drawing.Point(606, 693);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(239, 43);
            this.deleteButton.TabIndex = 84;
            this.deleteButton.Text = "DELETE INGREDIENTS";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ingListView
            // 
            this.ingListView.FullRowSelect = true;
            this.ingListView.HideSelection = false;
            this.ingListView.Location = new System.Drawing.Point(606, 90);
            this.ingListView.Name = "ingListView";
            this.ingListView.Size = new System.Drawing.Size(518, 578);
            this.ingListView.TabIndex = 83;
            this.ingListView.UseCompatibleStateImageBehavior = false;
            this.ingListView.View = System.Windows.Forms.View.Details;
            // 
            // saveButton
            // 
            this.saveButton.AutoRoundedCorners = true;
            this.saveButton.BorderRadius = 23;
            this.saveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.saveButton.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Bold);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(872, 688);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 48);
            this.saveButton.TabIndex = 81;
            this.saveButton.Text = "SAVE";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cookingingredientsLabel
            // 
            this.cookingingredientsLabel.AutoSize = true;
            this.cookingingredientsLabel.Font = new System.Drawing.Font("SF Pro Display", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cookingingredientsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.cookingingredientsLabel.Location = new System.Drawing.Point(654, 30);
            this.cookingingredientsLabel.Name = "cookingingredientsLabel";
            this.cookingingredientsLabel.Size = new System.Drawing.Size(390, 39);
            this.cookingingredientsLabel.TabIndex = 80;
            this.cookingingredientsLabel.Text = "COOKING INGREDIENTS";
            // 
            // cancelButton
            // 
            this.cancelButton.AutoRoundedCorners = true;
            this.cancelButton.BorderRadius = 23;
            this.cancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelButton.FillColor = System.Drawing.Color.Red;
            this.cancelButton.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Bold);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(1011, 688);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(113, 48);
            this.cancelButton.TabIndex = 79;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.AutoRoundedCorners = true;
            this.searchTextBox.BorderRadius = 20;
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
            this.searchTextBox.Location = new System.Drawing.Point(87, 29);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PlaceholderText = "Search";
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.Size = new System.Drawing.Size(341, 42);
            this.searchTextBox.TabIndex = 77;
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(28, 90);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(553, 579);
            this.listView1.TabIndex = 76;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // addButton
            // 
            this.addButton.BorderRadius = 5;
            this.addButton.BorderThickness = 1;
            this.addButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addButton.FillColor = System.Drawing.Color.WhiteSmoke;
            this.addButton.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Bold);
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.Location = new System.Drawing.Point(361, 693);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(220, 43);
            this.addButton.TabIndex = 82;
            this.addButton.Text = "ADD INGREDIENTS";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
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
            this.seachButton.Location = new System.Drawing.Point(424, 30);
            this.seachButton.Name = "seachButton";
            this.seachButton.Size = new System.Drawing.Size(97, 41);
            this.seachButton.TabIndex = 78;
            this.seachButton.Click += new System.EventHandler(this.seachButton_Click);
            // 
            // cookingIngredientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1151, 764);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.ingListView);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cookingingredientsLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.seachButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cookingIngredientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cookingIngredientsForm";
            this.Load += new System.EventHandler(this.cookingIngredientsForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button deleteButton;
        private System.Windows.Forms.ListView ingListView;
        private Guna.UI2.WinForms.Guna2Button saveButton;
        private System.Windows.Forms.Label cookingingredientsLabel;
        private Guna.UI2.WinForms.Guna2Button cancelButton;
        private Guna.UI2.WinForms.Guna2TextBox searchTextBox;
        private System.Windows.Forms.ListView listView1;
        private Guna.UI2.WinForms.Guna2Button addButton;
        private Guna.UI2.WinForms.Guna2Button seachButton;
    }
}