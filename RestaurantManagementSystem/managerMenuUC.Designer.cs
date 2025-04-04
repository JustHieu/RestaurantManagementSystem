namespace RestaurantManagementSystem
{
    partial class managerMenuUC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.typeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cookingIngredientsButton = new Guna.UI2.WinForms.Guna2Button();
            this.priceTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.descriptionTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.nameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.idTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.changeButton = new Guna.UI2.WinForms.Guna2Button();
            this.addButton = new Guna.UI2.WinForms.Guna2Button();
            this.deleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.insertImageButton = new System.Windows.Forms.Button();
            this.dishImage = new System.Windows.Forms.PictureBox();
            this.seachBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dishImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.typeComboBox);
            this.panel1.Controls.Add(this.cookingIngredientsButton);
            this.panel1.Controls.Add(this.priceTextBox);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(this.insertImageButton);
            this.panel1.Controls.Add(this.dishImage);
            this.panel1.Location = new System.Drawing.Point(1490, 96);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 1136);
            this.panel1.TabIndex = 46;
            // 
            // typeComboBox
            // 
            this.typeComboBox.AutoRoundedCorners = true;
            this.typeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.typeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.typeComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.typeComboBox.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.typeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.typeComboBox.ItemHeight = 30;
            this.typeComboBox.Items.AddRange(new object[] {
            "Start Dish",
            "Main Dish",
            "Beverages"});
            this.typeComboBox.Location = new System.Drawing.Point(444, 573);
            this.typeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(236, 36);
            this.typeComboBox.TabIndex = 52;
            // 
            // cookingIngredientsButton
            // 
            this.cookingIngredientsButton.AutoRoundedCorners = true;
            this.cookingIngredientsButton.BorderRadius = 33;
            this.cookingIngredientsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cookingIngredientsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cookingIngredientsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cookingIngredientsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cookingIngredientsButton.FillColor = System.Drawing.Color.Gray;
            this.cookingIngredientsButton.Font = new System.Drawing.Font("Philosopher", 10.2F, System.Drawing.FontStyle.Bold);
            this.cookingIngredientsButton.ForeColor = System.Drawing.Color.White;
            this.cookingIngredientsButton.Location = new System.Drawing.Point(133, 1005);
            this.cookingIngredientsButton.Margin = new System.Windows.Forms.Padding(4);
            this.cookingIngredientsButton.Name = "cookingIngredientsButton";
            this.cookingIngredientsButton.Size = new System.Drawing.Size(566, 68);
            this.cookingIngredientsButton.TabIndex = 43;
            this.cookingIngredientsButton.Text = "COOKING INGREDIENTS";
            // 
            // priceTextBox
            // 
            this.priceTextBox.AutoRoundedCorners = true;
            this.priceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceTextBox.DefaultText = "";
            this.priceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.priceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.priceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTextBox.Font = new System.Drawing.Font("Philosopher", 10.2F, System.Drawing.FontStyle.Bold);
            this.priceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTextBox.Location = new System.Drawing.Point(133, 891);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.PlaceholderText = "Price";
            this.priceTextBox.SelectedText = "";
            this.priceTextBox.Size = new System.Drawing.Size(320, 57);
            this.priceTextBox.TabIndex = 5;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.AutoRoundedCorners = true;
            this.descriptionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descriptionTextBox.DefaultText = "";
            this.descriptionTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.descriptionTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.descriptionTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.descriptionTextBox.Font = new System.Drawing.Font("Philosopher", 10.2F, System.Drawing.FontStyle.Bold);
            this.descriptionTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.descriptionTextBox.Location = new System.Drawing.Point(133, 784);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.PlaceholderText = "Description";
            this.descriptionTextBox.SelectedText = "";
            this.descriptionTextBox.Size = new System.Drawing.Size(566, 57);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.AutoRoundedCorners = true;
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.DefaultText = "";
            this.nameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTextBox.Font = new System.Drawing.Font("Philosopher", 10.2F, System.Drawing.FontStyle.Bold);
            this.nameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTextBox.Location = new System.Drawing.Point(133, 680);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PlaceholderText = "Name";
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.Size = new System.Drawing.Size(566, 57);
            this.nameTextBox.TabIndex = 3;
            // 
            // idTextBox
            // 
            this.idTextBox.AutoRoundedCorners = true;
            this.idTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idTextBox.DefaultText = "";
            this.idTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.idTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.idTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idTextBox.Font = new System.Drawing.Font("Philosopher", 10.2F, System.Drawing.FontStyle.Bold);
            this.idTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idTextBox.Location = new System.Drawing.Point(133, 573);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.PlaceholderText = "ID";
            this.idTextBox.SelectedText = "";
            this.idTextBox.Size = new System.Drawing.Size(246, 57);
            this.idTextBox.TabIndex = 2;
            // 
            // searchTextBox
            // 
            this.searchTextBox.AutoRoundedCorners = true;
            this.searchTextBox.BorderRadius = 30;
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
            this.searchTextBox.Location = new System.Drawing.Point(410, 96);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PlaceholderText = "Search";
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.Size = new System.Drawing.Size(520, 63);
            this.searchTextBox.TabIndex = 43;
            // 
            // changeButton
            // 
            this.changeButton.AutoRoundedCorners = true;
            this.changeButton.BorderRadius = 35;
            this.changeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changeButton.FillColor = System.Drawing.Color.RoyalBlue;
            this.changeButton.Font = new System.Drawing.Font("Philosopher", 10.2F, System.Drawing.FontStyle.Bold);
            this.changeButton.ForeColor = System.Drawing.Color.White;
            this.changeButton.Location = new System.Drawing.Point(1781, 1280);
            this.changeButton.Margin = new System.Windows.Forms.Padding(4);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(256, 72);
            this.changeButton.TabIndex = 49;
            this.changeButton.Text = "CHANGE";
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // addButton
            // 
            this.addButton.AutoRoundedCorners = true;
            this.addButton.BorderRadius = 35;
            this.addButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addButton.FillColor = System.Drawing.Color.Green;
            this.addButton.Font = new System.Drawing.Font("Philosopher", 10.2F, System.Drawing.FontStyle.Bold);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(2068, 1280);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(256, 72);
            this.addButton.TabIndex = 48;
            this.addButton.Text = "ADD NEW DISH";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.AutoRoundedCorners = true;
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.BorderRadius = 35;
            this.deleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteButton.Font = new System.Drawing.Font("Philosopher", 10.2F, System.Drawing.FontStyle.Bold);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(1488, 1280);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(256, 72);
            this.deleteButton.TabIndex = 47;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuPanel
            // 
            this.menuPanel.AutoScroll = true;
            this.menuPanel.BackColor = System.Drawing.Color.White;
            this.menuPanel.Location = new System.Drawing.Point(237, 229);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1186, 993);
            this.menuPanel.TabIndex = 50;
            // 
            // insertImageButton
            // 
            this.insertImageButton.BackColor = System.Drawing.Color.Transparent;
            this.insertImageButton.Image = global::RestaurantManagementSystem.Properties.Resources.image;
            this.insertImageButton.Location = new System.Drawing.Point(578, 454);
            this.insertImageButton.Margin = new System.Windows.Forms.Padding(4);
            this.insertImageButton.Name = "insertImageButton";
            this.insertImageButton.Size = new System.Drawing.Size(61, 50);
            this.insertImageButton.TabIndex = 1;
            this.insertImageButton.UseVisualStyleBackColor = false;
            this.insertImageButton.Click += new System.EventHandler(this.insertImageButton_Click);
            // 
            // dishImage
            // 
            this.dishImage.BackColor = System.Drawing.Color.White;
            this.dishImage.Image = global::RestaurantManagementSystem.Properties.Resources.restaurant;
            this.dishImage.Location = new System.Drawing.Point(190, 40);
            this.dishImage.Margin = new System.Windows.Forms.Padding(4);
            this.dishImage.Name = "dishImage";
            this.dishImage.Size = new System.Drawing.Size(449, 464);
            this.dishImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dishImage.TabIndex = 0;
            this.dishImage.TabStop = false;
            // 
            // seachBtn
            // 
            this.seachBtn.AutoRoundedCorners = true;
            this.seachBtn.CustomizableEdges.BottomLeft = false;
            this.seachBtn.CustomizableEdges.TopLeft = false;
            this.seachBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.seachBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.seachBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.seachBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.seachBtn.FillColor = System.Drawing.Color.Gainsboro;
            this.seachBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.seachBtn.ForeColor = System.Drawing.Color.White;
            this.seachBtn.Image = global::RestaurantManagementSystem.Properties.Resources.search;
            this.seachBtn.Location = new System.Drawing.Point(927, 97);
            this.seachBtn.Margin = new System.Windows.Forms.Padding(4);
            this.seachBtn.Name = "seachBtn";
            this.seachBtn.Size = new System.Drawing.Size(133, 62);
            this.seachBtn.TabIndex = 44;
            this.seachBtn.Click += new System.EventHandler(this.seachBtn_Click);
            // 
            // managerMenuUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.seachBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "managerMenuUC";
            this.Size = new System.Drawing.Size(2303, 1398);
            this.Load += new System.EventHandler(this.managerMenuUC_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dishImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button cookingIngredientsButton;
        private Guna.UI2.WinForms.Guna2TextBox priceTextBox;
        private Guna.UI2.WinForms.Guna2TextBox descriptionTextBox;
        private Guna.UI2.WinForms.Guna2TextBox nameTextBox;
        private System.Windows.Forms.Button insertImageButton;
        private System.Windows.Forms.PictureBox dishImage;
        private Guna.UI2.WinForms.Guna2TextBox searchTextBox;
        private Guna.UI2.WinForms.Guna2Button changeButton;
        private Guna.UI2.WinForms.Guna2Button addButton;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2Button seachBtn;
        private Guna.UI2.WinForms.Guna2ComboBox typeComboBox;
        private System.Windows.Forms.FlowLayoutPanel menuPanel;
        private Guna.UI2.WinForms.Guna2TextBox idTextBox;
    }
}
