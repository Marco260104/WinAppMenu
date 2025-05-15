using Microsoft.Reporting.WinForms;
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
    public partial class FrmMaletasPorProveedor : Form
    {
        DataTable mochilasTable;

        public FrmMaletasPorProveedor()
        {
            InitializeComponent();
            string rutaXml = Path.Combine(Application.StartupPath, "XML", "Mochilas.xml");
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(rutaXml);
            mochilasTable = dataSet.Tables[0];

          
            BtnBuscar.Click += BtnBuscar_Click;
        }

        private void FrmMaletasPorProveedor_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            MostrarTodosLosDatos();
        }

        private void MostrarTodosLosDatos()
        {
            try
            {
                // Pasar DataTable completo al ReportViewer
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", mochilasTable));
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarPorProveedor();
        }

        private void FiltrarPorProveedor()
        {
            try
            {
                string proveedorBuscado = textBox1.Text.Trim();

                if (string.IsNullOrEmpty(proveedorBuscado))
                {
                    // Si el TextBox está vacío, mostrar todos los datos
                    MostrarTodosLosDatos();
                    return;
                }

                // Crear una vista filtrada por el proveedor ingresado
                DataView vistaFiltrada = new DataView(mochilasTable);
                vistaFiltrada.RowFilter = $"Proveedor LIKE '%{proveedorBuscado}%'";

                // Verificar si hay resultados
                if (vistaFiltrada.Count == 0)
                {
                    MessageBox.Show($"No se encontraron maletas del proveedor '{proveedorBuscado}'.");
                    return;
                }

                // Pasar la vista filtrada al ReportViewer
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", vistaFiltrada));
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar: " + ex.Message);
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {
            
        }
    }
}