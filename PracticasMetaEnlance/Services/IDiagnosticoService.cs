using PracticasMetaEnlance.DTOs;

namespace PracticasMetaEnlance.Services
{
    public interface IDiagnosticoService
    {
        public List<DiagnosticoDTO> GetAll();
        public DiagnosticoDTO Get(int id);
        public DiagnosticoDTO Put(DiagnosticoDTO diagnosticoDTO);
        public bool Delete(int id);
    }
}
