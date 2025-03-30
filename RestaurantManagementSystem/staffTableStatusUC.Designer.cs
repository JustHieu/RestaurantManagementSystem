namespace RestaurantManagementSystem
{
    partial class staffTableStatusUC
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tableUC1 = new RestaurantManagementSystem.tableUC();
            this.tableUC2 = new RestaurantManagementSystem.tableUC();
            this.tableUC3 = new RestaurantManagementSystem.tableUC();
            this.tableUC4 = new RestaurantManagementSystem.tableUC();
            this.label4 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.payButton = new Guna.UI2.WinForms.Guna2Button();
            this.changeButton = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLabel = new System.Windows.Forms.Label();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(977, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(700, 579);
            this.dataGridView1.TabIndex = 73;
            // 
            // tableFlowLayoutPanel
            // 
            this.tableFlowLayoutPanel.AutoScroll = true;
            this.tableFlowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.tableFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableFlowLayoutPanel.Controls.Add(this.tableUC1);
            this.tableFlowLayoutPanel.Controls.Add(this.tableUC2);
            this.tableFlowLayoutPanel.Controls.Add(this.tableUC3);
            this.tableFlowLayoutPanel.Controls.Add(this.tableUC4);
            this.tableFlowLayoutPanel.Location = new System.Drawing.Point(61, 60);
            this.tableFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(10);
            this.tableFlowLayoutPanel.Name = "tableFlowLayoutPanel";
            this.tableFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.tableFlowLayoutPanel.Size = new System.Drawing.Size(877, 882);
            this.tableFlowLayoutPanel.TabIndex = 63;
            // 
            // tableUC1
            // 
            this.tableUC1.BackColor = System.Drawing.Color.Transparent;
            this.tableUC1.Location = new System.Drawing.Point(30, 30);
            this.tableUC1.Margin = new System.Windows.Forms.Padding(20);
            this.tableUC1.Name = "tableUC1";
            this.tableUC1.Size = new System.Drawing.Size(240, 156);
            this.tableUC1.TabIndex = 0;
            // 
            // tableUC2
            // 
            this.tableUC2.BackColor = System.Drawing.Color.Transparent;
            this.tableUC2.Location = new System.Drawing.Point(310, 30);
            this.tableUC2.Margin = new System.Windows.Forms.Padding(20);
            this.tableUC2.Name = "tableUC2";
            this.tableUC2.Size = new System.Drawing.Size(240, 156);
            this.tableUC2.TabIndex = 1;
            // 
            // tableUC3
            // 
            this.tableUC3.BackColor = System.Drawing.Color.Transparent;
            this.tableUC3.Location = new System.Drawing.Point(590, 30);
            this.tableUC3.Margin = new System.Windows.Forms.Padding(20);
            this.tableUC3.Name = "tableUC3";
            this.tableUC3.Size = new System.Drawing.Size(240, 156);
            this.tableUC3.TabIndex = 2;
            // 
            // tableUC4
            // 
            this.tableUC4.BackColor = System.Drawing.Color.Transparent;
            this.tableUC4.Location = new System.Drawing.Point(30, 226);
            this.tableUC4.Margin = new System.Windows.Forms.Padding(20);
            this.tableUC4.Name = "tableUC4";
            this.tableUC4.Size = new System.Drawing.Size(240, 156);
            this.tableUC4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Philosopher", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(1586, 835);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 31);
            this.label4.TabIndex = 72;
            this.label4.Text = "$";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalLabel.Font = new System.Drawing.Font("Philosopher", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalLabel.Location = new System.Drawing.Point(1482, 835);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(28, 31);
            this.totalLabel.TabIndex = 71;
            this.totalLabel.Text = "0";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // payButton
            // 
            this.payButton.AutoRoundedCorners = true;
            this.payButton.BorderRadius = 23;
            this.payButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.payButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.payButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.payButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.payButton.FillColor = System.Drawing.Color.Green;
            this.payButton.Font = new System.Drawing.Font("Philosopher", 10.2F, System.Drawing.FontStyle.Bold);
            this.payButton.ForeColor = System.Drawing.Color.White;
            this.payButton.Location = new System.Drawing.Point(1386, 890);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(248, 48);
            this.payButton.TabIndex = 70;
            this.payButton.Text = "PAY MONEY";
            // 
            // changeButton
            // 
            this.changeButton.AutoRoundedCorners = true;
            this.changeButton.BackColor = System.Drawing.Color.Transparent;
            this.changeButton.BorderRadius = 23;
            this.changeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.changeButton.Font = new System.Drawing.Font("Philosopher", 10.2F, System.Drawing.FontStyle.Bold);
            this.changeButton.ForeColor = System.Drawing.Color.White;
            this.changeButton.Location = new System.Drawing.Point(989, 890);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(254, 48);
            this.changeButton.TabIndex = 69;
            this.changeButton.Text = "CHANGE TABLE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Philosopher", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(1406, 835);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 31);
            this.label3.TabIndex = 68;
            this.label3.Text = "Total:";
            // 
            // tableComboBox
            // 
            this.tableComboBox.AutoRoundedCorners = true;
            this.tableComboBox.BackColor = System.Drawing.Color.Transparent;
            this.tableComboBox.BorderColor = System.Drawing.Color.Black;
            this.tableComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tableComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tableComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tableComboBox.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.tableComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.tableComboBox.ItemHeight = 30;
            this.tableComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.tableComboBox.Location = new System.Drawing.Point(1149, 830);
            this.tableComboBox.Name = "tableComboBox";
            this.tableComboBox.Size = new System.Drawing.Size(108, 36);
            this.tableComboBox.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(972, 835);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 27);
            this.label2.TabIndex = 66;
            this.label2.Text = "Select blank table:";
            // 
            // tableLabel
            // 
            this.tableLabel.AutoSize = true;
            this.tableLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.tableLabel.Font = new System.Drawing.Font("Philosopher", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLabel.Location = new System.Drawing.Point(1255, 117);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(139, 45);
            this.tableLabel.TabIndex = 65;
            this.tableLabel.Text = "TABLE 1";
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 50;
            this.guna2Button3.CustomizableEdges.BottomLeft = false;
            this.guna2Button3.CustomizableEdges.BottomRight = false;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.guna2Button3.Font = new System.Drawing.Font("Philosopher", 10.2F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(977, 60);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(700, 166);
            this.guna2Button3.TabIndex = 64;
            // 
            // staffTableStatusUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableFlowLayoutPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLabel);
            this.Controls.Add(this.guna2Button3);
            this.Name = "staffTableStatusUC";
            this.Size = new System.Drawing.Size(1675, 932);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel tableFlowLayoutPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalLabel;
        private Guna.UI2.WinForms.Guna2Button payButton;
        private Guna.UI2.WinForms.Guna2Button changeButton;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox tableComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tableLabel;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private tableUC tableUC1;
        private tableUC tableUC2;
        private tableUC tableUC3;
        private tableUC tableUC4;
    }
}
