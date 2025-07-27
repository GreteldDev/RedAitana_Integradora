namespace RedAitana_Integradora
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();

            // Puedes usar esto si decides controlar el tipo desde el combo
            comboBox1.Items.Add("Administrador");
            comboBox1.Items.Add("Usuario");
            comboBox1.SelectedIndex = -1;
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string passwordIngresada = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(passwordIngresada))
            {
                MessageBox.Show("Ingrese la contraseña.");
                return;
            }

            if (ValidarCredencial.IniciarSesion(passwordIngresada))
            {
                MessageBox.Show($"Bienvenido {ValidarCredencial.TipoUsuario}");

                var ventanaBienvenido = new Bienvenido(); // instancia tu formulario de bienvenida
                ventanaBienvenido.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra la ventana de login
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void txtPassword_TextChanged(object sender, EventArgs e) { }
    }
}

