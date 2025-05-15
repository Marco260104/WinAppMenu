namespace WinAppMenu
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.muestra = new System.Windows.Forms.CheckBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgregarMochila = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(110)))));
            this.label3.Location = new System.Drawing.Point(107, 424);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "¿No estás registrado?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.label2.Location = new System.Drawing.Point(95, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 39);
            this.label2.TabIndex = 36;
            this.label2.Text = "Iniciar Sesion";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // muestra
            // 
            this.muestra.AutoSize = true;
            this.muestra.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muestra.Location = new System.Drawing.Point(244, 343);
            this.muestra.Margin = new System.Windows.Forms.Padding(4);
            this.muestra.Name = "muestra";
            this.muestra.Size = new System.Drawing.Size(80, 23);
            this.muestra.TabIndex = 33;
            this.muestra.Text = "Mostrar";
            this.muestra.UseVisualStyleBackColor = true;
            this.muestra.CheckedChanged += new System.EventHandler(this.muestra_CheckedChanged_1);
            // 
            // contraseña
            // 
            this.contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contraseña.Font = new System.Drawing.Font("Yu Gothic", 9F);
            this.contraseña.Location = new System.Drawing.Point(49, 301);
            this.contraseña.Margin = new System.Windows.Forms.Padding(4);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(275, 25);
            this.contraseña.TabIndex = 32;
            this.contraseña.Text = "Ingrese la contraseña";
            this.contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.contraseña.Enter += new System.EventHandler(this.contraseña_Enter_1);
            this.contraseña.Leave += new System.EventHandler(this.contraseña_Leave_1);
            // 
            // nombre
            // 
            this.nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombre.Font = new System.Drawing.Font("Yu Gothic", 9F);
            this.nombre.Location = new System.Drawing.Point(49, 211);
            this.nombre.Margin = new System.Windows.Forms.Padding(4);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(275, 25);
            this.nombre.TabIndex = 31;
            this.nombre.Text = "Ingrese su usuario";
            this.nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nombre.Enter += new System.EventHandler(this.nombre_Enter_1);
            this.nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_KeyPress);
            this.nombre.Leave += new System.EventHandler(this.nombre_Leave_1);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WinAppMenu.Properties.Resources.btnRojo;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(125, 451);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 30);
            this.button1.TabIndex = 38;
            this.button1.Text = "Registrarse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAgregarMochila
            // 
            this.btnAgregarMochila.BackgroundImage = global::WinAppMenu.Properties.Resources.btnRojo;
            this.btnAgregarMochila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarMochila.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarMochila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMochila.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMochila.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMochila.Location = new System.Drawing.Point(102, 374);
            this.btnAgregarMochila.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarMochila.Name = "btnAgregarMochila";
            this.btnAgregarMochila.Size = new System.Drawing.Size(157, 42);
            this.btnAgregarMochila.TabIndex = 35;
            this.btnAgregarMochila.Text = "Ingresar";
            this.btnAgregarMochila.UseVisualStyleBackColor = true;
            this.btnAgregarMochila.Click += new System.EventHandler(this.btnAgregarMochila_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(118, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 515);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregarMochila);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.muestra);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.nombre);
            this.Name = "login";
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarMochila;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox muestra;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.TextBox nombre;
    }
}