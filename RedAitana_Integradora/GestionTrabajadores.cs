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
    public partial class GestionTrabajadores : Form
    {
        private ListaTrabajadores ListaTrabajadores;       // Manejador de lógica de listado y filtrado

        public GestionTrabajadores()
        {
            InitializeComponent();                         // Inicializa controles visuales
            this.Load += GestionTrabajadores_Load;         // Carga la lista
        }

        // Evento: Al cargar el formulario
        private void GestionTrabajadores_Load(object sender, EventArgs e)
        {
            // Inicializa clase que gestiona el listado de trabajadores
            ListaTrabajadores = new ListaTrabajadores(dgvTrabajadores, txtBusqueda);
            ListaTrabajadores.CargarDatos();               // Carga inicial sin filtros
        }

        // BOTÓN: Registrar nuevo trabajador
        private void btnNuevoTrabajador_Click(object sender, EventArgs e)
        {
            var nuevoTrabajador = new NuevoTrabajador(this);  // Abre ventana para registrar
            nuevoTrabajador.ShowDialog();                     // Muestra ventana como diálogo modal
        }

        // BOTÓN: Filtrar por "Trabajador"
        private void btnTrabajadores_Click(object sender, EventArgs e)
        {
            // Si ya está activo, se desactiva
            if (ListaTrabajadores == null) return;

            if (btnTrabajadores.BackColor == Color.FromArgb(223, 128, 108))
            {
                btnTrabajadores.BackColor = Color.MediumPurple;
                ListaTrabajadores.LimpiarFiltroRol();
            }
            else
            {
                btnTrabajadores.BackColor = Color.FromArgb(223, 128, 108);
                btnColaboradores.BackColor = Color.MediumPurple;
                ListaTrabajadores.AplicarFiltroPorRol("Trabajador");
            }
        }

        // BOTÓN: Filtrar por "Colaborador"
        private void btnColaboradores_Click(object sender, EventArgs e)
        {
            if (ListaTrabajadores == null) return;

            if (btnColaboradores.BackColor == Color.FromArgb(223, 128, 108))
            {
                btnColaboradores.BackColor = Color.MediumPurple;
                ListaTrabajadores.LimpiarFiltroRol();
            }
            else
            {
                btnColaboradores.BackColor = Color.FromArgb(223, 128, 108);
                btnTrabajadores.BackColor = Color.MediumPurple;
                ListaTrabajadores.AplicarFiltroPorRol("Colaborador");
            }
        }

        // BOTÓN: Editar trabajadores (acceso a ventana general)
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Si ya es administrador, abrir directamente
            if (ValidarCredencial.PuedeEditar())
            {
                var editor = new EditarGeneral(2);
                editor.FormClosed += (s, args) => RecargarTrabajadores();
                editor.ShowDialog();
                return;
            }

            // Si es usuario, solicitar confirmación de contraseña admin
            if (ValidarCredencial.TipoUsuario == "Usuario")
            {
                bool autorizado = ValidarCredencial.SolicitarValidacionAdministrador();

                if (autorizado)
                {
                    var editor = new EditarGeneral(2);
                    editor.FormClosed += (s, args) => RecargarTrabajadores();
                    editor.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No tienes permisos para editar.");
                }
            }
        }

        // Método público para recargar el DataGrid
        public void RecargarTrabajadores()
        {
            ListaTrabajadores?.CargarDatos();                     // Vuelve a cargar listado
        }

        private void dgvTrabajadores_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void BuscarDatos(string texto)
        {
            string query = @"SELECT idpersonal, idrol, primernombre, segundonombre, primerapellido, segundoapellido 
                     FROM personal
                     WHERE CONCAT(primernombre, ' ', segundonombre, ' ', primerapellido, ' ', segundoapellido) LIKE @texto";

            using (ConexionMySQL conexion = new ConexionMySQL())
            {
                try
                {
                    conexion.AbrirConexion();
                    MySqlCommand comando = new MySqlCommand(query, conexion.ObtenerConexion());
                    comando.Parameters.AddWithValue("@texto", "%" + texto + "%");

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    dgvTrabajadores.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar: " + ex.Message);
                }
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            BuscarDatos(txtBusqueda.Text.Trim()); // Llama al método de búsqueda al cambiar el texto
        }
    }
}
