namespace WinAppMenu
{
    partial class FormEditarProd
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtEBuscarCodigo = new System.Windows.Forms.TextBox();
            this.BtnEBuscar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dataSet11 = new WinAppMenu.DataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(93, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar producto a editar";
            // 
            // TxtEBuscarCodigo
            // 
            this.TxtEBuscarCodigo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEBuscarCodigo.Location = new System.Drawing.Point(182, 129);
            this.TxtEBuscarCodigo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtEBuscarCodigo.Name = "TxtEBuscarCodigo";
            this.TxtEBuscarCodigo.Size = new System.Drawing.Size(76, 24);
            this.TxtEBuscarCodigo.TabIndex = 45;
            // 
            // BtnEBuscar
            // 
            this.BtnEBuscar.BackgroundImage = global::WinAppMenu.Properties.Resources.btnAzul;
            this.BtnEBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.BtnEBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEBuscar.Location = new System.Drawing.Point(299, 125);
            this.BtnEBuscar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnEBuscar.Name = "BtnEBuscar";
            this.BtnEBuscar.Size = new System.Drawing.Size(98, 31);
            this.BtnEBuscar.TabIndex = 44;
            this.BtnEBuscar.Text = "Buscar";
            this.BtnEBuscar.UseVisualStyleBackColor = true;
            this.BtnEBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(110)))));
            this.label12.Location = new System.Drawing.Point(94, 125);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 26);
            this.label12.TabIndex = 43;
            this.label12.Text = "Código :";
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormEditarProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 246);
            this.Controls.Add(this.TxtEBuscarCodigo);
            this.Controls.Add(this.BtnEBuscar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Name = "FormEditarProd";
            this.Text = "FormEditarProd";
            this.Load += new System.EventHandler(this.FormEditarProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtEBuscarCodigo;
        private System.Windows.Forms.Button BtnEBuscar;
        private System.Windows.Forms.Label label12;
        private DataSet1 dataSet11;
    }
}