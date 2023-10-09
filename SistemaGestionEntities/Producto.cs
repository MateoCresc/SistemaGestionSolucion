using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class Producto
    {
        public int Id;
        public string Descripcion;
        public decimal Costo;
        public decimal PrecioVenta;
        public int Stock;
        public int IdUsuario;
    }
}
