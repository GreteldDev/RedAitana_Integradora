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
    public partial class Bienvenido : Form
    {
        public Bienvenido()
        {

            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
        }


        //

        private void Bienvenido_Load(object sender, EventArgs e)
        {

        }

        private void Bienvenido_Load_1(object sender, EventArgs e)
        {

        }

        private void btnRegistroGeneral_Click(object sender, EventArgs e)
        {
            var registroGeneral = new RegistroGeneral(); //Abrir ventana de registro general
            registroGeneral.Show(); // Mostrar la ventana de registro general
            this.Hide();
        }

        private void btnGestionEmpleados_Click(object sender, EventArgs e)
        {
            var gestionEmpleados = new GestionEmpleados(); //Abrir ventana de gestión de empleados
            gestionEmpleados.Show(); // Mostrar la ventana de gestión de empleados
            this.Hide();
        }

        private void btnGestionVoluntarios_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGestionVoluntarios_Click_1(object sender, EventArgs e)
        {
            var gestionVoluntarios = new GestionVoluntarios();
            gestionVoluntarios.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        // private Label label1;
    }
}
