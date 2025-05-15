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
       
        public FrmMaletasPorProveedor()
        {
            InitializeComponent();
     
        }

        private void FrmMaletasPorProveedor_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            MostrarDatosAgrupados();
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
        private void MostrarDatosAgrupados()
        {
            try
            {
                string rutaXml = Path.Combine(Application.StartupPath,"XML", "Mochilas.xml");
                DataSet ds = new DataSet();

                if (!File.Exists(rutaXml))
                {
                    MessageBox.Show("No se encontró el archivo de datos.");
                    return;
                }

                ds.ReadXml(rutaXml);

                var tabla = ds.Tables["TblDatos"];

                if (tabla == null)
                {
                    MessageBox.Show("La tabla 'TblDatos' no existe en el archivo XML.");
                    return;
                }

                // Contar maletas por proveedor, cada fila es una maleta
                var proveedores = tabla.AsEnumerable()
                    .GroupBy(row => row.Field<string>("Proveedor"))
                    .Select(g => new
                    {
                        Proveedor = g.Key,
                        Cantidad = g.Count()
                    });

                // Crear DataTable para el reporte
                DataTable dtAgrupado = new DataTable();
                dtAgrupado.Columns.Add("Proveedor", typeof(string));
                dtAgrupado.Columns.Add("NumeroDeMaletas", typeof(int));

                foreach (var p in proveedores)
                {
                    dtAgrupado.Rows.Add(p.Proveedor, p.Cantidad);
                }

                // Pasar DataTable al ReportViewer
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dtAgrupado));

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
