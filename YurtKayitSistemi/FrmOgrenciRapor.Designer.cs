namespace YurtKayitSistemi
{
    partial class FrmOgrenciRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenciRapor));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.YurtKayitDataSet7 = new YurtKayitSistemi.YurtKayitDataSet7();
            this.OgrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OgrenciTableAdapter = new YurtKayitSistemi.YurtKayitDataSet7TableAdapters.OgrenciTableAdapter();
            this.YurtKayitDataSet8 = new YurtKayitSistemi.YurtKayitDataSet8();
            ((System.ComponentModel.ISupportInitialize)(this.YurtKayitDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OgrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YurtKayitDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            resources.ApplyResources(this.reportViewer1, "reportViewer1");
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.OgrenciBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "YurtKayitSistemi.Report2.rdlc";
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            // 
            // YurtKayitDataSet7
            // 
            this.YurtKayitDataSet7.DataSetName = "YurtKayitDataSet7";
            this.YurtKayitDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OgrenciBindingSource
            // 
            this.OgrenciBindingSource.DataMember = "Ogrenci";
            this.OgrenciBindingSource.DataSource = this.YurtKayitDataSet7;
            // 
            // OgrenciTableAdapter
            // 
            this.OgrenciTableAdapter.ClearBeforeFill = true;
            // 
            // YurtKayitDataSet8
            // 
            this.YurtKayitDataSet8.DataSetName = "YurtKayitDataSet8";
            this.YurtKayitDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmOgrenciRapor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOgrenciRapor";
            this.Load += new System.EventHandler(this.FrmOgrenciRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.YurtKayitDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OgrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YurtKayitDataSet8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OgrenciBindingSource;
        private YurtKayitDataSet7 YurtKayitDataSet7;
        private YurtKayitDataSet7TableAdapters.OgrenciTableAdapter OgrenciTableAdapter;
        private YurtKayitDataSet8 YurtKayitDataSet8;
    }
}