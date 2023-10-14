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
        public static void CrearVenta(Venta Venta)
        {
            VentaData.CrearVenta(Venta);
        }
        public static void ModificarVenta(Venta Venta)
        {
            VentaData.ModificarVenta(Venta);
        }
        public static void EliminarVenta(Venta Venta)
        {
            VentaData.EliminarVenta(Venta);
        }


    }
}