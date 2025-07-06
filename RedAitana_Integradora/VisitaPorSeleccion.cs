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
    public partial class VisitaPorSeleccion : Form
    {
        public VisitaPorSeleccion()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e) //boton para ir atras
        {
            var registroGeneral = new RegistroGeneral(); //Abrir ventana de registro general
            registroGeneral.Show(); // Mostrar la ventana de registro general
            this.Hide();
        }
    }
}
