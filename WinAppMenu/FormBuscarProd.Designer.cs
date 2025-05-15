namespace WinAppMenu
{
    partial class FormBuscarProd
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
            this.TxtBuscarCodigo = new System.Windows.Forms.TextBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.labelTITULO = new System.Windows.Forms.Label();
            this.dataSet11 = new WinAppMenu.DataSet1();
            this.LblColor = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblUso = new System.Windows.Forms.Label();
            this.LblTipo = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblMarca = new System.Windows.Forms.Label();
            this.LblProveedor = new System.Windows.Forms.Label();
            this.LblCapacidad = new System.Windows.Forms.Label();
            this.LblGarantia = new System.Windows.Forms.Label();
            this.LblRTipo = new System.Windows.Forms.Label();
            this.LblRUso = new System.Windows.Forms.Label();
            this.LblRColor = new System.Windows.Forms.Label();
            this.LblRPrecio = new System.Windows.Forms.Label();
            this.LblRMarca = new System.Windows.Forms.Label();
            this.LblRProveedor = new System.Windows.Forms.Label();
            this.LblRCapacidad = new System.Windows.Forms.Label();
            this.LblRGarantia = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscarMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMul = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBuscarCodigo
            // 
            this.TxtBuscarCodigo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarCodigo.Location = new System.Drawing.Point(215, 114);
            this.TxtBuscarCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBuscarCodigo.Name = "TxtBuscarCodigo";
            this.TxtBuscarCodigo.Size = new System.Drawing.Size(100, 28);
            this.TxtBuscarCodigo.TabIndex = 9;
            this.TxtBuscarCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscarCodigo_KeyPress);
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(110)))));
            this.LblCodigo.Location = new System.Drawing.Point(85, 114);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(112, 29);
            this.LblCodigo.TabIndex = 7;
            this.LblCodigo.Text = "Código :";
            // 
            // labelTITULO
            // 
            this.labelTITULO.AutoSize = true;
            this.labelTITULO.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTITULO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(110)))));
            this.labelTITULO.Location = new System.Drawing.Point(152, 33);
            this.labelTITULO.Name = "labelTITULO";
            this.labelTITULO.Size = new System.Drawing.Size(381, 39);
            this.labelTITULO.TabIndex = 6;
            this.labelTITULO.Text = "BUSCAR PRODUCTO";
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LblColor
            // 
            this.LblColor.AutoSize = true;
            this.LblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(110)))));
            this.LblColor.Location = new System.Drawing.Point(119, 303);
            this.LblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblColor.Name = "LblColor";
            this.LblColor.Size = new System.Drawing.Size(65, 25);
            this.LblColor.TabIndex = 15;
            this.LblColor.Text = "Color:";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(110)))));
            this.LblPrecio.Location = new System.Drawing.Point(119, 342);
            this.LblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(73, 25);
            this.LblPrecio.TabIndex = 14;
            this.LblPrecio.Text = "Precio:";
            // 
            // LblUso
            // 
            this.LblUso.AutoSize = true;
            this.LblUso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(110)))));
            this.LblUso.Location = new System.Drawing.Point(119, 266);
            this.LblUso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUso.Name = "LblUso";
            this.LblUso.Size = new System.Drawing.Size(53, 25);
            this.LblUso.TabIndex = 13;
            this.LblUso.Text = "Uso:";
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(110)))));
            this.LblTipo.Location = new System.Drawing.Point(119, 231);
            this.LblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(57, 25);
            this.LblTipo.TabIndex = 12;
            this.LblTipo.Text = "Tipo:";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(110)))));
            this.LblDescripcion.Location = new System.Drawing.Point(363, 342);
            this.LblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(120, 25);
            this.LblDescripcion.TabIndex = 20;
            this.LblDescripcion.Text = "Descripción:";
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(110)))));
            this.LblMarca.Location = new System.Drawing.Point(119, 380);
            this.LblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(73, 25);
            this.LblMarca.TabIndex = 19;
            this.LblMarca.Text = "Marca:";
            // 
            // LblProveedor
            // 
            this.LblProveedor.AutoSize = true;
            this.LblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(110)))));
            this.LblProveedor.Location = new System.Drawing.Point(363, 231);
            this.LblProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProveedor.Name = "LblProveedor";
            this.LblProveedor.Size = new System.Drawing.Size(108, 25);
            this.LblProveedor.TabIndex = 18;
            this.LblProveedor.Text = "Proveedor:";
            // 
            // LblCapacidad
            // 
            this.LblCapacidad.AutoSize = true;
            this.LblCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCapacidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(110)))));
            this.LblCapacidad.Location = new System.Drawing.Point(363, 266);
            this.LblCapacidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCapacidad.Name = "LblCapacidad";
            this.LblCapacidad.Size = new System.Drawing.Size(113, 25);
            this.LblCapacidad.TabIndex = 17;
            this.LblCapacidad.Text = "Capacidad:";
            // 
            // LblGarantia
            // 
            this.LblGarantia.AutoSize = true;
            this.LblGarantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGarantia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(110)))));
            this.LblGarantia.Location = new System.Drawing.Point(363, 303);
            this.LblGarantia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblGarantia.Name = "LblGarantia";
            this.LblGarantia.Size = new System.Drawing.Size(92, 25);
            this.LblGarantia.TabIndex = 16;
            this.LblGarantia.Text = "Garantía:";
            // 
            // LblRTipo
            // 
            this.LblRTipo.AutoSize = true;
            this.LblRTipo.Location = new System.Drawing.Point(215, 235);
            this.LblRTipo.Name = "LblRTipo";
            this.LblRTipo.Size = new System.Drawing.Size(0, 16);
            this.LblRTipo.TabIndex = 22;
            // 
            // LblRUso
            // 
            this.LblRUso.AutoSize = true;
            this.LblRUso.Location = new System.Drawing.Point(215, 271);
            this.LblRUso.Name = "LblRUso";
            this.LblRUso.Size = new System.Drawing.Size(0, 16);
            this.LblRUso.TabIndex = 23;
            // 
            // LblRColor
            // 
            this.LblRColor.AutoSize = true;
            this.LblRColor.Location = new System.Drawing.Point(215, 306);
            this.LblRColor.Name = "LblRColor";
            this.LblRColor.Size = new System.Drawing.Size(0, 16);
            this.LblRColor.TabIndex = 24;
            // 
            // LblRPrecio
            // 
            this.LblRPrecio.AutoSize = true;
            this.LblRPrecio.Location = new System.Drawing.Point(215, 346);
            this.LblRPrecio.Name = "LblRPrecio";
            this.LblRPrecio.Size = new System.Drawing.Size(0, 16);
            this.LblRPrecio.TabIndex = 25;
            // 
            // LblRMarca
            // 
            this.LblRMarca.AutoSize = true;
            this.LblRMarca.Location = new System.Drawing.Point(215, 384);
            this.LblRMarca.Name = "LblRMarca";
            this.LblRMarca.Size = new System.Drawing.Size(0, 16);
            this.LblRMarca.TabIndex = 26;
            // 
            // LblRProveedor
            // 
            this.LblRProveedor.AutoSize = true;
            this.LblRProveedor.Location = new System.Drawing.Point(505, 231);
            this.LblRProveedor.Name = "LblRProveedor";
            this.LblRProveedor.Size = new System.Drawing.Size(0, 16);
            this.LblRProveedor.TabIndex = 27;
            // 
            // LblRCapacidad
            // 
            this.LblRCapacidad.AutoSize = true;
            this.LblRCapacidad.Location = new System.Drawing.Point(505, 268);
            this.LblRCapacidad.Name = "LblRCapacidad";
            this.LblRCapacidad.Size = new System.Drawing.Size(0, 16);
            this.LblRCapacidad.TabIndex = 28;
            // 
            // LblRGarantia
            // 
            this.LblRGarantia.AutoSize = true;
            this.LblRGarantia.Location = new System.Drawing.Point(504, 303);
            this.LblRGarantia.Name = "LblRGarantia";
            this.LblRGarantia.Size = new System.Drawing.Size(0, 16);
            this.LblRGarantia.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinAppMenu.Properties.Resources.LogoMyBagAzul;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackgroundImage = global::WinAppMenu.Properties.Resources.btnRojo;
            this.BtnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAceptar.Location = new System.Drawing.Point(237, 418);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(145, 43);
            this.BtnAceptar.TabIndex = 10;
            this.BtnAceptar.Text = "SALIR";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
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
            this.BtnBuscar.Location = new System.Drawing.Point(251, 162);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(145, 38);
            this.BtnBuscar.TabIndex = 8;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBuscarMarca
            // 
            this.TxtBuscarMarca.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarMarca.Location = new System.Drawing.Point(479, 114);
            this.TxtBuscarMarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBuscarMarca.Name = "TxtBuscarMarca";
            this.TxtBuscarMarca.Size = new System.Drawing.Size(100, 28);
            this.TxtBuscarMarca.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(363, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "Marca :";
            // 
            // TxtMul
            // 
            this.TxtMul.Location = new System.Drawing.Point(507, 346);
            this.TxtMul.Multiline = true;
            this.TxtMul.Name = "TxtMul";
            this.TxtMul.Size = new System.Drawing.Size(137, 67);
            this.TxtMul.TabIndex = 36;
            // 
            // FormBuscarProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 566);
            this.Controls.Add(this.TxtMul);
            this.Controls.Add(this.TxtBuscarMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblRGarantia);
            this.Controls.Add(this.LblRCapacidad);
            this.Controls.Add(this.LblRProveedor);
            this.Controls.Add(this.LblRMarca);
            this.Controls.Add(this.LblRPrecio);
            this.Controls.Add(this.LblRColor);
            this.Controls.Add(this.LblRUso);
            this.Controls.Add(this.LblRTipo);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.LblMarca);
            this.Controls.Add(this.LblProveedor);
            this.Controls.Add(this.LblCapacidad);
            this.Controls.Add(this.LblGarantia);
            this.Controls.Add(this.LblColor);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.LblUso);
            this.Controls.Add(this.LblTipo);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.TxtBuscarCodigo);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.labelTITULO);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormBuscarProd";
            this.Text = "FormBuscarProd";
            this.Load += new System.EventHandler(this.FormBuscarProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBuscarCodigo;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label labelTITULO;
        private DataSet1 dataSet11;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label LblColor;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Label LblUso;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.Label LblProveedor;
        private System.Windows.Forms.Label LblCapacidad;
        private System.Windows.Forms.Label LblGarantia;
        private System.Windows.Forms.Label LblRTipo;
        private System.Windows.Forms.Label LblRUso;
        private System.Windows.Forms.Label LblRColor;
        private System.Windows.Forms.Label LblRPrecio;
        private System.Windows.Forms.Label LblRMarca;
        private System.Windows.Forms.Label LblRProveedor;
        private System.Windows.Forms.Label LblRCapacidad;
        private System.Windows.Forms.Label LblRGarantia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtBuscarMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMul;
    }
}