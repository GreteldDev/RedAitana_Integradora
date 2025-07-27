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
        private Form formularioActivo = null;
        public Bienvenido()
        {

            InitializeComponent();

        }

        private void AbrirFormularioEnPanel(Form formHijo, Button boton)
        {
            if (formularioActivo != null && formularioActivo.GetType() == formHijo.GetType())
                return;

            if (formularioActivo != null)
                formularioActivo.Close();

            ResetearColoresBotones();
            ActivarBoton(boton);

            formularioActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(formHijo);
            panelContenedor.Tag = formHijo;

            formHijo.Show();
        }

        private void ResetearColoresBotones()
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is Button btn)
                {
                    btn.BackColor = Color.FromArgb(117, 76, 154); // Color base del menú
                    btn.ForeColor = Color.White;
                }
            }
        }
        private void ActivarBoton(Button boton)
        {
            ResetearColoresBotones();
            boton.BackColor = Color.FromArgb(223, 128, 108); // Color al seleccionar
            boton.ForeColor = Color.White;
        }
        private void Bienvenido_Load_1(object sender, EventArgs e)
        { }

        private void label2_Click_1(object sender, EventArgs e)
        { }

        private void btnRegistroGeneral_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new RegistroGeneral(), btnRegistroGeneral);
        }

        private void btnGestionEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new GestionTrabajadores(), btnGestionEmpleados);
        }

        private void btnGestionVoluntarios_Click_1(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new GestionVoluntarios(), btnGestionVoluntarios);
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        { }
        // private Label label1;
    }
}
