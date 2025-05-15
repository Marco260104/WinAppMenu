namespace WinAppMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hOLAAAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maletasPorUsoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porMesesDeGarantíaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maletasPorProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maletasPorColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mochilasPorPrecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mochilasPorCapacidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mochilasPorMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sEANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.dataSet11 = new WinAppMenu.DataSet1();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOLAAAToolStripMenuItem,
            this.vANToolStripMenuItem,
            this.lASToolStripMenuItem,
            this.sEANToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(617, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // hOLAAAToolStripMenuItem
            // 
            this.hOLAAAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.hOLAAAToolStripMenuItem.Name = "hOLAAAToolStripMenuItem";
            this.hOLAAAToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.hOLAAAToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.salirToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.salirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // vANToolStripMenuItem
            // 
            this.vANToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProductoToolStripMenuItem,
            this.buscarProductoToolStripMenuItem,
            this.editarProductoToolStripMenuItem,
            this.eliminarProductoToolStripMenuItem});
            this.vANToolStripMenuItem.Name = "vANToolStripMenuItem";
            this.vANToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.vANToolStripMenuItem.Text = "Opciones";
            this.vANToolStripMenuItem.Click += new System.EventHandler(this.vANToolStripMenuItem_Click);
            // 
            // agregarProductoToolStripMenuItem
            // 
            this.agregarProductoToolStripMenuItem.Name = "agregarProductoToolStripMenuItem";
            this.agregarProductoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.agregarProductoToolStripMenuItem.Text = "&Agregar Producto";
            this.agregarProductoToolStripMenuItem.Click += new System.EventHandler(this.agregarProductoToolStripMenuItem_Click);
            // 
            // buscarProductoToolStripMenuItem
            // 
            this.buscarProductoToolStripMenuItem.Name = "buscarProductoToolStripMenuItem";
            this.buscarProductoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.buscarProductoToolStripMenuItem.Text = "&Buscar Producto";
            this.buscarProductoToolStripMenuItem.Click += new System.EventHandler(this.buscarProductoToolStripMenuItem_Click);
            // 
            // editarProductoToolStripMenuItem
            // 
            this.editarProductoToolStripMenuItem.Name = "editarProductoToolStripMenuItem";
            this.editarProductoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.editarProductoToolStripMenuItem.Text = "E&ditar Producto";
            this.editarProductoToolStripMenuItem.Click += new System.EventHandler(this.editarProductoToolStripMenuItem_Click);
            // 
            // eliminarProductoToolStripMenuItem
            // 
            this.eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            this.eliminarProductoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.eliminarProductoToolStripMenuItem.Text = "&Eliminar Producto";
            this.eliminarProductoToolStripMenuItem.Click += new System.EventHandler(this.eliminarProductoToolStripMenuItem_Click);
            // 
            // lASToolStripMenuItem
            // 
            this.lASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verTodosToolStripMenuItem,
            this.maletasPorUsoToolStripMenuItem,
            this.porMesesDeGarantíaToolStripMenuItem,
            this.maletasPorProveedorToolStripMenuItem,
            this.maletasPorColorToolStripMenuItem,
            this.mochilasPorPrecioToolStripMenuItem,
            this.mochilasPorCapacidadToolStripMenuItem,
            this.mochilasPorMarcaToolStripMenuItem});
            this.lASToolStripMenuItem.Name = "lASToolStripMenuItem";
            this.lASToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.lASToolStripMenuItem.Text = "Reportes";
            // 
            // verTodosToolStripMenuItem
            // 
            this.verTodosToolStripMenuItem.Name = "verTodosToolStripMenuItem";
            this.verTodosToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.verTodosToolStripMenuItem.Text = "Ver todos los Productos";
            this.verTodosToolStripMenuItem.Click += new System.EventHandler(this.verTodosToolStripMenuItem_Click);
            // 
            // maletasPorUsoToolStripMenuItem
            // 
            this.maletasPorUsoToolStripMenuItem.Name = "maletasPorUsoToolStripMenuItem";
            this.maletasPorUsoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.maletasPorUsoToolStripMenuItem.Text = "Mochilas por Uso";
            this.maletasPorUsoToolStripMenuItem.Click += new System.EventHandler(this.maletasPorUsoToolStripMenuItem_Click);
            // 
            // porMesesDeGarantíaToolStripMenuItem
            // 
            this.porMesesDeGarantíaToolStripMenuItem.Name = "porMesesDeGarantíaToolStripMenuItem";
            this.porMesesDeGarantíaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.porMesesDeGarantíaToolStripMenuItem.Text = "Por Meses de Garantía";
            this.porMesesDeGarantíaToolStripMenuItem.Click += new System.EventHandler(this.porMesesDeGarantíaToolStripMenuItem_Click);
            // 
            // maletasPorProveedorToolStripMenuItem
            // 
            this.maletasPorProveedorToolStripMenuItem.Name = "maletasPorProveedorToolStripMenuItem";
            this.maletasPorProveedorToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.maletasPorProveedorToolStripMenuItem.Text = "Mochilas por Proveedor";
            this.maletasPorProveedorToolStripMenuItem.Click += new System.EventHandler(this.maletasPorProveedorToolStripMenuItem_Click);
            // 
            // maletasPorColorToolStripMenuItem
            // 
            this.maletasPorColorToolStripMenuItem.Name = "maletasPorColorToolStripMenuItem";
            this.maletasPorColorToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.maletasPorColorToolStripMenuItem.Text = "Mochilas por Color";
            this.maletasPorColorToolStripMenuItem.Click += new System.EventHandler(this.maletasPorColorToolStripMenuItem_Click);
            // 
            // mochilasPorPrecioToolStripMenuItem
            // 
            this.mochilasPorPrecioToolStripMenuItem.Name = "mochilasPorPrecioToolStripMenuItem";
            this.mochilasPorPrecioToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.mochilasPorPrecioToolStripMenuItem.Text = "Mochilas por Precio";
            this.mochilasPorPrecioToolStripMenuItem.Click += new System.EventHandler(this.mochilasPorPrecioToolStripMenuItem_Click);
            // 
            // mochilasPorCapacidadToolStripMenuItem
            // 
            this.mochilasPorCapacidadToolStripMenuItem.Name = "mochilasPorCapacidadToolStripMenuItem";
            this.mochilasPorCapacidadToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.mochilasPorCapacidadToolStripMenuItem.Text = "Mochilas por Capacidad";
            this.mochilasPorCapacidadToolStripMenuItem.Click += new System.EventHandler(this.mochilasPorCapacidadToolStripMenuItem_Click);
            // 
            // mochilasPorMarcaToolStripMenuItem
            // 
            this.mochilasPorMarcaToolStripMenuItem.Name = "mochilasPorMarcaToolStripMenuItem";
            this.mochilasPorMarcaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.mochilasPorMarcaToolStripMenuItem.Text = "Mochilas por Marca";
            this.mochilasPorMarcaToolStripMenuItem.Click += new System.EventHandler(this.mochilasPorMarcaToolStripMenuItem_Click);
            // 
            // sEANToolStripMenuItem
            // 
            this.sEANToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.sEANToolStripMenuItem.Name = "sEANToolStripMenuItem";
            this.sEANToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.sEANToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de..";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.label2.Location = new System.Drawing.Point(293, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "¡Bienvenido al Menú! \r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(39, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 39);
            this.label1.TabIndex = 9;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(110)))));
            this.label3.Location = new System.Drawing.Point(21, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 60);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mochilas y Bolsos de alta calidad\r\nen diferentes modelos\r\npara toda ocación\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(110)))));
            this.label4.Location = new System.Drawing.Point(273, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 52);
            this.label4.TabIndex = 13;
            this.label4.Text = "Usa el menú superior \r\npara navegar por la aplicación.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinAppMenu.Properties.Resources.LogoMyBagMOCHILAS;
            this.pictureBox1.Location = new System.Drawing.Point(45, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 353);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Menú";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hOLAAAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.ToolStripMenuItem sEANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maletasPorUsoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porMesesDeGarantíaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maletasPorProveedorToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem maletasPorColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mochilasPorPrecioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mochilasPorCapacidadToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem mochilasPorMarcaToolStripMenuItem;
    }
}

