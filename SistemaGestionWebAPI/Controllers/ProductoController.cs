using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionEntities;

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
    }
}
