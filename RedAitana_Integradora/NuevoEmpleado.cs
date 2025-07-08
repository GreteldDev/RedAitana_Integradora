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
    public partial class NuevoEmpleado : Form
    {
        public NuevoEmpleado()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e) //boton atras
        {
            var gestionEmpleados = new GestionEmpleados(); //Abrir ventana de gestión de empleados
            gestionEmpleados.Show(); // Mostrar la ventana de gestión de empleados
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
