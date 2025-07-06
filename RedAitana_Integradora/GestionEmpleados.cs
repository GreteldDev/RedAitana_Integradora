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
    public partial class GestionEmpleados : Form
    {
        public GestionEmpleados()
        {
            InitializeComponent();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //boton nuevo empleado
        {
            var nuevoEmpleado = new NuevoEmpleado(); //Abrir ventana de nuevo empleado
            nuevoEmpleado.ShowDialog(); // Mostrar la ventana de nuevo empleado
           
        }
        
    }
}
