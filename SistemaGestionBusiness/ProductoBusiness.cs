using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;
using SistemaGestionData;

namespace SistemaGestionBusiness
{
    public class ProductoBusiness
    {
        public static List<Producto> ObtenerProducto(int IDProducto)
        {
            return ProductoData.ObtenerProducto(IDProducto);
        }
        public static List<Producto> ListarProducto()
        {
            return ProductoData.ListarProducto();
        }
        public static void CrearProducto(Producto Producto)
        {
            ProductoData.CrearProducto(Producto);
        }
        public static void ModificarProducto(Producto Producto)
        {
            ProductoData.ModificarProducto(Producto);
        }
        public static void EliminarProducto(Producto Producto)
        {
            ProductoData.EliminarProducto(Producto);
        }


    }
}
