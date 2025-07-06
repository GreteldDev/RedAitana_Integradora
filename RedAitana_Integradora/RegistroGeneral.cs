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
    public partial class RegistroGeneral : Form
    {
        public RegistroGeneral()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) //boton visita general
        {
            var visitaManual = new VisitaGeneral(); //Abrir ventana de visita manual
            visitaManual.ShowDialog(); // Mostrar la ventana de visita manual
           
        }

        private void button5_Click(object sender, EventArgs e) //boton visita por seleccion
        {
            var visitaPorSeleccion = new VisitaPorSeleccion(); //Abrir ventana de visita por seleccion
            visitaPorSeleccion.ShowDialog(); // Mostrar la ventana de visita por seleccion
            
        }
        
    }
}
