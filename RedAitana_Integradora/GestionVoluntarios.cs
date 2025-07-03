using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedAitana_Integradora
{
    public partial class GestionVoluntarios : Form
    {
        string CadenaConexion = "server = localhost; user id=root; password = duvanvader1; database=aitanabsd";

        public GestionVoluntarios()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario actual
            this.Hide();

            // Verificar si ya tienes una instancia de Bienvenido abierta
            //AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
            // O crear una nueva instancia si no la guardaste
            Bienvenido bienvenido = new Bienvenido();
            bienvenido.Show();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nuevoVoluntario = new NuevoVoluntario(); //Abrir ventana de registro general
            nuevoVoluntario.Show(); // Mostrar la ventana de registro general
            this.Hide();
        }
    }
}
