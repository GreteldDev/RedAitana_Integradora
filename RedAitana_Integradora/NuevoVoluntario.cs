using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Asegúrate de tener la referencia nugget a MySql.Data

namespace RedAitana_Integradora
{
    public partial class NuevoVoluntario : Form
    {
        string CadenaConexion = "server = localhost; user id=root; password = duvanvader1; database=aitanabsd"; // Cadena de conexión a la base de datos MySQL
        public NuevoVoluntario()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {

            this.Hide();
            Bienvenido bienvenido = new Bienvenido();
            bienvenido.Show();
        }

        private void button1_Click(object sender, EventArgs e) //Boton de guardar datos del voluntario
        {
            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();
                    string query = "INSERT INTO personal (PrimerNombre, SegundoNombre, PrimerApelido, SegundoApellido, correo, telefono) " +
                        "VALUES (@PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, @correo, @telefono)";
                    MySqlCommand comando = new MySqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@PrimerNombre", txtPrimerNombre.Text);
                    comando.Parameters.AddWithValue("@SegundoNombre", txtSegundoNombre.Text);
                    comando.Parameters.AddWithValue("@PrimerApellido", txtPrimerApellido.Text);
                    comando.Parameters.AddWithValue("@SegundoApellido", txtSegundoApellido.Text);
                    comando.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    comando.Parameters.AddWithValue("@correo", txtCorreo.Text);
                    int filasAfectadas = comando.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Voluntario registrado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar el voluntario.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
       

        private void button1_Click_1(object sender, EventArgs e) //boton para probar la conexion a la base de datos
        {
            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                try
                {
                    conexion.Open();
                    MessageBox.Show("Conexión exitosa a la base de datos.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);

                }

            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
