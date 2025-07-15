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
        {
            using (ConexionMySQL conexion = new ConexionMySQL())
            {
                conexion.AbrirConexion(); //abre la conexión a la base de datos
                string query = @"SELECT IdPersonal AS id, Tipo AS Rol, PrimerNombre, SegundoNombre,PrimerApellido,SegundoApellido, Correo, Telefono FROM personal INNER JOIN rol ON personal.IdRol = rol.Id"; //consulta para obtener los datos de la tabla personal y personalextra
                MySqlCommand Puente = new MySqlCommand(query, conexion.conexion); //crea un puente entre las instrucciones que quieres dar(query) y la base de datos(conexion.conexion)
                MySqlDataAdapter adaptador = new MySqlDataAdapter(Puente); //crea un adaptador para ejecutar la consulta y llenar el DataGridView
                DataTable tabla = new DataTable(); //crea una tabla para almacenar (en memoria, no en la base de datos)los datos obtenidos de la consulta
                adaptador.Fill(tabla); //llena la tabla con los datos obtenidos de la consulta
                dataGridView1.DataSource = tabla; //asigna la tabla como fuente de datos del DataGridView para mostrar los resultados

                conexion.CerrarConexion(); //cierra la conexión a la base de datos
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nuevoVoluntario = new NuevoVoluntario(); //Abrir ventana de registro general
            nuevoVoluntario.ShowDialog(); // Mostrar la ventana de registro general
        }

        private void GestionVoluntarios_Load(object sender, EventArgs e)
        { }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }
        private void BuscarDatos(string busqueda) // Método para buscar datos en la base de datos
        {
            using (ConexionMySQL conexion = new ConexionMySQL()) //que haga que busque en toda la tabla
            {
                conexion.AbrirConexion();
                string query = @"SELECT IdPersonal AS id, Tipo AS Rol,  WHERE CONCAT(PrimerNombre, ' ', SegundoNombre) LIKE @busqueda
                            OR CONCAT(PrimerApellido, ' ', SegundoApellido) LIKE @busqueda
                            OR correo LIKE @busqueda
                            OR telefono LIKE @busqueda"";
                INNER JOIN rol ON personal.IdRol = rol.Id WHERE PrimerNombre 
                LIKE @busqueda OR SegundoNombre LIKE @busqueda OR PrimerApellido LIKE @busqueda OR SegundoApellido LIKE @busqueda";
                MySqlCommand comando = new MySqlCommand(query, conexion.conexion);
                comando.Parameters.AddWithValue("@busqueda", "%" + busqueda + "%");
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;
                conexion.CerrarConexion();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        { // Evento que se ejecuta cuando el texto del TextBox cambia
            BuscarDatos(txtBuscar.Text.Trim());
        }
    }
}
