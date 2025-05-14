using System;
using System.IO;
using System.Windows.Forms;

namespace WinAppMenu
{
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; 
            }
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContra.Text))
            {
                MessageBox.Show("Por favor ingresa tanto el nombre de usuario como la contraseña.");
                return;
            }

            string usuario = txtUsuario.Text;
            string contrasena = txtContra.Text;

            try
            {
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Usuario.txt");

                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Close();
                }

                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine($"Usuario: {usuario}, Contraseña: {contrasena}");
                }

                MessageBox.Show("Usuario registrado con éxito!");
                txtUsuario.Clear();  
                txtContra.Clear();   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar el usuario: " + ex.Message);
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
