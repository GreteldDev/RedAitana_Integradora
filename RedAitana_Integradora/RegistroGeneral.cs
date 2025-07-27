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
    public partial class RegistroGeneral : Form
    {
        public RegistroGeneral()
        {
            InitializeComponent(); // Inicializa los componentes del formulario
        }

        
        /// Evento que se ejecuta al cargar el formulario RegistroGeneral.
        /// Carga y muestra todos los registros de entradas y salidas.
        
        private void Form3_Load(object sender, EventArgs e)
        {
            using (ConexionMySQL conexion = new ConexionMySQL())
            {
                conexion.AbrirConexion(); // Abre la conexión a la base de datos

                // Consulta que recupera los registros de entradas y salidas
                string query = @"SELECT 
                registroentradasalida.id_entrada_salida AS Id,
                registroentradasalida.id_personal,
                registroentradasalida.id_personalExtra,
                CONCAT(p.PrimerNombre, ' ', p.SegundoNombre) AS Nombre,
                CONCAT(p.PrimerApellido, ' ', p.SegundoApellido) AS Apellido,
                r.Tipo AS Rol,
                fechaEntrada,
                fechaSalida
                FROM registroentradasalida
                LEFT JOIN personal p ON registroentradasalida.id_personal = p.IdPersonal
                LEFT JOIN personalextra pe ON registroentradasalida.id_personalExtra = pe.IdPersonalExtra
                LEFT JOIN rol r ON 
                (p.IdRol = r.Id OR pe.IdRol = r.Id)
                ORDER BY registroentradasalida.id_entrada_salida DESC;";

                MySqlCommand cmd = new MySqlCommand(query, conexion.conexion); // Crea el comando
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd); // Adaptador para llenar el DataTable
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla); // Llena la tabla con los datos recuperados

                dgvGeneral.DataSource = tabla; // Asigna los datos al DataGridView
                dgvGeneral.Columns["id_personal"].Visible = false; // Oculta columnas no necesarias
                dgvGeneral.Columns["id_personalExtra"].Visible = false;

                // Establece todas las columnas como solo lectura
                foreach (DataGridViewColumn columna in dgvGeneral.Columns)
                {
                    columna.ReadOnly = true;
                }

                conexion.CerrarConexion(); // Cierra la conexión a la base de datos
            }
        }
    
        /// Evento del botón para abrir la ventana de visita por selección.
       
        private void btnSeleccionar_Click(object sender, EventArgs e) // Botón visita por selección
        {
            var visitaPorSeleccion = new VisitaPorSeleccion(null); // Instancia de la ventana VisitaPorSeleccion
            visitaPorSeleccion.ShowDialog(); // Abre la ventana como diálogo modal
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var editarGeneral = new EditarGeneral(1); // Instancia de EditarGeneral
            editarGeneral.ShowDialog(); // Abre la ventana como diálogo modal
        }
    }
}
