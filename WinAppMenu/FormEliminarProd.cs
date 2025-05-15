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
    public partial class FormEliminarProd : Form
    {
        public FormEliminarProd()
        {
            InitializeComponent();
        }

        private string ObtenerRutaXml()
        {
            // Ruta para el archivo XML en la carpeta "XML"
            return Path.Combine(Application.StartupPath, "XML", "Mochilas.xml");
        }

        private void btnDAceptar_Click(object sender, EventArgs e)
        {
            // Lógica para aceptar la eliminación (si la necesitas agregar más tarde)
        }

        private void btnDCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No se eliminó el producto");
        }

        private void BtnDBuscar_Click(object sender, EventArgs e)
        {
            string rutaXml = ObtenerRutaXml(); // Obtener la ruta dinámica del XML

            // Verificar si la carpeta "XML" existe, si no, crearla
            if (!Directory.Exists(Path.Combine(Application.StartupPath, "XML")))
            {
                Directory.CreateDirectory(Path.Combine(Application.StartupPath, "XML"));
            }

            // Leer XML
            dataSet11.ReadXml(rutaXml);
            System.Data.DataRow[] vector;

            if (string.IsNullOrWhiteSpace(TxtDBuscarCodigo.Text) || !int.TryParse(TxtDBuscarCodigo.Text, out int codigo) || codigo < 0)
            {
                MessageBox.Show("Ingrese un código válido (número entero mayor o igual a 0).");
                return;
            }

            vector = dataSet11.TblDatos.Select("Codigo='" + TxtDBuscarCodigo.Text + "'");

            if (vector.Length > 0)
            {
                MostrarEliminar ObjMosEliminar = new MostrarEliminar(vector);
                if (ObjMosEliminar.ShowDialog() == DialogResult.OK)
                {
                    vector[0].Delete();
                    dataSet11.WriteXml(rutaXml); // Guardar los cambios en el archivo XML
                    MessageBox.Show("Producto eliminado");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se eliminó el producto");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No se encuentran datos con ese código");
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
           
        }

        private void FormEliminarProd_Load(object sender, EventArgs e)
        {
           
        }
    }
}
