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
        {   // Cargar los roles en el ComboBox
            List<OpcionRol> roles = new List<OpcionRol>
{
            new OpcionRol { Id = 4, Nombre = "Visitante" },
            new OpcionRol { Id = 5, Nombre = "Beneficiario" }
};

            comboBox1.DataSource = roles;
            comboBox1.DisplayMember = "Nombre"; // Muestra "Visitante y Beneficiario"
            comboBox1.ValueMember = "Id";       // Internamente guarda el 1 o 2
            comboBox1.SelectedIndex = -1;       // Opcional: que no haya nada seleccionado al inicio


        }
        public class OpcionRol
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            using (ConexionMySQL conexion = new ConexionMySQL())
            {
                    conexion.AbrirConexion();
                    string query = "INSERT INTO personalextra (IdRol, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, correo, telefono) " +
                        "VALUES (@IdRol, @PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, @correo, @telefono)";
                    MySqlCommand comando = new MySqlCommand(query, conexion.ObtenerConexion()); // Obtener la conexión desde la clase ConexionMySQL
                
                int idRolSeleccionado = ((OpcionRol)comboBox1.SelectedItem).Id;
                comando.Parameters.AddWithValue("@IdRol", idRolSeleccionado); // Asegúrate de que idRolSeleccionado esté definido y tenga el valor correcto
                                                                              // Dividir el nombre completo en primer y segundo nombre


                    string nombreCompleto = txtNombre.Text.Trim(); 
                    string[] partes = nombreCompleto.Split(' ', StringSplitOptions.RemoveEmptyEntries); // Divide el nombre completo en partes, eliminando espacios en blanco

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
                    int filasAfectadas = comando.ExecuteNonQuery(); //
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Registro exitoso.");
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar.");
                    }
               
            }
        }

        private void txtPrimerApellido_TextChanged(object sender, EventArgs e)
        { }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { }
         

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
