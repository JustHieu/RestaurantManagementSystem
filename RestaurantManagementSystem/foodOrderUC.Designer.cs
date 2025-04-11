namespace RestaurantManagementSystem
{
    partial class foodOrderUC
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
            this.priceLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Philosopher", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(546, 30);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(48, 32);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "15$";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Philosopher", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(264, 30);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(207, 32);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Bún đậu mắm tôm";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Philosopher", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(164, 30);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(22, 32);
            this.quantityLabel.TabIndex = 5;
            this.quantityLabel.Text = "1";
            // 
            // deleteButton
            // 
            this.deleteButton.Image = global::RestaurantManagementSystem.Properties.Resources.trash;
            this.deleteButton.Location = new System.Drawing.Point(36, 16);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(45, 56);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // foodOrderUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.deleteButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "foodOrderUC";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(729, 88);
            this.Load += new System.EventHandler(this.foodOrderUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Button deleteButton;
    }
}
