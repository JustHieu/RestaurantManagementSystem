namespace RestaurantManagementSystem
{
    partial class cookingIngredientsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveButton = new Guna.UI2.WinForms.Guna2Button();
            this.ingredientView = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.closeLoginForm = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeLoginForm)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.AutoRoundedCorners = true;
            this.saveButton.BorderRadius = 23;
            this.saveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveButton.FillColor = System.Drawing.Color.Black;
            this.saveButton.Font = new System.Drawing.Font("Philosopher", 10.2F, System.Drawing.FontStyle.Bold);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(720, 617);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(175, 48);
            this.saveButton.TabIndex = 53;
            this.saveButton.Text = "SAVE";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ingredientView
            // 
            this.ingredientView.HideSelection = false;
            this.ingredientView.Location = new System.Drawing.Point(44, 113);
            this.ingredientView.Name = "ingredientView";
            this.ingredientView.Size = new System.Drawing.Size(486, 491);
            this.ingredientView.TabIndex = 48;
            this.ingredientView.UseCompatibleStateImageBehavior = false;
            this.ingredientView.SelectedIndexChanged += new System.EventHandler(this.IngredientView_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.quantityTxt);
            this.panel1.Controls.Add(this.nameTxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(535, 113);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 491);
            this.panel1.TabIndex = 56;
            // 
            // quantityTxt
            // 
            this.quantityTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTxt.Location = new System.Drawing.Point(223, 266);
            this.quantityTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quantityTxt.Multiline = true;
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(200, 20);
            this.quantityTxt.TabIndex = 3;
            this.quantityTxt.TextChanged += new System.EventHandler(this.quantityTxt_TextChanged);
            // 
            // nameTxt
            // 
            this.nameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(223, 113);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameTxt.Multiline = true;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(200, 20);
            this.nameTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Display", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 261);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Philosopher", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(652, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 45);
            this.label3.TabIndex = 58;
            this.label3.Text = "Ingredient";
            // 
            // closeLoginForm
            // 
            this.closeLoginForm.BackColor = System.Drawing.Color.Transparent;
            this.closeLoginForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLoginForm.Image = global::RestaurantManagementSystem.Properties.Resources.close1;
            this.closeLoginForm.Location = new System.Drawing.Point(956, 3);
            this.closeLoginForm.Name = "closeLoginForm";
            this.closeLoginForm.Size = new System.Drawing.Size(30, 30);
            this.closeLoginForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeLoginForm.TabIndex = 59;
            this.closeLoginForm.TabStop = false;
            this.closeLoginForm.Click += new System.EventHandler(this.closeLoginForm_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(223, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(223, 291);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 5;
            // 
            // cookingIngredientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(988, 697);
            this.Controls.Add(this.closeLoginForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.ingredientView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cookingIngredientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cookingIngredientsForm";
            this.Load += new System.EventHandler(this.cookingIngredientsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeLoginForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button saveButton;
        private System.Windows.Forms.ListView ingredientView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox closeLoginForm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}