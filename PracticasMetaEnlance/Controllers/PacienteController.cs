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
    public class PacienteController : ControllerBase
    {
        protected IPacienteService pacienteService;
        public PacienteController(IPacienteService pacienteService)
        {
            this.pacienteService = pacienteService;
        }

        // GET: api/Pacientes/5
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
        // GET: api/Pacientes
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

        // Add Paciente
        [HttpPost]
        public ActionResult<PacienteDTO> AddUsuario(PacienteDTO pacienteDTO)
        {
            return pacienteService.Put(pacienteDTO);
        }

        // Remove Paciente
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