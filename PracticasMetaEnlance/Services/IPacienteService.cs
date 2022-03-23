using PracticasMetaEnlance.DTOs;

namespace PracticasMetaEnlance.Services
{
    public interface IPacienteService
    {
        public List<PacienteDTO> GetAll();
        public PacienteDTO Get(int id);
        public PacienteDTO Put(PacienteDTO pacienteDTO);
        public bool Delete(int id);
    }
}
