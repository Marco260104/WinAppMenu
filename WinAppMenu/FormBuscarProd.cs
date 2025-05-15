using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinAppMenu
{
    public partial class FormBuscarProd : Form
    {
        public FormBuscarProd()
        {
            InitializeComponent();
        }

        private bool esModoReset = false;

        private string ObtenerRutaArchivo(string nombreArchivo)
        {
            return Path.Combine(Application.StartupPath, "IMAGENES", nombreArchivo);
        }

        private string ObtenerRutaXml()
        {
            // Ruta para el archivo XML en la carpeta "XML"
            return Path.Combine(Application.StartupPath, "XML", "Mochilas.xml");
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (esModoReset)
            {
                LblRTipo.Text = "";
                LblRUso.Text = "";
                LblRColor.Text = "";
                LblRPrecio.Text = "";
                LblRMarca.Text = "";
                LblRProveedor.Text = "";
                LblRCapacidad.Text = "";
                LblRGarantia.Text = "";
                LblRDescripcion.Text = "";

                BtnBuscar.BackgroundImage = System.Drawing.Image.FromFile(ObtenerRutaArchivo("btnAzul.png"));
                BtnBuscar.BackgroundImageLayout = ImageLayout.Stretch;
                BtnBuscar.Text = "BUSCAR";
                BtnBuscar.ForeColor = Color.White;

                TxtBuscarCodigo.Enabled = true;
                TxtBuscarCodigo.Clear();
                TxtBuscarCodigo.Focus();

                TxtBuscarMarca.Enabled = true;
                TxtBuscarMarca.Clear();

                esModoReset = false;
            }
            else
            {
                // Validar código
                if (string.IsNullOrWhiteSpace(TxtBuscarCodigo.Text) || !int.TryParse(TxtBuscarCodigo.Text, out int codigo) || codigo < 0)
                {
                    MessageBox.Show("Ingrese un código válido.");
                    return;
                }

                // Validar marca
                if (string.IsNullOrWhiteSpace(TxtBuscarMarca.Text))
                {
                    MessageBox.Show("Ingrese una marca válida.");
                    return;
                }

                string valorMarca = TxtBuscarMarca.Text.Trim().Replace("'", "''"); // Escapar comillas simples

                string rutaXml = ObtenerRutaXml(); // Obtener la ruta dinámica del XML

                // Verificar si la carpeta "XML" existe, si no, crearla
                if (!Directory.Exists(Path.Combine(Application.StartupPath, "XML")))
                {
                    Directory.CreateDirectory(Path.Combine(Application.StartupPath, "XML"));
                }

                // Leer XML
                dataSet11.ReadXml(rutaXml);

                // Buscar por código Y marca
                System.Data.DataRow[] Vector;
                Vector = dataSet11.TblDatos.Select($"Codigo = '{codigo}' AND Marca = '{valorMarca}'");

                if (Vector.Length > 0)
                {
                    LblRTipo.Text = Vector[0]["Tipo"].ToString();
                    LblRUso.Text = Vector[0]["Uso"].ToString();
                    LblRColor.Text = Vector[0]["Color"].ToString();
                    LblRPrecio.Text = Vector[0]["Precio"].ToString();
                    LblRMarca.Text = Vector[0]["Marca"].ToString();
                    LblRProveedor.Text = Vector[0]["Proveedor"].ToString();
                    LblRCapacidad.Text = Vector[0]["Capacidad"].ToString() + " cm^3";
                    LblRGarantia.Text = Vector[0]["Garantia"].ToString();
                    LblRDescripcion.Text = Vector[0]["Descripcion"].ToString();

                    MessageBox.Show("Producto Encontrado.");

                    BtnBuscar.BackgroundImage = System.Drawing.Image.FromFile(ObtenerRutaArchivo("btnGris.png"));
                    BtnBuscar.BackgroundImageLayout = ImageLayout.Stretch;
                    BtnBuscar.Text = "RESET";
                    BtnBuscar.ForeColor = Color.Red;

                    TxtBuscarCodigo.Clear();
                    TxtBuscarCodigo.Enabled = false;

                    TxtBuscarMarca.Clear();
                    TxtBuscarMarca.Enabled = false;

                    esModoReset = true;
                }
                else
                {
                    MessageBox.Show("Producto Inexistente.");
                    TxtBuscarCodigo.Clear();
                    TxtBuscarMarca.Clear();
                    TxtBuscarCodigo.Focus();
                }
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TxtBuscarCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                BtnBuscar_Click(sender, e);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void FormBuscarProd_Load(object sender, EventArgs e)
        {
        }
    }
}
