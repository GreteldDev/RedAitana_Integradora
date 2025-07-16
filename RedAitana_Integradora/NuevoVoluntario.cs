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
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPrimerApellido.Text) || string.IsNullOrWhiteSpace(txtSegundoApellido.Text) ||
                comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            using (ConexionMySQL conexion = new ConexionMySQL())
            {
                conexion.AbrirConexion();
                string query = "INSERT INTO personalextra (IdRol, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Imagen) " +
                    "VALUES (@IdRol, @PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, @Imagen)";
                MySqlCommand comando = new MySqlCommand(query, conexion.ObtenerConexion()); // Obtener la conexión desde la clase ConexionMySQL

                int idRolSeleccionado = ((OpcionRol)comboBox1.SelectedItem).Id;
                comando.Parameters.AddWithValue("@IdRol", idRolSeleccionado); // Asegúrate de que idRolSeleccionado esté definido y tenga el valor correcto


                string nombreCompleto = txtNombre.Text.Trim();
                string[] partes = nombreCompleto.Split(' ', StringSplitOptions.RemoveEmptyEntries); // Divide el nombre completo en partes, eliminando espacios en blanco

                string primerNombre = partes.Length > 0 ? partes[0] : "";
                string segundoNombre = partes.Length > 1 ? string.Join(" ", partes.Skip(1)) : "";

                comando.Parameters.AddWithValue("@PrimerNombre", primerNombre);
                comando.Parameters.AddWithValue("@SegundoNombre", segundoNombre);

                string apellidos = txtPrimerApellido.Text.Trim();
                string[] partesApellidos = apellidos.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string primerApellido = partesApellidos.Length > 0 ? partesApellidos[0] : "";
                string segundoApellido = partesApellidos.Length > 1 ? string.Join(" ", partesApellidos.Skip(1)) : "";

                comando.Parameters.AddWithValue("@PrimerApellido", primerApellido);
                comando.Parameters.AddWithValue("@SegundoApellido", segundoApellido);

                byte[] imagenBytes = null;

                if (PicFoto.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {

                        PicFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        imagenBytes = ms.ToArray();
                    }
                }
                comando.Parameters.AddWithValue("@Imagen", imagenBytes);


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
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            comboBox1.SelectedIndex = -1;
            PicFoto.Image = null;
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp"; // Filtro para mostrar solo imágenes

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (var tempImage = Image.FromFile(ofd.FileName))
                {
                    PicFoto.Image = new Bitmap(tempImage); // Asigna la imagen seleccionada al PictureBox
                }
                PicFoto.Tag = ofd.FileName; // Guarda la ruta del archivo como referencia
            }
        }

        private void PicFoto_Click_1(object sender, EventArgs e)
        { }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
