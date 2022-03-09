using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinica.DTOs;

namespace Clinica.Services
{
    public interface IUsuarioService
    {
        public UsuarioDTO Get(int id);
        public List<UsuarioDTO> GetAll();
        public UsuarioDTO Put(UsuarioDTO usuarioDTO);
        public bool Delete(int usuarioID);
    }
}
