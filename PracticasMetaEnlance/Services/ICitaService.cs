using PracticasMetaEnlance.DTOs;

namespace PracticasMetaEnlance.Services
{
    public interface ICitaService
    {
        public List<CitaDTO> GetAll();
        public CitaDTO Get(int id);
        public CitaDTO Put(CitaDTO citaDTO);
        public bool Delete(int id);
    }
}
