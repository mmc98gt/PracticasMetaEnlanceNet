using AutoMapper;
using PracticasMetaEnlance.DTOs;
using PracticasMetaEnlance.Entidades;

namespace PracticasMetaEnlance.Mapper
{
    public class CitaMapper : Profile
    {
        public CitaMapper()
        {
            CreateMap<CitaDTO, Cita>();
            CreateMap<Cita, CitaDTO>();
        }
    }
}
