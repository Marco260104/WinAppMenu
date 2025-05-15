using System;
using System.IO;
using System.Linq;
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
            // Solo permitir letras y control (backspace, etc)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContra.Text;

            if (string.IsNullOrEmpty(usuario) || usuario == "Ingrese su usuario")
            {
                MessageBox.Show("Por favor ingrese su usuario.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            // Validación: usuario solo letras (ya validado en KeyPress pero aquí por seguridad)
            if (!usuario.All(char.IsLetter))
            {
                MessageBox.Show("El usuario solo debe contener letras.", "Usuario inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrEmpty(contrasena) || contrasena == "Ingrese la contraseña")
            {
                MessageBox.Show("Por favor ingrese su contraseña.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContra.Focus();
                return;
            }

            if (contrasena.Contains(" "))
            {
                MessageBox.Show("La contraseña no debe contener espacios.", "Contraseña inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContra.Focus();
                return;
            }

            try
            {
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Usuario.txt");

                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Close();
                }

                // Leer todo el archivo para verificar si ya existe el usuario
                var lineas = File.ReadAllLines(filePath);
                bool usuarioExiste = lineas.Any(line =>
                    line.Split(',')[0].Trim().Equals($"Usuario: {usuario}", StringComparison.OrdinalIgnoreCase));

                if (usuarioExiste)
                {
                    MessageBox.Show("El usuario ya existe. Por favor ingrese otro nombre de usuario.", "Usuario duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Focus();
                    return;
                }

                // Guardar nuevo usuario
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine($"Usuario: {usuario}, Contraseña: {contrasena}");
                }

                MessageBox.Show("Usuario registrado con éxito!");
                txtUsuario.Clear();
                txtContra.Clear();
                txtUsuario.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtUsuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtContra.Focus();
            }
        }

        private void txtContra_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnRegistro.Focus();
            }
        }

        private void registro_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }
    }
}
