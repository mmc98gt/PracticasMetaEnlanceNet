using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinica.Services;
using Clinica.DTOs;

namespace Clinica.Controllers
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

        // GET: api/Citas/5
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
        // GET: api/Citas
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

        // Add Cita
        [HttpPost]
        public ActionResult<CitaDTO> AddUsuario(CitaDTO citaDTO)
        {
            return citaService.Put(citaDTO);
        }

        // Remove Cita
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