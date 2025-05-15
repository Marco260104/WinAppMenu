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
    public partial class FrmMaletasPorColor : Form
    {
        DataTable mochilasTable;
        public FrmMaletasPorColor()
        {
            InitializeComponent();
            string rutaXml = Path.Combine(Application.StartupPath,"XML", "Mochilas.xml");
            dataSet11.ReadXml(rutaXml);
            mochilasTable = dataSet11.Tables[0];
            cbColor.SelectedIndexChanged += cbColor_SelectedIndexChanged;

        }

        private void FrmMaletasPorColor_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

       
        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbColor.SelectedIndex == -1) return;

            string colorSeleccionado = cbColor.SelectedItem.ToString();

            DataView vistaFiltrada = new DataView(mochilasTable);
            vistaFiltrada.RowFilter = $"Color = '{colorSeleccionado}'";

            // Cargar el informe con los datos filtrados
            Microsoft.Reporting.WinForms.ReportDataSource rds =
                new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", vistaFiltrada);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
