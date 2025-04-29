namespace RestaurantManagementSystem
{
    partial class managerStatisticalBestSellerUC
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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.dishNameLabel = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 15;
            this.guna2CustomGradientPanel1.Controls.Add(this.dishNameLabel);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.MistyRose;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.OrangeRed;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Snow;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.MistyRose;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(3, 3);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(449, 108);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // dishNameLabel
            // 
            this.dishNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.dishNameLabel.Font = new System.Drawing.Font("Philosopher", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dishNameLabel.ForeColor = System.Drawing.Color.Black;
            this.dishNameLabel.Location = new System.Drawing.Point(27, 25);
            this.dishNameLabel.Name = "dishNameLabel";
            this.dishNameLabel.Size = new System.Drawing.Size(399, 62);
            this.dishNameLabel.TabIndex = 0;
            this.dishNameLabel.Text = "name";
            this.dishNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // managerStatisticalBestSellerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "managerStatisticalBestSellerUC";
            this.Size = new System.Drawing.Size(455, 114);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label dishNameLabel;
    }
}
