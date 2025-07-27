using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RedAitana_Integradora.BSD;

namespace RedAitana_Integradora
{
    public partial class NuevoTrabajador : Form
    {
        private GestionTrabajadores gestionTrabajadores;

        public NuevoTrabajador(GestionTrabajadores gestionTrabajadores)
        {
            InitializeComponent();
            this.gestionTrabajadores = gestionTrabajadores;
            this.Load += NuevoTrabajador_Load; // Vinculamos el evento Load correctamente
        }

        private void NuevoTrabajador_Load(object sender, EventArgs e)
        {
            var rolesPermitidos = new Dictionary<int, string>();

            using (var conexion = new ConexionMySQL())
            {
                try
                {
                    conexion.AbrirConexion();
                    var cmd = new MySqlCommand("SELECT Id, Tipo FROM rol WHERE Id IN (2, 3)", conexion.ObtenerConexion());
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("Id");
                            string tipo = reader.GetString("Tipo");
                            rolesPermitidos[id] = tipo;
                        }
                    }

                    cbxRol.DisplayMember = "Value";
                    cbxRol.ValueMember = "Key";
                    cbxRol.DataSource = new BindingSource(rolesPermitidos, null);
                    cbxRol.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar roles: " + ex.Message);
                }
                finally
                {
                    conexion.CerrarConexion();
                }
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";

            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                pcbFoto.Image = Image.FromFile(dialogo.FileName);
                pcbFoto.SizeMode = PictureBoxSizeMode.Zoom;
                pcbFoto.Tag = dialogo.FileName;
            }
        }

        private byte[] ObtenerBytesImagen()
        {
            if (pcbFoto.Image == null) return null;

            using (MemoryStream ms = new MemoryStream())
            {
                pcbFoto.Image.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbxRol.SelectedValue is not int idRol)
            {
                MessageBox.Show("Selecciona un rol válido.");
                return;
            }

            // Validación adicional para blindar rol
            if (idRol != 2 && idRol != 3)
            {
                MessageBox.Show("Este rol no está habilitado en esta sección.");
                return;
            }

            string[] nombres = txtNombre.Text.Trim().Split(new[] { ' ' }, 2);
            string primerNombre = nombres.ElementAtOrDefault(0) ?? "";
            string segundoNombre = nombres.ElementAtOrDefault(1) ?? "";

            string[] apellidos = txtApellidos.Text.Trim().Split(new[] { ' ' }, 2);
            string primerApellido = apellidos.ElementAtOrDefault(0) ?? "";
            string segundoApellido = apellidos.ElementAtOrDefault(1) ?? "";

            byte[] imagenBytes = ObtenerBytesImagen();

            using (var conexion = new ConexionMySQL())
            {
                try
                {
                    conexion.AbrirConexion();

                    string query = @"INSERT INTO personal
                                     (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido,
                                      Correo, Telefono, IdRol, Imagen)
                                     VALUES
                                     (@PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido,
                                      @Correo, @Telefono, @IdRol, @Imagen);";

                    var cmd = new MySqlCommand(query, conexion.ObtenerConexion());
                    cmd.Parameters.AddWithValue("@PrimerNombre", primerNombre);
                    cmd.Parameters.AddWithValue("@SegundoNombre", segundoNombre);
                    cmd.Parameters.AddWithValue("@PrimerApellido", primerApellido);
                    cmd.Parameters.AddWithValue("@SegundoApellido", segundoApellido);
                    cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text.Trim());
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim());
                    cmd.Parameters.AddWithValue("@IdRol", idRol);
                    cmd.Parameters.AddWithValue("@Imagen", imagenBytes ?? (object)DBNull.Value);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Registro Exitoso");
                        gestionTrabajadores?.RecargarTrabajadores();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar trabajador.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conexion.CerrarConexion();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}