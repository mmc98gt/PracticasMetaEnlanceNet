using Microsoft.AspNetCore.Mvc;
using PracticasMetaEnlance.Services;
using PracticasMetaEnlance.DTOs;

namespace PracticasMetaEnlance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        protected IPacienteService pacienteService;
        public PacienteController(IPacienteService pacienteService)
        {
            this.pacienteService = pacienteService;
        }

        [HttpGet("{id}")]
        public ActionResult<PacienteDTO> GetPaciente(int id)
        {
            var paciente = pacienteService.Get(id);
            if (paciente == null)
            {
                return NotFound();
            }
            return paciente;
        }

        [HttpGet()]
        public ActionResult<List<PacienteDTO>> GetPacientes()
        {
            var pacientes = pacienteService.GetAll();
            if (pacientes == null)
            {
                return NotFound();
            }
            return pacientes;
        }

        [HttpPost]
        public ActionResult<PacienteDTO> AddUsuario(PacienteDTO pacienteDTO)
        {
            return pacienteService.Put(pacienteDTO);
        }

        [HttpDelete("{id}")]
        public ActionResult RemovePaciente(int id)
        {
            if (pacienteService.Delete(id))
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