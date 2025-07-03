namespace RedAitana_Integradora
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();

            comboBox1.Items.Add("Administrador");
            comboBox1.Items.Add("Usuario");

        }

        private void btnIngresar_Click(object sender, EventArgs e) //boton iniciar sesion
        {
            string usuarioSeleccionado = comboBox1.SelectedItem?.ToString(); // ? previene error si no selecciona nada
            string contrasenia = txtContrasenia.Text;

            if (usuarioSeleccionado == "Administrador" && contrasenia == "admin")
            {
                MessageBox.Show("Bienvenido, administrador", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                var bienvenido = new Bienvenido(); //Abrir ventana del menu principal
                bienvenido.Show(); // Mostrar la ventana del menú principal
                this.Hide(); // Ocultar la ventana de inicio de sesión
            }
            else if (usuarioSeleccionado == "Usuario" && contrasenia == "user")
            {
                MessageBox.Show("Bienvenido, usuario", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var bienvenido = new Bienvenido();
                bienvenido.Show(); // Mostrar la ventana del menú principal
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
