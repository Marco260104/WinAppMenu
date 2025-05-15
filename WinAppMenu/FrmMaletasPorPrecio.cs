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

namespace WinAppMenu
{
    public partial class FrmMaletasPorPrecio : Form
    {
        DataTable mochilasTable;
        public FrmMaletasPorPrecio()
        {
            InitializeComponent();
            string rutaXml = Path.Combine(Application.StartupPath, "Mochilas.xml");
            dataSet1.ReadXml(rutaXml);
            mochilasTable = dataSet1.Tables[0];
        }

        private void FrmMaletasPorPrecio_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    float precio = float.Parse(txtPrecio.Text);
                    if (precio < 0)
                    {
                        MessageBox.Show("Ingresar de nuevo. No hay precios negativos");
                        txtPrecio.Clear();
                    }
                    else
                    {
                        btnMostrar.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Valores no validos. Ingrese valores numericos");
                    txtPrecio.Clear();
                }
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                float precio = float.Parse(txtPrecio.Text);
                if (precio < 0)
                {
                    MessageBox.Show("Ingresar de nuevo. No hay precios negativos");
                    txtPrecio.Clear();
                }
                else
                {
                    DataView vistaFiltrada = new DataView(mochilasTable);
                    vistaFiltrada.RowFilter = $"Precio = '{precio}'";

                    // Cargar el informe con los datos filtrados
                    Microsoft.Reporting.WinForms.ReportDataSource rds =
                        new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", vistaFiltrada);

                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rds);
                    reportViewer1.RefreshReport();
                }
            }
            catch
            {
                MessageBox.Show("Valores no validos. Ingrese valores númericos");
                txtPrecio.Clear();
            }
        }
    }
}
