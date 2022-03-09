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
    public class DiagnosticoController : ControllerBase
    {
        protected IDiagnosticoService diagnosticoService;
        public DiagnosticoController(IDiagnosticoService diagnosticoService)
        {
            this.diagnosticoService = diagnosticoService;
        }

        // GET: api/Diagnosticos/5
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
        // GET: api/Diagnosticos
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

        // Add Diagnostico
        [HttpPost]
        public ActionResult<DiagnosticoDTO> AddUsuario(DiagnosticoDTO diagnosticoDTO)
        {
            return diagnosticoService.Put(diagnosticoDTO);
        }

        // Remove Diagnostico
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