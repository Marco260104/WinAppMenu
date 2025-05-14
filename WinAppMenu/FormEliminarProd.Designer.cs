namespace WinAppMenu
{
    partial class FormEliminarProd
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
            this.TxtDBuscarCodigo = new System.Windows.Forms.TextBox();
            this.BtnDBuscar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dataSet11 = new WinAppMenu.DataSet1();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(259, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar producto a eliminar\r\n\r\n";
            // 
            // TxtDBuscarCodigo
            // 
            this.TxtDBuscarCodigo.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDBuscarCodigo.Location = new System.Drawing.Point(388, 193);
            this.TxtDBuscarCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtDBuscarCodigo.Name = "TxtDBuscarCodigo";
            this.TxtDBuscarCodigo.Size = new System.Drawing.Size(76, 29);
            this.TxtDBuscarCodigo.TabIndex = 48;
            // 
            // BtnDBuscar
            // 
            this.BtnDBuscar.BackgroundImage = global::WinAppMenu.Properties.Resources.btnRojo;
            this.BtnDBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDBuscar.FlatAppearance.BorderSize = 0;
            this.BtnDBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnDBuscar.Location = new System.Drawing.Point(488, 190);
            this.BtnDBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnDBuscar.Name = "BtnDBuscar";
            this.BtnDBuscar.Size = new System.Drawing.Size(92, 31);
            this.BtnDBuscar.TabIndex = 47;
            this.BtnDBuscar.Text = "Buscar";
            this.BtnDBuscar.UseVisualStyleBackColor = true;
            this.BtnDBuscar.Click += new System.EventHandler(this.BtnDBuscar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(110)))));
            this.label12.Location = new System.Drawing.Point(303, 194);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 25);
            this.label12.TabIndex = 46;
            this.label12.Text = "Código :";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinAppMenu.Properties.Resources.LogoMyBagAzul;
            this.pictureBox1.Location = new System.Drawing.Point(391, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // FormEliminarProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 289);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtDBuscarCodigo);
            this.Controls.Add(this.BtnDBuscar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Name = "FormEliminarProd";
            this.Text = "FormEliminarProd";
            this.Load += new System.EventHandler(this.FormEliminarProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDBuscarCodigo;
        private System.Windows.Forms.Button BtnDBuscar;
        private System.Windows.Forms.Label label12;
        private DataSet1 dataSet11;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}