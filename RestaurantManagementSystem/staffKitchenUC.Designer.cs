namespace RestaurantManagementSystem
{
    partial class staffKitchenUC
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
            this.readyButton = new Guna.UI2.WinForms.Guna2Button();
            this.serveButton = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // readyButton
            // 
            this.readyButton.AutoRoundedCorners = true;
            this.readyButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.readyButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.readyButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.readyButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.readyButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.readyButton.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readyButton.ForeColor = System.Drawing.Color.White;
            this.readyButton.Location = new System.Drawing.Point(283, 1269);
            this.readyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.readyButton.Name = "readyButton";
            this.readyButton.Size = new System.Drawing.Size(803, 84);
            this.readyButton.TabIndex = 8;
            this.readyButton.Text = "FOOD IS READY";
            // 
            // serveButton
            // 
            this.serveButton.AutoRoundedCorners = true;
            this.serveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.serveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.serveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.serveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.serveButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.serveButton.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serveButton.ForeColor = System.Drawing.Color.White;
            this.serveButton.Location = new System.Drawing.Point(1411, 1269);
            this.serveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.serveButton.Name = "serveButton";
            this.serveButton.Size = new System.Drawing.Size(803, 84);
            this.serveButton.TabIndex = 7;
            this.serveButton.Text = "SERVER THE GUESTS";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1254, 118);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1064, 1090);
            this.dataGridView2.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(129, 118);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1064, 1090);
            this.dataGridView1.TabIndex = 5;
            // 
            // staffKitchenUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.readyButton);
            this.Controls.Add(this.serveButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "staffKitchenUC";
            this.Size = new System.Drawing.Size(2303, 1398);
            this.Load += new System.EventHandler(this.staffKitchenUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button readyButton;
        private Guna.UI2.WinForms.Guna2Button serveButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
