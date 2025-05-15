namespace WinAppMenu
{
    partial class Portada
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarMochila = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(110)))));
            this.label3.Location = new System.Drawing.Point(273, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(418, 99);
            this.label3.TabIndex = 29;
            this.label3.Text = "Mochilas y Bolsos de alta calidad\r\nen diferentes modelos\r\npara toda ocación\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.label2.Location = new System.Drawing.Point(236, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(510, 39);
            this.label2.TabIndex = 27;
            this.label2.Text = "¡Bienvenido a My Bag Mochilas! \r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAgregarMochila
            // 
            this.btnAgregarMochila.BackgroundImage = global::WinAppMenu.Properties.Resources.btnRojo;
            this.btnAgregarMochila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarMochila.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarMochila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMochila.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMochila.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMochila.Location = new System.Drawing.Point(407, 200);
            this.btnAgregarMochila.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarMochila.Name = "btnAgregarMochila";
            this.btnAgregarMochila.Size = new System.Drawing.Size(157, 42);
            this.btnAgregarMochila.TabIndex = 28;
            this.btnAgregarMochila.Text = "Empezar";
            this.btnAgregarMochila.UseVisualStyleBackColor = true;
            this.btnAgregarMochila.Click += new System.EventHandler(this.btnAgregarMochila_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinAppMenu.Properties.Resources.LogoMyBagMOCHILAS;
            this.pictureBox1.Location = new System.Drawing.Point(-15, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Portada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 270);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAgregarMochila);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Portada";
            this.Text = "Portada";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarMochila;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}