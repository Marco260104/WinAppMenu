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
    public partial class FormTotalProductos : Form
    {
        public FormTotalProductos()
        {
            InitializeComponent();
        }

        private void FormTotalProductos_Load(object sender, EventArgs e)
        {
            string rutaXml = Path.Combine(Application.StartupPath, "Mochilas.xml");

            if (System.IO.File.Exists(rutaXml))
            {
                dataSet11.Clear();
                dataSet11.ReadXml(rutaXml); // Leer los datos del archivo
                dataGridView1.DataSource = dataSet11.TblDatos;

                // Mostrar total en un Label (si tienes uno, por ejemplo lblTotalProductos)
                LblTotalProductos.Text = "Total de mochilas registradas: " + dataSet11.TblDatos.Rows.Count;
            }
            else
            {
                MessageBox.Show("No se encontró el archivo de mochilas.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
