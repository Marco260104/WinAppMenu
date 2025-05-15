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
    public partial class FormEditarProd : Form
    {
        public FormEditarProd()
        {
            InitializeComponent();
        }

        private string ObtenerRutaXml()
        {
            // Ruta para el archivo XML en la carpeta "XML"
            return Path.Combine(Application.StartupPath, "XML", "Mochilas.xml");
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string rutaXml = ObtenerRutaXml(); // Obtener la ruta dinámica del XML

            // Verificar si la carpeta "XML" existe, si no, crearla
            if (!Directory.Exists(Path.Combine(Application.StartupPath, "XML")))
            {
                Directory.CreateDirectory(Path.Combine(Application.StartupPath, "XML"));
            }

            // Leer XML
            dataSet11.ReadXml(rutaXml);
            System.Data.DataRow[] vector, vectorAuxiliar;
            vector = dataSet11.TblDatos.Select("Codigo='" + TxtEBuscarCodigo.Text + "'");

            if (vector.Length > 0)
            {
                MostrarEditar ObjMosEditar = new MostrarEditar(vector);
                if (ObjMosEditar.ShowDialog() == DialogResult.OK)
                {
                    vectorAuxiliar = vector;
                    ObjMosEditar.vectorDatos(vectorAuxiliar);
                    vectorAuxiliar[0].AcceptChanges();
                    dataSet11.WriteXml(rutaXml);
                    MessageBox.Show("Cambios guardados");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se modificaron los datos");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No se encontraron datos con ese código");
            }
        }

        private void FormEditarProd_Load(object sender, EventArgs e)
        {

        }
    }
}
