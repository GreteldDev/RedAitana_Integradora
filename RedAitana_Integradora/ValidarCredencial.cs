using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedAitana_Integradora
{
    public static class ValidarCredencial
    {
        public static string TipoUsuario { get; private set; } = "";

        /// <summary>
        /// Valida una contraseña y asigna tipo de usuario según valor exacto.
        /// </summary>
        public static bool IniciarSesion(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                TipoUsuario = "";
                return false;
            }

            switch (password.Trim())
            {
                case "admin":
                    TipoUsuario = "Administrador";
                    return true;

                case "user":
                    TipoUsuario = "Usuario";
                    return true;

                default:
                    TipoUsuario = "";
                    return false;
            }
        }

        /// <summary>
        /// Retorna true si tiene permiso de edición.
        /// </summary>
        public static bool PuedeEditar()
        {
            return TipoUsuario == "Administrador";
        }

        /// <summary>
        /// Solicita validación adicional si el usuario actual no es administrador.
        /// </summary>
        public static bool SolicitarValidacionAdministrador()
        {
            using (var ventana = new VentanaConfirmacion())
            {
                return ventana.ShowDialog() == DialogResult.OK;
            }
        }

    }
}
