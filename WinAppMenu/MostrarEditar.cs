using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinAppMenu
{
    public partial class MostrarEditar : Form
    {
        public MostrarEditar(System.Data.DataRow[] Vector)
        {
            InitializeComponent();
            lblECodigo.Text = Vector[0]["Codigo"].ToString();
            txtETipo.Text = Vector[0]["Tipo"].ToString();
            cbEUso.Text = Vector[0]["Uso"].ToString();
            txtEColor.Text = Vector[0]["Color"].ToString();
            txtEPrecio.Text = Vector[0]["Precio"].ToString();
            txtEMarca.Text = Vector[0]["Marca"].ToString();
            txtEProveedor.Text = Vector[0]["Proveedor"].ToString();
            txtECapacidad.Text = Vector[0]["Capacidad"].ToString();
            txtEGarantia.Text = Vector[0]["Garantia"].ToString();
            txtEDescripcion.Text = Vector[0]["Descripcion"].ToString();

        }

        public void vectorDatos(System.Data.DataRow[] VecRowK)
        {
            VecRowK[0]["Codigo"] = lblECodigo.Text;
            VecRowK[0]["Tipo"] = txtETipo.Text;
            VecRowK[0]["Uso"] = cbEUso.Text;
            VecRowK[0]["Color"]= txtEColor.Text;
            VecRowK[0]["Precio"]= txtEPrecio.Text;
            VecRowK[0]["Marca"] = txtEMarca.Text;
            VecRowK[0]["Proveedor"] = txtEProveedor.Text ;
            VecRowK[0]["Capacidad"] = txtECapacidad.Text;
            VecRowK[0]["Garantia"] = txtEGarantia.Text;
            VecRowK[0]["Descripcion"] = txtEDescripcion.Text;

        }


        private void btnEAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnECancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void MostrarEditar_Load(object sender, EventArgs e)
        {

        }
    }
}
