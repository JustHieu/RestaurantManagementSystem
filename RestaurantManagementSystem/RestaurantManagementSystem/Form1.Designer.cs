namespace RestaurantManagementSystem
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qLNV1DataSet1 = new RestaurantManagementSystem.QLNV1DataSet1();
            this.dIADIEMPHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dIADIEM_PHONGTableAdapter = new RestaurantManagementSystem.QLNV1DataSet1TableAdapters.DIADIEM_PHONGTableAdapter();
            this.maPBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaDiemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNV1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIADIEMPHONGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPBDataGridViewTextBoxColumn,
            this.diaDiemDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dIADIEMPHONGBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(148, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(528, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // qLNV1DataSet1
            // 
            this.qLNV1DataSet1.DataSetName = "QLNV1DataSet1";
            this.qLNV1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dIADIEMPHONGBindingSource
            // 
            this.dIADIEMPHONGBindingSource.DataMember = "DIADIEM_PHONG";
            this.dIADIEMPHONGBindingSource.DataSource = this.qLNV1DataSet1;
            // 
            // dIADIEM_PHONGTableAdapter
            // 
            this.dIADIEM_PHONGTableAdapter.ClearBeforeFill = true;
            // 
            // maPBDataGridViewTextBoxColumn
            // 
            this.maPBDataGridViewTextBoxColumn.DataPropertyName = "MaPB";
            this.maPBDataGridViewTextBoxColumn.HeaderText = "MaPB";
            this.maPBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPBDataGridViewTextBoxColumn.Name = "maPBDataGridViewTextBoxColumn";
            this.maPBDataGridViewTextBoxColumn.Width = 125;
            // 
            // diaDiemDataGridViewTextBoxColumn
            // 
            this.diaDiemDataGridViewTextBoxColumn.DataPropertyName = "DiaDiem";
            this.diaDiemDataGridViewTextBoxColumn.HeaderText = "DiaDiem";
            this.diaDiemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaDiemDataGridViewTextBoxColumn.Name = "diaDiemDataGridViewTextBoxColumn";
            this.diaDiemDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNV1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIADIEMPHONGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private QLNV1DataSet1 qLNV1DataSet1;
        private System.Windows.Forms.BindingSource dIADIEMPHONGBindingSource;
        private QLNV1DataSet1TableAdapters.DIADIEM_PHONGTableAdapter dIADIEM_PHONGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaDiemDataGridViewTextBoxColumn;
    }
}

