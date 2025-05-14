using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppMenu
{
    public partial class MostrarEliminar : Form
    {
        public MostrarEliminar(System.Data.DataRow[] Vector)
        {
            InitializeComponent();
            LblDCodigo.Text = Vector[0]["Codigo"].ToString();
            LblDTipo.Text = Vector[0]["Tipo"].ToString();
            LblDUso.Text = Vector[0]["Uso"].ToString();
            LblDColor.Text = Vector[0]["Color"].ToString();
            LblDPrecio.Text = Vector[0]["Precio"].ToString();
            LblDMarca.Text = Vector[0]["Marca"].ToString();
            LblDProveedor.Text = Vector[0]["Proveedor"].ToString();
            LblDCapacidad.Text = Vector[0]["Capacidad"].ToString();
            LblDGarantia.Text = Vector[0]["Garantia"].ToString();
            LblDDescripcion.Text = Vector[0]["Descripcion"].ToString();
        }

        private void MostrarEliminar_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
