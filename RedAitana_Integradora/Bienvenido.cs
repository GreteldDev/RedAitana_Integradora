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

        }

        private void AbrirFormularioEnPanel(Form formHijo)
        {
            // Limpia cualquier control anterior del panel
            if (panelContenedor.Controls.Count > 0)
                panelContenedor.Controls.RemoveAt(0);

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(formHijo);
            panelContenedor.Tag = formHijo;

            formHijo.Show();
        }

        private void Bienvenido_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRegistroGeneral_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new RegistroGeneral());
        }

        private void btnGestionEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new GestionEmpleados());
        }

        private void btnGestionVoluntarios_Click_1(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new GestionVoluntarios());
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
        // private Label label1;
    }
}
