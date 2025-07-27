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
    public partial class VentanaConfirmacion : Form
    {
        public VentanaConfirmacion()
        {
            InitializeComponent(); // Debes tener un TextBox llamado txtClave y dos botones
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtClave.Text == "admin")
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta.");
                txtClave.Clear();
                txtClave.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
