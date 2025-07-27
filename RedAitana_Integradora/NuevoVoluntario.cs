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
        GestionVoluntarios gVoluntarios;

        public NuevoVoluntario(GestionVoluntarios gestionVoluntarios)
        {
            InitializeComponent();
            this.gVoluntarios = gestionVoluntarios;
        }

       
        public void NuevoVoluntario_Load(object sender, EventArgs e)
        {   // Cargar los roles en el ComboBox
            List<OpcionRol> roles = new List<OpcionRol>
{
            new OpcionRol { Id = 4, Nombre = "Visitante" },
            new OpcionRol { Id = 5, Nombre = "Beneficiario" }
};

            cbxRol.DataSource = roles;
            cbxRol.DisplayMember = "Nombre"; // Muestra "Visitante y Beneficiario"
            cbxRol.ValueMember = "Id";       // Internamente guarda el 1 o 2
            cbxRol.SelectedIndex = -1;       // Opcional: que no haya nada seleccionado al inicio


        }
        public class OpcionRol
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            // Limpiar los controles del formulario 
            txtNombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            cbxRol.SelectedIndex = -1;
            pcbFoto.Image = null; // Limpia la imagen del PictureBox

            this.Close(); // Cierra el formulario
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp"; // Filtro para mostrar solo imágenes

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (var tempImage = Image.FromFile(ofd.FileName))
                {
                    pcbFoto.Image = new Bitmap(tempImage); // Asigna la imagen seleccionada al PictureBox
                }
                pcbFoto.Tag = ofd.FileName; // Guarda la ruta del archivo como referencia
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPrimerApellido.Text) || string.IsNullOrWhiteSpace(txtSegundoApellido.Text) ||
                cbxRol.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            using (ConexionMySQL conexion = new ConexionMySQL())
            {
                conexion.AbrirConexion();
                string query = "INSERT INTO personalextra (IdRol, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido) " +
                    "VALUES (@IdRol, @PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido)";
                MySqlCommand comando = new MySqlCommand(query, conexion.ObtenerConexion()); // Obtener la conexión desde la clase ConexionMySQL

                int idRolSeleccionado = ((OpcionRol)cbxRol.SelectedItem).Id;
                comando.Parameters.AddWithValue("@IdRol", idRolSeleccionado); // Asegúrate de que idRolSeleccionado esté definido y tenga el valor correcto
                                                                              // Dividir el nombre completo en primer y segundo nombre


                string nombreCompleto = txtNombre.Text.Trim();
                string[] partes = nombreCompleto.Split(' ', StringSplitOptions.RemoveEmptyEntries); // Divide el nombre completo en partes, eliminando espacios en blanco

                string primerNombre = partes.Length > 0 ? partes[0] : "";
                string segundoNombre = partes.Length > 1 ? string.Join(" ", partes.Skip(1)) : "";

                comando.Parameters.AddWithValue("@PrimerNombre", primerNombre);
                comando.Parameters.AddWithValue("@SegundoNombre", segundoNombre);

                string primerApellido = txtPrimerApellido.Text.Trim();
                string segundoApellido = txtSegundoApellido.Text.Trim();

                comando.Parameters.AddWithValue("@PrimerApellido", primerApellido);
                comando.Parameters.AddWithValue("@SegundoApellido", segundoApellido);
                int filasAfectadas = comando.ExecuteNonQuery(); //
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Registro exitoso.");
                    gVoluntarios.CargarDatosPersonalExtra(); // Llama al método para recargar los datos en el DataGridView
                    this.Close(); // Cierra el formulario después de guardar
                }
                else
                {
                    MessageBox.Show("Error al registrar.");
                }

            }
        }
    }
}
