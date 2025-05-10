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
            this.searchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.changeButton = new Guna.UI2.WinForms.Guna2Button();
            this.addButton = new Guna.UI2.WinForms.Guna2Button();
            this.deleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.typeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cookingIngredientsButton = new Guna.UI2.WinForms.Guna2Button();
            this.priceTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.descriptionTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.nameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.idTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.insertImageButton = new System.Windows.Forms.Button();
            this.dishImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.seachBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dishImage)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.AutoRoundedCorners = true;
            this.searchTextBox.BorderRadius = 26;
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
            this.searchTextBox.Location = new System.Drawing.Point(224, 47);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PlaceholderText = "Search";
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.Size = new System.Drawing.Size(452, 55);
            this.searchTextBox.TabIndex = 43;
            // 
            // changeButton
            // 
            this.changeButton.AutoRoundedCorners = true;
            this.changeButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.changeButton.BorderRadius = 23;
            this.changeButton.BorderThickness = 1;
            this.changeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changeButton.FillColor = System.Drawing.Color.Silver;
            this.changeButton.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Bold);
            this.changeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.changeButton.Location = new System.Drawing.Point(1313, 854);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(186, 48);
            this.changeButton.TabIndex = 49;
            this.changeButton.Text = "CHANGE";
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // addButton
            // 
            this.addButton.AutoRoundedCorners = true;
            this.addButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.addButton.BorderRadius = 23;
            this.addButton.BorderThickness = 1;
            this.addButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addButton.FillColor = System.Drawing.Color.Silver;
            this.addButton.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Bold);
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.addButton.Location = new System.Drawing.Point(1522, 854);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(186, 48);
            this.addButton.TabIndex = 48;
            this.addButton.Text = "ADD NEW DISH";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.AutoRoundedCorners = true;
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.deleteButton.BorderRadius = 23;
            this.deleteButton.BorderThickness = 1;
            this.deleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteButton.FillColor = System.Drawing.Color.Silver;
            this.deleteButton.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Bold);
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.deleteButton.Location = new System.Drawing.Point(1100, 854);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(186, 48);
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
            this.menuPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.menuPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPanel.Location = new System.Drawing.Point(2, 121);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(2);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1145, 712);
            this.menuPanel.TabIndex = 50;
            this.menuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.menuPanel_Paint);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 50;
            this.guna2CustomGradientPanel1.Controls.Add(this.insertImageButton);
            this.guna2CustomGradientPanel1.Controls.Add(this.typeComboBox);
            this.guna2CustomGradientPanel1.Controls.Add(this.cookingIngredientsButton);
            this.guna2CustomGradientPanel1.Controls.Add(this.priceTextBox);
            this.guna2CustomGradientPanel1.Controls.Add(this.descriptionTextBox);
            this.guna2CustomGradientPanel1.Controls.Add(this.nameTextBox);
            this.guna2CustomGradientPanel1.Controls.Add(this.idTextBox);
            this.guna2CustomGradientPanel1.Controls.Add(this.dishImage);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(1124, 78);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(600, 757);
            this.guna2CustomGradientPanel1.TabIndex = 51;
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
            this.typeComboBox.Location = new System.Drawing.Point(320, 389);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(173, 36);
            this.typeComboBox.TabIndex = 68;
            // 
            // cookingIngredientsButton
            // 
            this.cookingIngredientsButton.AutoRoundedCorners = true;
            this.cookingIngredientsButton.BackColor = System.Drawing.Color.Transparent;
            this.cookingIngredientsButton.BorderRadius = 21;
            this.cookingIngredientsButton.BorderThickness = 1;
            this.cookingIngredientsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cookingIngredientsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cookingIngredientsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cookingIngredientsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cookingIngredientsButton.FillColor = System.Drawing.Color.Gray;
            this.cookingIngredientsButton.Font = new System.Drawing.Font("Philosopher", 10.2F, System.Drawing.FontStyle.Bold);
            this.cookingIngredientsButton.ForeColor = System.Drawing.Color.Black;
            this.cookingIngredientsButton.Location = new System.Drawing.Point(94, 677);
            this.cookingIngredientsButton.Name = "cookingIngredientsButton";
            this.cookingIngredientsButton.Size = new System.Drawing.Size(412, 45);
            this.cookingIngredientsButton.TabIndex = 67;
            this.cookingIngredientsButton.Text = "COOKING INGREDIENTS";
            this.cookingIngredientsButton.Click += new System.EventHandler(this.cookingIngredientsButton_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.AutoRoundedCorners = true;
            this.priceTextBox.BackColor = System.Drawing.Color.Transparent;
            this.priceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceTextBox.DefaultText = "";
            this.priceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.priceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.priceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTextBox.Font = new System.Drawing.Font("Philosopher", 10.2F, System.Drawing.FontStyle.Bold);
            this.priceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTextBox.Location = new System.Drawing.Point(94, 601);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.PlaceholderText = "Price";
            this.priceTextBox.SelectedText = "";
            this.priceTextBox.Size = new System.Drawing.Size(233, 38);
            this.priceTextBox.TabIndex = 66;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.AutoRoundedCorners = true;
            this.descriptionTextBox.BackColor = System.Drawing.Color.Transparent;
            this.descriptionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descriptionTextBox.DefaultText = "";
            this.descriptionTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.descriptionTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.descriptionTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.descriptionTextBox.Font = new System.Drawing.Font("Philosopher", 10.2F, System.Drawing.FontStyle.Bold);
            this.descriptionTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.descriptionTextBox.Location = new System.Drawing.Point(94, 530);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.PlaceholderText = "Description";
            this.descriptionTextBox.SelectedText = "";
            this.descriptionTextBox.Size = new System.Drawing.Size(412, 45);
            this.descriptionTextBox.TabIndex = 65;
            // 
            // nameTextBox
            // 
            this.nameTextBox.AutoRoundedCorners = true;
            this.nameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.DefaultText = "";
            this.nameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTextBox.Font = new System.Drawing.Font("Philosopher", 10.2F, System.Drawing.FontStyle.Bold);
            this.nameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTextBox.Location = new System.Drawing.Point(94, 460);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PlaceholderText = "Name";
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.Size = new System.Drawing.Size(412, 38);
            this.nameTextBox.TabIndex = 64;
            // 
            // idTextBox
            // 
            this.idTextBox.AutoRoundedCorners = true;
            this.idTextBox.BackColor = System.Drawing.Color.Transparent;
            this.idTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idTextBox.DefaultText = "";
            this.idTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.idTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.idTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idTextBox.Font = new System.Drawing.Font("Philosopher", 10.2F, System.Drawing.FontStyle.Bold);
            this.idTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idTextBox.Location = new System.Drawing.Point(94, 389);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.PlaceholderText = "ID";
            this.idTextBox.SelectedText = "";
            this.idTextBox.Size = new System.Drawing.Size(179, 38);
            this.idTextBox.TabIndex = 63;
            // 
            // insertImageButton
            // 
            this.insertImageButton.BackColor = System.Drawing.Color.Transparent;
            this.insertImageButton.Image = global::RestaurantManagementSystem.Properties.Resources.image;
            this.insertImageButton.Location = new System.Drawing.Point(409, 289);
            this.insertImageButton.Name = "insertImageButton";
            this.insertImageButton.Size = new System.Drawing.Size(44, 33);
            this.insertImageButton.TabIndex = 62;
            this.insertImageButton.UseVisualStyleBackColor = false;
            this.insertImageButton.Click += new System.EventHandler(this.insertImageButton_Click_1);
            // 
            // dishImage
            // 
            this.dishImage.BackColor = System.Drawing.Color.Transparent;
            this.dishImage.BorderRadius = 15;
            this.dishImage.FillColor = System.Drawing.Color.Transparent;
            this.dishImage.Image = global::RestaurantManagementSystem.Properties.Resources.restaurantAvt;
            this.dishImage.ImageRotate = 0F;
            this.dishImage.Location = new System.Drawing.Point(123, 43);
            this.dishImage.Name = "dishImage";
            this.dishImage.Size = new System.Drawing.Size(330, 279);
            this.dishImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dishImage.TabIndex = 69;
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
            this.seachBtn.Location = new System.Drawing.Point(665, 47);
            this.seachBtn.Name = "seachBtn";
            this.seachBtn.Size = new System.Drawing.Size(106, 55);
            this.seachBtn.TabIndex = 44;
            this.seachBtn.Click += new System.EventHandler(this.seachBtn_Click);
            // 
            // managerMenuUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.seachBtn);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.Name = "managerMenuUC";
            this.Size = new System.Drawing.Size(1675, 932);
            this.Load += new System.EventHandler(this.managerMenuUC_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dishImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox searchTextBox;
        private Guna.UI2.WinForms.Guna2Button changeButton;
        private Guna.UI2.WinForms.Guna2Button addButton;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2Button seachBtn;
        private System.Windows.Forms.FlowLayoutPanel menuPanel;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2ComboBox typeComboBox;
        private Guna.UI2.WinForms.Guna2Button cookingIngredientsButton;
        private Guna.UI2.WinForms.Guna2TextBox priceTextBox;
        private Guna.UI2.WinForms.Guna2TextBox descriptionTextBox;
        private Guna.UI2.WinForms.Guna2TextBox nameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox idTextBox;
        private System.Windows.Forms.Button insertImageButton;
        private Guna.UI2.WinForms.Guna2PictureBox dishImage;
    }
}
