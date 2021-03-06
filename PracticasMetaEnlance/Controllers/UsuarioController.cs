using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracticasMetaEnlance.DTOs;
using PracticasMetaEnlance.Services;

namespace PracticasMetaEnlance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        protected IUsuarioService usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }

        [HttpGet]
        public ActionResult<List<UsuarioDTO>> GetUsuarios()
        {
            var usuarios = usuarioService.GetAll();

            if (usuarios is null)
                return NotFound();
            else
                return usuarios;
        }

        [HttpGet("{id}")]
        public ActionResult<UsuarioDTO> GetUsuario(int id)
        {
            var usuario = usuarioService.Get(id);

            if (usuario is null)
                return NotFound();
            else
                return usuario;
        }

        [HttpPost]
        public ActionResult<UsuarioDTO> AddUsuario(UsuarioDTO usuarioDTO)
        {
            return usuarioService.Put(usuarioDTO);
        }

        [HttpDelete("{id}")]
        public ActionResult RemoveUser(int id)
        {
            if (usuarioService.Delete(id))
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
