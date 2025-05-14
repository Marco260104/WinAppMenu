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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string rutaXml = Path.Combine(Application.StartupPath, "Mochilas.xml");
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
                    MessageBox.Show("cambios guardados");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se modifico los datos");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No se encontraron datos con ese codigo");
            }
        }

        private void FormEditarProd_Load(object sender, EventArgs e)
        {

        }
    }
}
