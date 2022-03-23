using Microsoft.AspNetCore.Mvc;
using PracticasMetaEnlance.Services;
using PracticasMetaEnlance.DTOs;

namespace PracticasMetaEnlance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiagnosticoController : ControllerBase
    {
        protected IDiagnosticoService diagnosticoService;
        public DiagnosticoController(IDiagnosticoService diagnosticoService)
        {
            this.diagnosticoService = diagnosticoService;
        }

        [HttpGet("{id}")]
        public ActionResult<DiagnosticoDTO> GetDiagnostico(int id)
        {
            var diagnostico = diagnosticoService.Get(id);
            if (diagnostico == null)
            {
                return NotFound();
            }
            return diagnostico;
        }

        [HttpGet()]
        public ActionResult<List<DiagnosticoDTO>> GetDiagnosticos()
        {
            var diagnosticos = diagnosticoService.GetAll();
            if (diagnosticos == null)
            {
                return NotFound();
            }
            return diagnosticos;
        }

        [HttpPost]
        public ActionResult<DiagnosticoDTO> AddUsuario(DiagnosticoDTO diagnosticoDTO)
        {
            return diagnosticoService.Put(diagnosticoDTO);
        }

        [HttpDelete("{id}")]
        public ActionResult RemoveDiagnostico(int id)
        {
            if (diagnosticoService.Delete(id))
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