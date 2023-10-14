using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionEntities;

namespace SistemaGestionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet]

        public IEnumerable<ProductoVendido> List()
        {
            return ProductoVendidoBusiness.ListarProductoVendido().ToArray();
        }

        [HttpGet("{productoVendidoID:int}")]

        public IEnumerable<ProductoVendido> Get(int productoVendidoID)
        {
            return ProductoVendidoBusiness.ObtenerProductoVendido(productoVendidoID);
        }
    }
}
