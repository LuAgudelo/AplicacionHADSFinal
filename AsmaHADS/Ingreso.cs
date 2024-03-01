using Negocio;
using Repositorio;

namespace AsmaHADS
{
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
        }
      
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            erpIngreso.SetError(txtUsuario, null);
            erpIngreso.SetError(txtContraseña, null);
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                erpIngreso.SetError(txtUsuario, "Por favor Ingrese el usuario");
                return;
            }
            if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                erpIngreso.SetError(txtContraseña, "Por favor Ingrese la contraseña");
                return;
            }

            INegocioUsuario negocio = new NegocioUsuario(new RepositorioSeguridad());
            if (negocio.ValidarUsuario(txtUsuario.Text, txtContraseña.Text))
            {
                var principal = new MDIPrincipal();
                principal.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Las credenciales de ingreso no son válidas. Por favor verifique.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {

        }
    }
}