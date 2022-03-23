using PracticasMetaEnlance.DTOs;

namespace PracticasMetaEnlance.Services
{
    public interface IMedicoService
    {
        public List<MedicoDTO> GetAll();
        public MedicoDTO Get(int id);
        public MedicoDTO Put(MedicoDTO medicoDTO);
        public bool Delete(int id);
    }
}
