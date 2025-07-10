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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            using (ConexionMySQL conexion = new ConexionMySQL()) //crea una instancia de la clase ConexionMySQL para manejar la conexión a la base de datos
            {
                conexion.AbrirConexion(); //abre la conexión a la base de datos
                string query = @"SELECT IdPersonal AS id, Tipo AS Rol, PrimerNombre, SegundoNombre,PrimerApellido,SegundoApellido FROM personal INNER JOIN rol ON personal.IdRol = rol.Id UNION SELECT IdPersonalExtra AS id, Tipo AS Rol, PrimerNombre, SegundoNombre,PrimerApellido,SegundoApellido FROM personalextra INNER JOIN rol ON personalextra.IdRol = rol.Id;"; //consulta para obtener los datos de la tabla personal y personalextra
                MySqlCommand Puente = new MySqlCommand(query, conexion.conexion); //crea un puente entre las instrucciones que quieres dar(query) y la base de datos(conexion.conexion)
                MySqlDataAdapter adaptador = new MySqlDataAdapter(Puente); //crea un adaptador para ejecutar la consulta y llenar el DataGridView
                DataTable tabla = new DataTable(); //crea una tabla para almacenar (en memoria, no en la base de datos)los datos obtenidos de la consulta
                adaptador.Fill(tabla); //llena la tabla con los datos obtenidos de la consulta
                dataGridView1.DataSource = tabla; //asigna la tabla como fuente de datos del DataGridView para mostrar los resultados

                conexion.CerrarConexion(); //cierra la conexión a la base de datos
            }
        }
    }
}
