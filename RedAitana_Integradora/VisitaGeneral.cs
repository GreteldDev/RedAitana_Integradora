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
    public partial class VisitaGeneral : Form
    {
        public VisitaGeneral()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
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
            var gestionVoluntarios = new GestionVoluntarios();
            gestionVoluntarios.Show();
            this.Hide();
        }

        private void btnAtras_Click(object sender, EventArgs e) //boton atras
        {
            var registroGeneral = new RegistroGeneral(); //Abrir ventana de registro general
            registroGeneral.Show(); // Mostrar la ventana de registro general
            this.Hide();
        }
    }
}
