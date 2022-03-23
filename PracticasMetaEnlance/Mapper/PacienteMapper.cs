using AutoMapper;
using PracticasMetaEnlance.DTOs;
using PracticasMetaEnlance.Entidades;

namespace PracticasMetaEnlance.Mapper
{
    public class PacienteMapper : Profile
    {
        public PacienteMapper()
        {
            CreateMap<PacienteDTO, Paciente>();
            CreateMap<Paciente, PacienteDTO>();
        }
    }
}
