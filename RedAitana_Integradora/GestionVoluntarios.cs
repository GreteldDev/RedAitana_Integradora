using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RedAitana_Integradora.BSD;

namespace RedAitana_Integradora
{
    public partial class GestionVoluntarios : Form
    {

        public GestionVoluntarios()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        { }

        private void button1_Click(object sender, EventArgs e) //btnAgregar_Click
        {
            var nuevoVoluntario = new NuevoVoluntario(); //Abrir ventana de registro general
            nuevoVoluntario.ShowDialog(); // Mostrar la ventana de registro general
        }

        private void GestionVoluntarios_Load(object sender, EventArgs e)
        {
            CargarDatosPersonalExtra(); // Cargar los datos de la tabla personalextra al iniciar el formulario
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }


        private void CargarDatosPersonalExtra()
        { // Método para cargar los datos de la tabla personalextra
            using (ConexionMySQL conexion = new ConexionMySQL())
            {
                conexion.AbrirConexion();
                string query = @"SELECT IdPersonalExtra AS id, Tipo AS Rol, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido FROM personalextra INNER JOIN rol ON personalextra.IdRol = rol.Id";
                MySqlCommand comando = new MySqlCommand(query, conexion.conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;
                conexion.CerrarConexion();
            }
        }

        private void BuscarDatos(string texto)
        {
            string query = @"SELECT IdPersonalExtra, IdRol, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido
            FROM personalextra
            WHERE PrimerNombre LIKE @texto 
                  OR SegundoNombre LIKE @texto 
                  OR PrimerApellido LIKE @texto 
                  OR SegundoApellido LIKE @texto ";
            using (ConexionMySQL conexion = new ConexionMySQL())
            {
                try
                {
                    MySqlCommand comando = new MySqlCommand(query, conexion.conexion);
                    comando.Parameters.AddWithValue("@texto", "%" + texto + "%");

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    dataGridView1.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar los datos: " + ex.Message);
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarDatos(txtBuscar.Text.Trim());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var editarGeneral = new EditarGeneral(); //Abrir ventana de registro general
            editarGeneral.ShowDialog(); // Mostrar la ventana de registro general
        }
    }
}
