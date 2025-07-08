using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RedAitana_Integradora.BSD
{
    internal class ConexionMySQL : Form
    {
        public MySqlConnection conexion;

        private string server = "localhost";
        private string user= "root";
        private string password = "root";
        private string bd = "aitanabsd";

        private string cadenaConexion;
        public ConexionMySQL()
        {
            cadenaConexion = $"server={server}; database={bd}; user id={user}; password={password};";
            conexion = new MySqlConnection(cadenaConexion);
        }
        public void AbrirConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Closed) { conexion.Open(); };
            }
            catch(Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
        public void CerrarConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Open) { conexion.Close(); };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
}
