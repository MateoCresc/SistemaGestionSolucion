using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;
using SistemaGestionData;

namespace SistemaGestionBusiness
{
    public class VentaBusiness
    {
        public static List<Venta> ObtenerVenta(int IDVenta)
        {
            return VentaData.ObtenerVenta(IDVenta);
        }
        public static List<Venta> ListarVenta()
        {
            return VentaData.ListarVenta();
        }
        public static void CrearVenta(Venta venta)
        {
            Usuario usuario = UsuarioData.ObtenerUsuario(venta.IdUsuario).FirstOrDefault();
            if (usuario == null)
                return;
            VentaData.CrearVenta(venta);
        }
        public static void ModificarVenta(Venta venta)
        {
            VentaData.ModificarVenta(venta);
        }
        public static void EliminarVenta(int idVenta)
        {
            VentaData.EliminarVenta(idVenta);
        }


    }
}