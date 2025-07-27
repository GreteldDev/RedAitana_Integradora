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
        // Vista para filtrar dinámicamente los datos mostrados en el DataGridView
        private DataView vistaFiltrada;

        // Referencia a la ventana de registro general
        private RegistroGeneral registroGeneral; 

        // Constructor del formulario
        public VisitaPorSeleccion(RegistroGeneral rGeneral)
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            this.registroGeneral = rGeneral; // Guarda la referencia a la ventana de registro general
        }

        // Evento del botón Atrás para regresar a la ventana anterior
        private void btnAtras_Click(object sender, EventArgs e)
        {
            var registroGeneral = new RegistroGeneral(); // Crear nueva instancia de la ventana de registro
            registroGeneral.Show(); // Mostrarla
            this.Hide(); // Ocultar la ventana actual
        }

        // Evento por si se necesita lógica al hacer clic en una celda (no implementado actualmente)
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        // Filtro dinámico cuando cambia el texto en el cuadro de búsqueda
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (vistaFiltrada == null) return; // Si no hay datos, no hacer nada

            string texto = txtBuscar.Text.Trim().Replace("'", "''"); // Sanitizar texto para evitar errores SQL

            // Filtro sobre nombre o apellido que contiene el texto buscado
            vistaFiltrada.RowFilter = $"Nombre LIKE '%{texto}%' OR Apellido LIKE '%{texto}%'";
        }

        // Carga inicial de datos al pintar el panel (solo ocurre una vez en diseño)
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            using (ConexionMySQL conexion = new ConexionMySQL())
            {
                conexion.AbrirConexion();

                // Consulta SQL unificando personal y personalextra para mostrar todos
                string query = @"
                SELECT IdPersonal AS id, Tipo AS Rol, 
                CONCAT(PrimerNombre, ' ', SegundoNombre) AS Nombre, 
                CONCAT(PrimerApellido, ' ', SegundoApellido) AS Apellido,
                'Personal' AS TipoOrigen
                FROM personal 
                INNER JOIN rol ON personal.IdRol = rol.Id 

                UNION 

                SELECT IdPersonalExtra AS id, Tipo AS Rol, 
                CONCAT(PrimerNombre, ' ', SegundoNombre) AS Nombre, 
                CONCAT(PrimerApellido, ' ', SegundoApellido) AS Apellido,
                'PersonalExtra' AS TipoOrigen
                FROM personalextra 
                INNER JOIN rol ON personalextra.IdRol = rol.Id;";

                // Adaptador para llenar el DataTable
                MySqlCommand Puente = new MySqlCommand(query, conexion.conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(Puente);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                // Aplicar filtro visual dinámico sobre los datos cargados
                vistaFiltrada = new DataView(tabla);
                dataGridView1.DataSource = vistaFiltrada; // Mostrar en el DataGridView
                dataGridView1.Columns["TipoOrigen"].Visible = false; // Ocultar columna auxiliar

                // Hacer todas las columnas solo lectura
                foreach (DataGridViewColumn columna in dataGridView1.Columns)
                {
                    columna.ReadOnly = true;
                }

                conexion.CerrarConexion();
            }
        }

        // Botón para registrar la SALIDA de una persona
        private void btnRegistroSalida_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una fila para registrar la salida.");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
            var tipoOrigen = dataGridView1.SelectedRows[0].Cells["TipoOrigen"].Value.ToString();

            using (ConexionMySQL conexion = new ConexionMySQL())
            {
                conexion.AbrirConexion();

                string query = "";

                // Según el tipo, actualizar la salida correspondiente
                if (tipoOrigen == "Personal")
                {
                    query = @"UPDATE registroentradasalida 
                      SET fechaSalida = CURRENT_TIMESTAMP 
                      WHERE id_personal = @id AND fechaSalida IS NULL 
                      ORDER BY id_entrada_salida DESC 
                      LIMIT 1";
                }
                else if (tipoOrigen == "PersonalExtra")
                {
                    query = @"UPDATE registroentradasalida 
                      SET fechaSalida = CURRENT_TIMESTAMP 
                      WHERE id_personalExtra = @id AND fechaSalida IS NULL 
                      ORDER BY id_entrada_salida DESC 
                      LIMIT 1";
                }
                else
                {
                    MessageBox.Show("Tipo no reconocido: " + tipoOrigen);
                    return;
                }

                MySqlCommand cmd = new MySqlCommand(query, conexion.conexion);
                cmd.Parameters.AddWithValue("@id", id);

                int filasAfectadas = cmd.ExecuteNonQuery(); // Ver cuántas filas fueron actualizadas
                conexion.CerrarConexion();

                // Confirmar resultado al usuario
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Salida registrada correctamente.");
                    this.Close(); // Cerrar la ventana actual
                }
                else
                {
                    MessageBox.Show("No se encontró una entrada pendiente para esta persona.");
                }
            }
        }

        // Botón para registrar la ENTRADA de una persona
        private void btnRegistroEntrada_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una fila para registrar la entrada.");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
            var tipo = dataGridView1.SelectedRows[0].Cells["TipoOrigen"].Value.ToString();

            using (ConexionMySQL conexion = new ConexionMySQL())
            {
                conexion.AbrirConexion();

                string query = "";
                MySqlCommand cmd;

                // Según el tipo, insertar entrada para personal o personal extra
                if (tipo == "Personal")
                {
                    query = "INSERT INTO registroentradasalida (id_personal) VALUES (@id_personal)";
                    cmd = new MySqlCommand(query, conexion.conexion);
                    cmd.Parameters.AddWithValue("@id_personal", id);
                }
                else if (tipo == "PersonalExtra")
                {
                    query = "INSERT INTO registroentradasalida (id_personalExtra) VALUES (@id_personalExtra)";
                    cmd = new MySqlCommand(query, conexion.conexion);
                    cmd.Parameters.AddWithValue("@id_personalExtra", id);
                }
                else
                {
                    MessageBox.Show("Tipo no reconocido." + tipo);
                    return;
                }

                cmd.ExecuteNonQuery();
                conexion.CerrarConexion();
            }

            MessageBox.Show("Entrada registrada.");
            this.Close(); // Cerrar la ventana actual
        }
    }
}