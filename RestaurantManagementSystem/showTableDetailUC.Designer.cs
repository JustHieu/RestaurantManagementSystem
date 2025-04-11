namespace RestaurantManagementSystem
{
    partial class showTableDetailUC
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Philosopher", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(222, 20);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(207, 32);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Bún đậu mắm tôm";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Philosopher", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(530, 20);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(48, 32);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "15$";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Philosopher", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(79, 20);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(22, 32);
            this.quantityLabel.TabIndex = 9;
            this.quantityLabel.Text = "1";
            // 
            // showTableDetailUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "showTableDetailUC";
            this.Size = new System.Drawing.Size(651, 72);
            this.Load += new System.EventHandler(this.showTableDetailUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label quantityLabel;
    }
}
