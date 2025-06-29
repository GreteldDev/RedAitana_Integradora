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
        public GestionVoluntarios()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
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
    }
}
