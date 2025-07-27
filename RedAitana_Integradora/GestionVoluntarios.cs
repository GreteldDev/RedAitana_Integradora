using System;
using System.Data;
using System.Drawing;
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
            this.Load += GestionVoluntarios_Load;
        }

        private void GestionVoluntarios_Load(object sender, EventArgs e)
        {
            CargarDatosPersonalExtra();
        }

        public void CargarDatosPersonalExtra()
        {
            using (ConexionMySQL conexion = new ConexionMySQL())
            {
                try
                {
                    conexion.AbrirConexion();
                    string query = @"SELECT IdPersonalExtra AS id, Tipo AS Rol, 
                                   PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido
                                   FROM personalextra INNER JOIN rol ON personalextra.IdRol = rol.Id";

                    MySqlCommand comando = new MySqlCommand(query, conexion.ObtenerConexion());
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dgvVisitantes.DataSource = tabla;

                    // Configuración opcional del DataGridView
                    dgvVisitantes.Columns["id"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            }
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verificar permisos de administrador
            if (ValidarCredencial.PuedeEditar())
            {
                var editor = new EditarGeneral(3); // 2 para tipo Visitante/Beneficiario
                editor.FormClosed += (s, args) => CargarDatosPersonalExtra();
                editor.ShowDialog();
                return;
            }

            // Si es usuario normal, solicitar validación
            if (ValidarCredencial.TipoUsuario == "Usuario")
            {
                bool autorizado = ValidarCredencial.SolicitarValidacionAdministrador();

                if (autorizado)
                {
                    var editor = new EditarGeneral(2);
                    editor.FormClosed += (s, args) => CargarDatosPersonalExtra();
                    editor.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No tienes permisos para editar.");
                }
            }
        }

        private void BuscarDatos(string texto)
        {
            string query = @"SELECT IdPersonalExtra AS id, Tipo AS Rol, PrimerNombre, SegundoNombre, 
                          PrimerApellido, SegundoApellido 
                          FROM personalextra 
                          INNER JOIN rol ON personalextra.IdRol = rol.Id
                          WHERE CONCAT(PrimerNombre, ' ', SegundoNombre, ' ', 
                          PrimerApellido, ' ', SegundoApellido) LIKE @texto";

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

                    dgvVisitantes.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar: " + ex.Message);
                }
            }
        }



        // Métodos no utilizados (puedes eliminar)
        private void panel2_Paint(object sender, PaintEventArgs e) { }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var nuevoVoluntario = new NuevoVoluntario(this);    
            nuevoVoluntario.ShowDialog();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            BuscarDatos(txtBusqueda.Text.Trim());
        }
    }
}