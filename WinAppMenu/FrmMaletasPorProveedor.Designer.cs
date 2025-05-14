namespace WinAppMenu
{
    partial class FrmMaletasPorProveedor
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
            this.tblDatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WinAppMenu.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblDatosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblDatosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tblDatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDatosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDatosBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tblDatosBindingSource
            // 
            this.tblDatosBindingSource.DataMember = "TblDatos";
            this.tblDatosBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblDatosBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WinAppMenu.ReportePorProveedor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(624, 450);
            this.reportViewer1.TabIndex = 2;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // tblDatosBindingSource1
            // 
            this.tblDatosBindingSource1.DataMember = "TblDatos";
            this.tblDatosBindingSource1.DataSource = this.dataSet1;
            // 
            // tblDatosBindingSource2
            // 
            this.tblDatosBindingSource2.DataMember = "TblDatos";
            this.tblDatosBindingSource2.DataSource = this.dataSet1;
            // 
            // FrmMaletasPorProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmMaletasPorProveedor";
            this.Text = "FrmMaletasPorProveedor";
            this.Load += new System.EventHandler(this.FrmMaletasPorProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblDatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDatosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDatosBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblDatosBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tblDatosBindingSource1;
        private System.Windows.Forms.BindingSource tblDatosBindingSource2;
    }
}