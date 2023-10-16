using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionEntities;

namespace SistemaGestionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaContoller : ControllerBase
    {
        [HttpGet]

        public IEnumerable<Venta> List()
        {
            return VentaBusiness.ListarVenta().ToArray();
        }

        [HttpGet("{ventaID:int}")]

        public IEnumerable<Venta> Get(int ventaID)
        {
            return VentaBusiness.ObtenerVenta(ventaID);
        }

        [HttpPost]

        public void Insert([FromBody] Venta Venta)
        {
            VentaBusiness.CrearVenta(Venta);
        }
    }
}
