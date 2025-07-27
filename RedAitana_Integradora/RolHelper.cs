using MySql.Data.MySqlClient;
using RedAitana_Integradora.BSD;

namespace Helpers
{
    public static class RolHelper
    {
        public static void CargarCombo(ComboBox cbx)
        {
            var roles = new Dictionary<int, string>();

            using (var conexion = new ConexionMySQL())
            {
                try
                {
                    conexion.AbrirConexion();

                    var cmd = new MySqlCommand("SELECT Id, Tipo FROM rol", conexion.ObtenerConexion());
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(reader.GetOrdinal("Id"));
                            string tipo = reader.GetString(reader.GetOrdinal("Tipo"));
                            roles[id] = tipo;
                        }
                    }

                    cbx.DisplayMember = "Value";
                    cbx.ValueMember = "Key";
                    cbx.DataSource = new BindingSource(roles, null);
                    cbx.SelectedIndex = -1;
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
    }
}
