namespace QLCHGAGMIX
{
    partial class frm_bcNhanVien
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.nhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLLTDataSet1 = new QLCHGAGMIX.QLLTDataSet1();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cthdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanvienTableAdapter = new QLCHGAGMIX.QLLTDataSet1TableAdapters.nhanvienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLLTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cthdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nhanvienBindingSource
            // 
            this.nhanvienBindingSource.DataMember = "nhanvien";
            this.nhanvienBindingSource.DataSource = this.QLLTDataSet1;
            // 
            // QLLTDataSet1
            // 
            this.QLLTDataSet1.DataSetName = "QLLTDataSet1";
            this.QLLTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.nhanvienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLCHGAGMIX.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(921, 386);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // cthdBindingSource
            // 
            this.cthdBindingSource.DataMember = "cthd";
            // 
            // nhanvienTableAdapter
            // 
            this.nhanvienTableAdapter.ClearBeforeFill = true;
            // 
            // frm_bcNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(921, 386);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_bcNhanVien";
            this.Text = "frm_bcCTHD";
            this.Load += new System.EventHandler(this.frm_bcCTHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLLTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cthdBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
       // private QLLTDataSet1 QLLTDataSet1;
       // private QLLTDataSet1TableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
       // private QLLTDataSet QLLTDataSet;
       // private QLLTDataSetTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.BindingSource cthdBindingSource;
        private System.Windows.Forms.BindingSource nhanvienBindingSource;
        private QLLTDataSet1 QLLTDataSet1;
        private QLLTDataSet1TableAdapters.nhanvienTableAdapter nhanvienTableAdapter;
       // private QLLTDataSet1TableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
       // private QLLTDataSet QLLTDataSet;
      //  private QLLTDataSetTableAdapters.cthdTableAdapter cthdTableAdapter;
       // private QLLTDataSetTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
       // private System.Windows.Forms.BindingSource nhanvienBindingSource;
       // private QLLTDataSet1 QLLTDataSet1;
       // private QLLTDataSet1TableAdapters.nhanvienTableAdapter nhanvienTableAdapter;
       // private QLLTDataSet1 QLLTDataSet1;
       // private QLLTDataSet1TableAdapters.cthdTableAdapter cthdTableAdapter;
    }
}