namespace RestaurantManagementSystem
{
    partial class foodItemUC
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
            this.components = new System.ComponentModel.Container();
            this.addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.descripLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dishImage = new System.Windows.Forms.PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dishImage)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.BorderRadius = 15;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addBtn.FillColor = System.Drawing.Color.DarkGray;
            this.addBtn.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(149, 321);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(136, 42);
            this.addBtn.TabIndex = 15;
            this.addBtn.Text = "ADD";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click_1);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.priceLabel.Location = new System.Drawing.Point(12, 330);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(77, 27);
            this.priceLabel.TabIndex = 14;
            this.priceLabel.Text = "120000";

            // 
            // nameLabel
            // 
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameLabel.Font = new System.Drawing.Font("Philosopher", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(0, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(272, 39);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "THAI BEEF SALAT";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.descripLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Location = new System.Drawing.Point(13, 225);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 93);
            this.panel1.TabIndex = 16;

            // 
            // descripLabel
            // 
            this.descripLabel.BackColor = System.Drawing.Color.Transparent;
            this.descripLabel.Location = new System.Drawing.Point(4, 49);
            this.descripLabel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descripLabel.Name = "descripLabel";
            this.descripLabel.Size = new System.Drawing.Size(108, 18);
            this.descripLabel.TabIndex = 7;
            this.descripLabel.Text = "guna2HtmlLabel1";
            // 
            // dishImage
            // 
            this.dishImage.Location = new System.Drawing.Point(11, 10);
            this.dishImage.Name = "dishImage";
            this.dishImage.Size = new System.Drawing.Size(274, 210);
            this.dishImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dishImage.TabIndex = 13;
            this.dishImage.TabStop = false;

            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // foodItemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.dishImage);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.Name = "foodItemUC";
            this.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.Size = new System.Drawing.Size(296, 372);

            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dishImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button addBtn;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox dishImage;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2HtmlLabel descripLabel;
    }
}
