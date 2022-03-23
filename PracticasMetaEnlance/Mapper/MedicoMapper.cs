using AutoMapper;
using PracticasMetaEnlance.DTOs;
using PracticasMetaEnlance.Entidades;

namespace PracticasMetaEnlance.Mapper
{
    public class MedicoMapper : Profile
    {
        public MedicoMapper()
        {
            CreateMap<MedicoDTO, Medico>();
            CreateMap<Medico, MedicoDTO>();
        }
    }
}
