namespace RestaurantManagementSystem
{
    partial class managerUsedIngredient
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
            this.label1 = new System.Windows.Forms.Label();
            this.showPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(526, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(643, 95);
            this.label1.TabIndex = 3;
            this.label1.Text = "Used Ingredients";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // showPanel
            // 
            this.showPanel.Location = new System.Drawing.Point(269, 132);
            this.showPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showPanel.Name = "showPanel";
            this.showPanel.Size = new System.Drawing.Size(1013, 621);
            this.showPanel.TabIndex = 4;
            // 
            // managerUsedIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showPanel);
            this.Controls.Add(this.label1);
            this.Name = "managerUsedIngredient";
            this.Size = new System.Drawing.Size(1323, 782);
            this.Load += new System.EventHandler(this.managerUsedIngredient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel showPanel;
    }
}
