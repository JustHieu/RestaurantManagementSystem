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
            this.maPBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaDiemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIADIEMPHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNV1DataSet1 = new RestaurantManagementSystem.QLNV1DataSet1();
            this.dIADIEM_PHONGTableAdapter = new RestaurantManagementSystem.QLNV1DataSet1TableAdapters.DIADIEM_PHONGTableAdapter();
            this.qLNV1DataSet3 = new RestaurantManagementSystem.QLNV1DataSet3();
            this.dIADIEMPHONGBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dIADIEM_PHONGTableAdapter1 = new RestaurantManagementSystem.QLNV1DataSet3TableAdapters.DIADIEM_PHONGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIADIEMPHONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNV1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNV1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIADIEMPHONGBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPBDataGridViewTextBoxColumn,
            this.diaDiemDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dIADIEMPHONGBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(222, 103);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(792, 234);
            this.dataGridView1.TabIndex = 0;
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
            // dIADIEMPHONGBindingSource
            // 
            this.dIADIEMPHONGBindingSource.DataMember = "DIADIEM_PHONG";
            this.dIADIEMPHONGBindingSource.DataSource = this.qLNV1DataSet1;
            // 
            // qLNV1DataSet1
            // 
            this.qLNV1DataSet1.DataSetName = "QLNV1DataSet1";
            this.qLNV1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dIADIEM_PHONGTableAdapter
            // 
            this.dIADIEM_PHONGTableAdapter.ClearBeforeFill = true;
            // 
            // qLNV1DataSet3
            // 
            this.qLNV1DataSet3.DataSetName = "QLNV1DataSet3";
            this.qLNV1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dIADIEMPHONGBindingSource1
            // 
            this.dIADIEMPHONGBindingSource1.DataMember = "DIADIEM_PHONG";
            this.dIADIEMPHONGBindingSource1.DataSource = this.qLNV1DataSet3;
            // 
            // dIADIEM_PHONGTableAdapter1
            // 
            this.dIADIEM_PHONGTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIADIEMPHONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNV1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNV1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIADIEMPHONGBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private QLNV1DataSet1 qLNV1DataSet1;
        private System.Windows.Forms.BindingSource dIADIEMPHONGBindingSource;
        private QLNV1DataSet1TableAdapters.DIADIEM_PHONGTableAdapter dIADIEM_PHONGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaDiemDataGridViewTextBoxColumn;
        private QLNV1DataSet3 qLNV1DataSet3;
        private System.Windows.Forms.BindingSource dIADIEMPHONGBindingSource1;
        private QLNV1DataSet3TableAdapters.DIADIEM_PHONGTableAdapter dIADIEM_PHONGTableAdapter1;
    }
}

