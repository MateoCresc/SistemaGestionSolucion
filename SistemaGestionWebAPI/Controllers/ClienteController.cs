using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionEntities;

namespace SistemaGestionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpGet]

        public IEnumerable<Cliente> List()
        {
            return ClienteBusiness.GetClientes().ToArray();
        }

        [HttpGet("{clienteID:int}")]

        public IEnumerable<Cliente> Get(int clienteID)
        {
            return ClienteBusiness.ObtenerCliente(clienteID);
        }
    }
}
