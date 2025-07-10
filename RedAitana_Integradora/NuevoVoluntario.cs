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
using RedAitana_Integradora.BSD; // Asegúrate de tener la referencia nugget a MySql.Data

namespace RedAitana_Integradora
{
    public partial class NuevoVoluntario : Form
    {
        public NuevoVoluntario()
        {
            InitializeComponent();
        }

        private void NuevoVoluntario_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (ConexionMySQL conexion = new ConexionMySQL())
            {
                try
                {
                    conexion.AbrirConexion();
                    string query = "INSERT INTO personal (IdRol, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, correo, telefono) " +
                        "VALUES (@IdRol, @PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, @correo, @telefono)";
                    MySqlCommand comando = new MySqlCommand(query, conexion.ObtenerConexion()); // Obtener la conexión desde la clase ConexionMySQL
                    comando.Parameters.AddWithValue("@IdRol", "1"); // Asignar el ID del rol de voluntario en este caso 1
                    //cambiar el rol por una selección de rol en el futuro


                    string nombreCompleto = txtNombre.Text.Trim();
                    string[] partes = nombreCompleto.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    string primerNombre = partes.Length > 0 ? partes[0] : "";
                    string segundoNombre = partes.Length > 1 ? string.Join(" ", partes.Skip(1)) : "";

                    comando.Parameters.AddWithValue("@PrimerNombre", primerNombre);
                    comando.Parameters.AddWithValue("@SegundoNombre", segundoNombre);

                    string apellidos = txtApellidos.Text.Trim();
                    string[] partesApellidos = apellidos.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    string primerApellido = partesApellidos.Length > 0 ? partesApellidos[0] : "";
                    string segundoApellido = partesApellidos.Length > 1 ? string.Join(" ", partesApellidos.Skip(1)) : "";

                    comando.Parameters.AddWithValue("@PrimerApellido", primerApellido);
                    comando.Parameters.AddWithValue("@SegundoApellido", segundoApellido);


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

        private void txtPrimerApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //ComnoboBox para seleccionar el rol entre empleado y voluntario
        {
            using (ConexionMySQL conexion = new ConexionMySQL())
            {
                conexion.AbrirConexion();

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Limpiar los controles del formulario 
            txtNombre.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            comboBox1.SelectedIndex = -1; 
        }

        
    }
}
