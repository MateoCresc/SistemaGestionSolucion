using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionEntities;
using SistemaGestionWebAPI.Models;

namespace SistemaGestionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet]

        public IEnumerable<Producto> List()
        {
            return ProductoBusiness.ListarProducto().ToArray();
        }

        [HttpGet("{productoID:int}")]

        public IEnumerable<Producto> Get(int productoID)
        {
            return ProductoBusiness.ObtenerProducto(productoID);
        }

        [HttpPost]

        public void Insert ([FromBody] Producto producto)
        {
           ProductoBusiness.CrearProducto(producto);
        }

        [HttpPut]

        public void Update([FromBody] Producto producto)
        {
            ProductoBusiness.ModificarProducto(producto);
        }

        [HttpDelete]

        public void Delete([FromBody] int idProducto)
        {
            ProductoBusiness.EliminarProducto(idProducto);
        }
    }
}
