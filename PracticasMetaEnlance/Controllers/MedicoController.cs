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
    public class MedicoController : ControllerBase
    {
        protected IMedicoService medicoService;
        public MedicoController(IMedicoService medicoService)
        {
            this.medicoService = medicoService;
        }

        // GET: api/Medicos/5
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
        // GET: api/Medicos
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

        // Add Paciente
        [HttpPost]
        public ActionResult<MedicoDTO> AddUsuario(MedicoDTO medicoDTO)
        {
            return medicoService.Put(medicoDTO);
        }

        // Remove User
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
