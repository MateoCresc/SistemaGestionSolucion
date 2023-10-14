using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;
using SistemaGestionData;

namespace SistemaGestionBusiness
{
    public class ProductoVendidoBusiness
    {
        public static List<ProductoVendido> ObtenerProductoVendido(int IDProductoVendido)
        {
            return ProductoVendidoData.ObtenerProductoVendido(IDProductoVendido);
        }
        public static List<ProductoVendido> ListarProductoVendido()
        {
            return ProductoVendidoData.ListarProductoVendido();
        }
        public static void CrearProductoVendido(ProductoVendido ProductoVendido)
        {
            ProductoVendidoData.CrearProductoVendido(ProductoVendido);
        }
        public static void ModificarProductoVendido(ProductoVendido ProductoVendido)
        {
            ProductoVendidoData.ModificarProductoVendido(ProductoVendido);
        }
        public static void EliminarProductoVendido(ProductoVendido ProductoVendido)
        {
            ProductoVendidoData.EliminarProductoVendido(ProductoVendido);
        }


    }
}
