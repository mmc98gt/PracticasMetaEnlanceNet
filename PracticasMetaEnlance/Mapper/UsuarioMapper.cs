using AutoMapper;
using PracticasMetaEnlance.DTOs;
using PracticasMetaEnlance.Entidades;

namespace PracticasMetaEnlance.Mapper
{
    public class UsuarioMapper : Profile
    {
        public UsuarioMapper()
        {
            CreateMap<UsuarioDTO, Usuario>();
            CreateMap<Usuario, UsuarioDTO>();
        }
    }
}
