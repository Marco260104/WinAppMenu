using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinAppMenu
{
    public partial class FrmMaletasPorProveedor : Form
    {
        DataTable mochilasTable;

        public FrmMaletasPorProveedor()
        {
            InitializeComponent();
            string rutaXml = Path.Combine(Application.StartupPath, "XML", "Mochilas.xml");
            dataSet1.ReadXml(rutaXml);
            mochilasTable = dataSet1.Tables[0];

            // Configurar el evento para el botón de búsqueda
            BtnBuscar.Click += BtnBuscar_Click;
        }

        private void FrmMaletasPorProveedor_Load(object sender, EventArgs e)
        {
            // Solo inicializar el reportViewer sin cargar datos
            this.reportViewer1.RefreshReport();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre de proveedor.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string proveedorBuscado = textBox1.Text.Trim();
            DataView vistaFiltrada = new DataView(mochilasTable);
            vistaFiltrada.RowFilter = $"Proveedor LIKE '%{proveedorBuscado}%'";

            if (vistaFiltrada.Count == 0)
            {
                MessageBox.Show($"No se encontraron maletas del proveedor '{proveedorBuscado}'.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Cargar el informe con los datos filtrados
            Microsoft.Reporting.WinForms.ReportDataSource rds =
                new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", vistaFiltrada);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            // Este método puede quedar vacío
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            reportViewer1.Visible = true;
        }

        private void BtnBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Evitar el sonido de error al presionar Enter
                BtnBuscar_Click_1(sender, e);
            }
            
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}