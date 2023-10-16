using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionEntities;
using SistemaGestionWebAPI.Models;

namespace SistemaGestionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        [HttpGet]

        public IEnumerable<Usuario> List()
        {            
            return UsuarioBusiness.ListarUsuario().ToArray();
        }

        [HttpGet("{usuarioID:int}")]

        public IEnumerable<Usuario> Get(int usuarioID)
        {
            return UsuarioBusiness.ObtenerUsuario(usuarioID);
        }

        [HttpPost]

        public Usuario Login([FromBody] UsuarioLoginDTO usuarioLogin)
        {
            return UsuarioBusiness.Login(usuarioLogin.Username, usuarioLogin.Password);
        }

        [HttpPut]

        public void Update([FromBody] Usuario usuario)
        {
            UsuarioBusiness.ModificarUsuario(usuario);
        }
    }
}
