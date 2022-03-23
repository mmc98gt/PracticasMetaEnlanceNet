using AutoMapper;
using PracticasMetaEnlance.DTOs;
using PracticasMetaEnlance.Entidades;

namespace PracticasMetaEnlance.Mapper
{
    public class DiagnosticoMapper : Profile
    {
        public DiagnosticoMapper()
        {
            CreateMap<Diagnostico, DiagnosticoDTO>();
            CreateMap<DiagnosticoDTO, Diagnostico>();
        }
    }
}
