using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RedAitana_Integradora.BSD;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace RedAitana_Integradora
{
    // Formulario parcial que representa la interfaz de edición general de personal y personal extra
    public partial class EditarGeneral : Form
    {
        // Vista filtrada que servirá como origen de datos para el DataGridView
        private DataView vistaFiltrada;

        // Constructor del formulario
        public EditarGeneral()
        {
            InitializeComponent(); // Inicializa los componentes del formulario (interfaz gráfica)
        }

        // =====================
        // EVENTOS DE TEXTBOX (actualmente vacíos pero necesarios para futuras validaciones o lógica)
        // =====================

        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void PicFoto_Click(object sender, EventArgs e) { }
        private void Id_TextChanged(object sender, EventArgs e) { }
        private void Rol_TextChanged(object sender, EventArgs e) { }
        private void Nombre_TextChanged(object sender, EventArgs e) { }
        private void Correo_TextChanged(object sender, EventArgs e) { }
        private void Telefono_TextChanged(object sender, EventArgs e) { }

        // =====================
        // BOTÓN: Examinar imagen para cargar en PictureBox
        // =====================

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

        // =====================
        // BOTÓN: Guardar cambios
        // =====================

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un registro primero.");
                return;
            }

            string tipoOrigen = dataGridView1.CurrentRow.Cells["TipoOrigen"].Value.ToString();

            // Validación específica para registros de tipo PersonalExtra
            if (tipoOrigen == "PersonalExtra" &&
                (!string.IsNullOrWhiteSpace(Correo.Text) || !string.IsNullOrWhiteSpace(Telefono.Text)))
            {
                MessageBox.Show("No se puede modificar correo o teléfono para visitantes o beneficiarios.");
                return;
            }

            using (ConexionMySQL conexion = new ConexionMySQL())
            {
                conexion.AbrirConexion();

                // Selección dinámica del query según tipoOrigen
                string query = tipoOrigen == "Personal"
                    ? @"UPDATE personal SET 
                IdRol = (SELECT Id FROM rol WHERE Tipo = @Rol),
                PrimerNombre = @PrimerNombre,
                SegundoNombre = @SegundoNombre,
                PrimerApellido = @PrimerApellido,
                SegundoApellido = @SegundoApellido,
                Correo = @Correo,
                Telefono = @Telefono,
                Imagen = @Imagen
                WHERE IdPersonal = @id"
                    : @"UPDATE personalextra SET 
                IdRol = (SELECT Id FROM rol WHERE Tipo = @Rol),
                PrimerNombre = @PrimerNombre,
                SegundoNombre = @SegundoNombre,
                PrimerApellido = @PrimerApellido,
                SegundoApellido = @SegundoApellido,
                Imagen = @Imagen
                WHERE IdPersonalExtra = @id";

                MySqlCommand cmd = new MySqlCommand(query, conexion.conexion);
                cmd.Parameters.AddWithValue("@id", Id.Text.Trim());

                // Limpieza y normalización de campos
                string nombreLimpio = Regex.Replace(Nombre.Text.Trim(), @"\s+", " ");
                string apellidosLimpio = Regex.Replace(Apellidos.Text.Trim(), @"\s+", " ");
                string rolLimpio = Regex.Replace(Rol.Text.Trim(), @"\s+", " ");
                string correoLimpio = Regex.Replace(Correo.Text.Trim(), @"\s+", " ");
                string telefonoLimpio = Regex.Replace(Telefono.Text.Trim(), @"\s+", " ");

                // Separación de nombres
                string[] nombres = nombreLimpio.Split(' ');
                string primerNombre = nombres.Length > 0 ? nombres[0] : "";
                string segundoNombre = nombres.Length > 1 ? nombres[1] : "";

                // Separación de apellidos
                string[] apellidos = apellidosLimpio.Split(' ');
                string primerApellido = apellidos.Length > 0 ? apellidos[0] : "";
                string segundoApellido = apellidos.Length > 1 ? apellidos[1] : "";

                // Asignación de parámetros comunes
                cmd.Parameters.AddWithValue("@PrimerNombre", primerNombre);
                cmd.Parameters.AddWithValue("@SegundoNombre", segundoNombre);
                cmd.Parameters.AddWithValue("@PrimerApellido", primerApellido);
                cmd.Parameters.AddWithValue("@SegundoApellido", segundoApellido);
                cmd.Parameters.AddWithValue("@Rol", rolLimpio);

                // Solo si es personal se actualizan correo y teléfono
                if (tipoOrigen == "Personal")
                {
                    cmd.Parameters.AddWithValue("@Correo", correoLimpio);
                    cmd.Parameters.AddWithValue("@Telefono", telefonoLimpio);
                }

                // Procesamiento de la imagen si existe
                if (PicFoto.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        PicFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        cmd.Parameters.AddWithValue("@Imagen", ms.ToArray());
                    }
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Imagen", DBNull.Value);
                }

                // Ejecuta la actualización
                cmd.ExecuteNonQuery();
                conexion.CerrarConexion();
            }

            MessageBox.Show("Datos actualizados correctamente.");
        }

        // =====================
        // BOTÓN: Modificar (vacío por ahora)
        // =====================

        private void btnModificar_Click(object sender, EventArgs e) { }

        // =====================
        // BOTÓN: Eliminar registro y relaciones asociadas
        // =====================

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de eliminar completamente este registro? Esto también eliminará sus registros relacionados.",
            "Confirmar eliminación total", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (ConexionMySQL conexion = new ConexionMySQL())
                {
                    conexion.AbrirConexion();

                    string tipoOrigen = "";
                    if (dataGridView1.CurrentRow != null)
                    {
                        tipoOrigen = dataGridView1.CurrentRow.Cells["TipoOrigen"].Value.ToString();
                    }

                    string id = Id.Text;

                    if (tipoOrigen == "Personal")
                    {
                        // Borra registros relacionados y principal
                        string borrarRelacion = "DELETE FROM registroentradasalida WHERE id_personal = @id";
                        MySqlCommand cmd1 = new MySqlCommand(borrarRelacion, conexion.conexion);
                        cmd1.Parameters.AddWithValue("@id", id);
                        cmd1.ExecuteNonQuery();

                        string borrarPrincipal = "DELETE FROM personal WHERE IdPersonal = @id";
                        MySqlCommand cmd2 = new MySqlCommand(borrarPrincipal, conexion.conexion);
                        cmd2.Parameters.AddWithValue("@id", id);
                        cmd2.ExecuteNonQuery();
                    }
                    else if (tipoOrigen == "PersonalExtra")
                    {
                        string borrar = "DELETE FROM personalextra WHERE IdPersonalExtra = @id";
                        MySqlCommand cmd = new MySqlCommand(borrar, conexion.conexion);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }

                    conexion.CerrarConexion();
                }

                // Elimina la fila seleccionada del grid
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    if (fila.Cells["id"].Value.ToString() == Id.Text)
                    {
                        dataGridView1.Rows.Remove(fila);
                        break;
                    }
                }

                MessageBox.Show("Registro y datos relacionados eliminados correctamente.");
            }
        }

        // =====================
        // BOTÓN: Cancelar cambios y limpiar campos
        // =====================

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Id.Clear();
            Rol.Clear();
            Nombre.Clear();
            Apellidos.Clear();
            Correo.Clear();
            Telefono.Clear();
            PicFoto.Image = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        // =====================
        // EVENTO: Carga inicial del formulario y llenado del DataGridView
        // =====================

        private void EditarGeneral_Load(object sender, EventArgs e)
        {
            using (ConexionMySQL conexion = new ConexionMySQL())
            {
                conexion.AbrirConexion();

                string query = @"
                SELECT IdPersonal AS id, Tipo AS Rol, 
                CONCAT(PrimerNombre, ' ', SegundoNombre) AS Nombres, 
                CONCAT(PrimerApellido, ' ', SegundoApellido) AS Apellidos,
                Correo, Telefono,
                'Personal' AS TipoOrigen
                FROM personal 
                INNER JOIN rol ON personal.IdRol = rol.Id 

                UNION 

                SELECT IdPersonalExtra AS id, Tipo AS Rol, 
                   CONCAT(PrimerNombre, ' ', SegundoNombre) AS Nombres, 
                   CONCAT(PrimerApellido, ' ', SegundoApellido) AS Apellidos,
                   '' AS Correo, '' AS Telefono,
                   'PersonalExtra' AS TipoOrigen
                FROM personalextra 
                INNER JOIN rol ON personalextra.IdRol = rol.Id;";

                MySqlCommand Puente = new MySqlCommand(query, conexion.conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(Puente);

                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                vistaFiltrada = new DataView(tabla);
                dataGridView1.DataSource = vistaFiltrada;
                dataGridView1.Columns["TipoOrigen"].Visible = false;

                foreach (DataGridViewColumn columna in dataGridView1.Columns)
                {
                    columna.ReadOnly = true; // Solo lectura
                }

                conexion.CerrarConexion();
            }
        }

        // =====================
        // EVENTO: Al cambiar selección en el DataGridView, llenar los campos del formulario
        // =====================

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            DataGridViewRow fila = dataGridView1.CurrentRow;
            Id.Text = fila.Cells["id"].Value.ToString();
            Rol.Text = fila.Cells["Rol"].Value.ToString();
            Nombre.Text = fila.Cells["Nombres"].Value.ToString();
            Apellidos.Text = fila.Cells["Apellidos"].Value?.ToString().Trim();
            Correo.Text = fila.Cells["Correo"]?.Value?.ToString();
            Telefono.Text = fila.Cells["Telefono"]?.Value?.ToString();

            string tipoOrigen = fila.Cells["TipoOrigen"].Value.ToString();

            using (ConexionMySQL conexion = new ConexionMySQL())
            {
                conexion.AbrirConexion();

                string query = tipoOrigen == "Personal"
                    ? "SELECT Imagen FROM personal WHERE IdPersonal = @id"
                    : "SELECT Imagen FROM personalextra WHERE IdPersonalExtra = @id";

                MySqlCommand cmd = new MySqlCommand(query, conexion.conexion);
                cmd.Parameters.AddWithValue("@id", Id.Text);
                object resultado = cmd.ExecuteScalar();

                if (resultado != null && resultado != DBNull.Value)
                {
                    byte[] imagenBytes = (byte[])resultado;
                    using (MemoryStream ms = new MemoryStream(imagenBytes))
                    {
                        PicFoto.Image = Image.FromStream(ms); // Muestra imagen
                    }
                }
                else
                {
                    PicFoto.Image = null;
                }

                conexion.CerrarConexion();
            }
        }
    }
}
