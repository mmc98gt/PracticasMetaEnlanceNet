using Microsoft.AspNetCore.Mvc;
using PracticasMetaEnlance.Services;
using PracticasMetaEnlance.DTOs;

namespace PracticasMetaEnlance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        protected IMedicoService medicoService;
        public MedicoController(IMedicoService medicoService)
        {
            this.medicoService = medicoService;
        }

        [HttpGet("{id}")]
        public ActionResult<MedicoDTO> GetMedico(int id)
        {
            var medico = medicoService.Get(id);
            if (medico == null)
            {
                return NotFound();
            }
            return medico;
        }
        [HttpGet()]
        public ActionResult<List<MedicoDTO>> GetMedicos()
        {
            var medicos = medicoService.GetAll();
            if (medicos == null)
            {
                return NotFound();
            }
            return medicos;
        }

        [HttpPost]
        public ActionResult<MedicoDTO> AddUsuario(MedicoDTO medicoDTO)
        {
            return medicoService.Put(medicoDTO);
        }

        [HttpDelete("{id}")]
        public ActionResult RemoveMedico(int id)
        {
            if (medicoService.Delete(id))
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
