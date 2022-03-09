using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinica.DTOs;
using Clinica.Entities;

namespace Clinica.Services
{
    public interface IMedicoService
    {
        //    Boolean ExaminarPaciente(Cita cita, Paciente paciente);
        //    Diagnostico EmitirDiagnostico(Cita cita, Paciente paciente);
        public List<MedicoDTO> GetAll();
        public MedicoDTO Get(int id);
        public MedicoDTO Put(MedicoDTO medicoDTO);
        public bool Delete(int id);
    }
}
