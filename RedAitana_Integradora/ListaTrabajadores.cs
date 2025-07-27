using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using RedAitana_Integradora.BSD;

namespace RedAitana_Integradora
{
    public class ListaTrabajadores
    {
        // Controles visuales externos
        private readonly DataGridView dgv;
        private readonly TextBox txtBusqueda;

        // Lógica de filtrado
        private string rolFiltro = "";                         // "Colaborador", "Trabajador" o vacío (sin filtro)
        private readonly ConexionMySQL conexion = new ConexionMySQL(); // Reutiliza conexión interna

        // Constructor que recibe los controles de destino
        public ListaTrabajadores(DataGridView dgvControl, TextBox txtBusquedaControl)
        {
            dgv = dgvControl;
            txtBusqueda = txtBusquedaControl;

            // Actualización en vivo al escribir en el buscador
            txtBusqueda.TextChanged += (s, e) => CargarDatos();
        }

        // Establece filtro por tipo de rol
        public void AplicarFiltroPorRol(string rolNombre)
        {
            rolFiltro = rolNombre;
            CargarDatos();
        }

        // Quita el filtro actual por rol
        public void LimpiarFiltroRol()
        {
            rolFiltro = "";
            CargarDatos();
        }

        // Carga y muestra los datos filtrados en el DataGridView
        public void CargarDatos()
        {
            try
            {
                conexion.AbrirConexion();

                // Consulta base que muestra personal con sus datos
                string query = @"SELECT p.IdPersonal,
                                    CONCAT_WS(' ', p.PrimerNombre, p.SegundoNombre) AS Nombre,
                                    CONCAT_WS(' ', p.PrimerApellido, p.SegundoApellido) AS Apellidos,
                                    p.Telefono, p.Correo, p.FechaInscripcion, r.Tipo AS Rol
                             FROM personal p
                             JOIN rol r ON p.IdRol = r.Id
                             WHERE 1 = 1";

                string texto = txtBusqueda.Text.Trim();

                // Aplica búsqueda si hay texto
                if (!string.IsNullOrEmpty(texto))
                {
                    query += @" AND (
                                CONCAT_WS(' ', p.PrimerNombre, p.SegundoNombre) LIKE @texto
                                OR CONCAT_WS(' ', p.PrimerApellido, p.SegundoApellido) LIKE @texto
                             )";
                }

                // Aplica filtro de rol si está activo
                if (!string.IsNullOrEmpty(rolFiltro))
                {
                    query += " AND r.Tipo = @rol";
                }

                var cmd = new MySqlCommand(query, conexion.ObtenerConexion());

                if (!string.IsNullOrEmpty(texto))
                    cmd.Parameters.AddWithValue("@texto", $"%{texto}%");

                if (!string.IsNullOrEmpty(rolFiltro))
                    cmd.Parameters.AddWithValue("@rol", rolFiltro);

                // Ejecuta consulta y muestra en grid
                var adapter = new MySqlDataAdapter(cmd);
                var tabla = new DataTable();
                adapter.Fill(tabla);

                dgv.DataSource = tabla;
                dgv.Columns["IdPersonal"].Visible = false; // Oculta la columna ID técnica
            }
            catch (Exception ex)
            {
                // Mensaje en caso de error de carga
                MessageBox.Show("Error al cargar trabajadores: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion(); // Cierra conexión segura
            }
        }
    }
}
