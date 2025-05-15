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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMaletasPorProveedor));
            this.tblDatosBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WinAppMenu.DataSet1();
            this.tblDatosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tblDatosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblDatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblDatosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblDatosBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDatosBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDatosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDatosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblDatosBindingSource4
            // 
            this.tblDatosBindingSource4.DataMember = "TblDatos";
            this.tblDatosBindingSource4.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDatosBindingSource3
            // 
            this.tblDatosBindingSource3.DataMember = "TblDatos";
            this.tblDatosBindingSource3.DataSource = this.dataSet1;
            // 
            // tblDatosBindingSource2
            // 
            this.tblDatosBindingSource2.DataMember = "TblDatos";
            this.tblDatosBindingSource2.DataSource = this.dataSet1;
            // 
            // tblDatosBindingSource
            // 
            this.tblDatosBindingSource.DataMember = "TblDatos";
            this.tblDatosBindingSource.DataSource = this.dataSet1;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.tblDatosBindingSource4;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WinAppMenu.ReportePorProveedor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(33, 161);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(921, 502);
            this.reportViewer1.TabIndex = 2;
            this.reportViewer1.Visible = false;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // tblDatosBindingSource1
            // 
            this.tblDatosBindingSource1.DataMember = "TblDatos";
            this.tblDatosBindingSource1.DataSource = this.dataSet1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(223, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mochilas por Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(110)))));
            this.label2.Location = new System.Drawing.Point(224, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Escriba el Proveedor";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(607, 100);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 30);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackgroundImage = global::WinAppMenu.Properties.Resources.btnAzul;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnBuscar.Location = new System.Drawing.Point(787, 100);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(167, 38);
            this.BtnBuscar.TabIndex = 10;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click_1);
            this.BtnBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BtnBuscar_KeyPress);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackgroundImage = global::WinAppMenu.Properties.Resources.btnRojo;
            this.BtnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAceptar.Location = new System.Drawing.Point(787, 26);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(167, 43);
            this.BtnAceptar.TabIndex = 31;
            this.BtnAceptar.Text = "SALIR";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // FrmMaletasPorProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 678);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMaletasPorProveedor";
            this.Text = "FrmMaletasPorProveedor";
            this.Load += new System.EventHandler(this.FrmMaletasPorProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblDatosBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDatosBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDatosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDatosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblDatosBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tblDatosBindingSource1;
        private System.Windows.Forms.BindingSource tblDatosBindingSource2;
        private System.Windows.Forms.BindingSource tblDatosBindingSource3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tblDatosBindingSource4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnAceptar;
    }
}