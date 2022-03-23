using Microsoft.AspNetCore.Mvc;
using PracticasMetaEnlance.Services;
using PracticasMetaEnlance.DTOs;

namespace PracticasMetaEnlance.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CitaController : ControllerBase
    {
        protected ICitaService citaService;
        public CitaController(ICitaService citaService)
        {
            this.citaService = citaService;
        }

        [HttpGet("{id}")]
        public ActionResult<CitaDTO> GetCita(int id)
        {
            var cita = citaService.Get(id);
            if (cita == null)
            {
                return NotFound();
            }
            return cita;
        }

        [HttpGet()]
        public ActionResult<List<CitaDTO>> GetCitas()
        {
            var citas = citaService.GetAll();
            if (citas == null)
            {
                return NotFound();
            }
            return citas;
        }

        [HttpPost]
        public ActionResult<CitaDTO> AddUsuario(CitaDTO citaDTO)
        {
            return citaService.Put(citaDTO);
        }

        [HttpDelete("{id}")]
        public ActionResult RemoveCita(int id)
        {
            if (citaService.Delete(id))
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