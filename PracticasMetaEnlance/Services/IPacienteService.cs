using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinica.Entities;
using Clinica.DTOs;

namespace Clinica.Services
{
    public interface IPacienteService
    {
        public List<PacienteDTO> GetAll();
        public PacienteDTO Get(int id);
        public PacienteDTO Put(PacienteDTO pacienteDTO);
        public bool Delete(int id);
    }
}
