using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;
using SistemaGestionData;    

namespace SistemaGestionBusiness
{
    public class ClienteBusiness
    {
        public static List<Cliente> ObtenerCliente(int IDCliente)
        {
            return ClienteData.ObtenerCliente(IDCliente);
        }
        public static List<Cliente> GetClientes()
        {
            return ClienteData.GetClientes();
        }
        public static void CrearCliente(Cliente Cliente)
        {
            ClienteData.CrearCliente(Cliente);
        }
        public static void ModificarCliente(Cliente Cliente)
        {
            ClienteData.ModificarCliente(Cliente);
        }
        public static void EliminarCliente(Cliente Cliente)
        {
            ClienteData.EliminarCliente(Cliente);
        }


    }
}
