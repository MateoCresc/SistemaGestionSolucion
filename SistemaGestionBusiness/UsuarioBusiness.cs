using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;
using SistemaGestionData;

namespace SistemaGestionBusiness
{
    public class UsuarioBusiness
    {
        public static List<Usuario> ObtenerUsuario(int IDUsuario)
        {
            return UsuarioData.ObtenerUsuario(IDUsuario);
        }
        public static List<Usuario> ListarUsuario()
        {
            return UsuarioData.ListarUsuario();
        }
        public static void CrearUsuario(Usuario Usuario)
        {
            UsuarioData.CrearUsuario(Usuario);
        }
        public static void ModificarUsuario(Usuario Usuario)
        {
            UsuarioData.ModificarUsuario(Usuario);
        }
        public static void EliminarUsuario(Usuario Usuario)
        {
            UsuarioData.EliminarUsuario(Usuario);
        }

        public static bool Login(string username, string password)
        {
            var usuario = UsuarioData.ObtenerUsuarioPorNombreUsuario(username).FirstOrDefault();
            if (usuario == null)
            {
                return false;
            }
            if (password == usuario.Contraseña)
            {
                return true;
            }
            return false;
        }

    }
}
