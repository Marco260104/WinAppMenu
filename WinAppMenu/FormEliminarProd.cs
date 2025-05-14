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

        private void btnDAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnDCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No se elimino el producto");
        }

        private void BtnDBuscar_Click(object sender, EventArgs e)
        {
            string rutaXml = Path.Combine(Application.StartupPath, "Mochilas.xml");
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
                    dataSet11.WriteXml(rutaXml);
                    MessageBox.Show("Producto eliminado");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se elimino el producto");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No se encuentran datos con ese codigo");
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
