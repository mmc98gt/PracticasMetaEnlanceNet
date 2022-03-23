using PracticasMetaEnlance.DTOs;

namespace PracticasMetaEnlance.Services
{
    public interface IUsuarioService
    {
        public UsuarioDTO Get(int id);
        public List<UsuarioDTO> GetAll();
        public UsuarioDTO Put(UsuarioDTO usuarioDTO);
        public bool Delete(int usuarioID);
    }
}
