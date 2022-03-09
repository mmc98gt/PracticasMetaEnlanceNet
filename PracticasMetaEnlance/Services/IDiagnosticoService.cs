using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinica.Entities;
using Clinica.DTOs;

namespace Clinica.Services
{
    public interface IDiagnosticoService
    {
        public List<DiagnosticoDTO> GetAll();
        public DiagnosticoDTO Get(int id);
        public DiagnosticoDTO Put(DiagnosticoDTO diagnosticoDTO);
        public bool Delete(int id);
    }
}
