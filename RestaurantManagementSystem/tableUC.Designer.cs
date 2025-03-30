namespace RestaurantManagementSystem
{
    partial class tableUC
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
            this.table11Button = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // table11Button
            // 
            this.table11Button.BorderRadius = 40;
            this.table11Button.BorderThickness = 1;
            this.table11Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.table11Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.table11Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.table11Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.table11Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(48)))), ((int)(((byte)(55)))));
            this.table11Button.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Bold);
            this.table11Button.ForeColor = System.Drawing.Color.White;
            this.table11Button.Location = new System.Drawing.Point(0, 0);
            this.table11Button.Margin = new System.Windows.Forms.Padding(0);
            this.table11Button.Name = "table11Button";
            this.table11Button.Size = new System.Drawing.Size(240, 156);
            this.table11Button.TabIndex = 12;
            this.table11Button.Text = "TABLE 1";
            this.table11Button.Click += new System.EventHandler(this.table11Button_Click);
            // 
            // tableUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.table11Button);
            this.Margin = new System.Windows.Forms.Padding(20);
            this.Name = "tableUC";
            this.Size = new System.Drawing.Size(240, 156);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button table11Button;
    }
}
