using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Clinica.Entities;
using Clinica.DTOs;
using Clinica.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Clinica.Services
{
    public class DiagnosticoService : IDiagnosticoService
    {
        private ClinicaDbContext clinicaDbContext;
        protected IMapper autoMapper;
        public DiagnosticoService(ClinicaDbContext dbContext, IMapper autoMapper)
        {
            this.clinicaDbContext = dbContext;
            this.autoMapper = autoMapper;
        }

        public DiagnosticoDTO Get(int id)
        {
            var diagnostico = autoMapper.Map<DiagnosticoDTO>(clinicaDbContext.Diagnosticos.Find(id));

            if (diagnostico is null)
            {
                return null;
            }
            else
            {
                return diagnostico;
            }
        }

        public List<DiagnosticoDTO> GetAll()
        {
            return autoMapper.Map<List<DiagnosticoDTO>>(clinicaDbContext.Diagnosticos);
        }

        public bool Delete(int id)
        {
            Diagnostico diagnostico = clinicaDbContext.Diagnosticos.Find(id);
            if (diagnostico == null)
            {
                return false;
            }
            else
            {
                clinicaDbContext.Remove(diagnostico);
                clinicaDbContext.SaveChanges();

                return true;
            }
        }

        public DiagnosticoDTO Put(DiagnosticoDTO diagnosticoDTO)
        {
            Diagnostico diagnostico = new()
            {
                DiagnosticoID = diagnosticoDTO.DiagnosticoID,
                ValoracionEspecialista = diagnosticoDTO.ValoracionEspecialista,
                Enfermedad = diagnosticoDTO.Enfermedad,
                CitaID = diagnosticoDTO.CitaID
            };
            Cita cita = clinicaDbContext.Citas.Find(diagnosticoDTO.CitaID);
            cita.Diagnostico = diagnostico;
            clinicaDbContext.Diagnosticos.Add(diagnostico);
            clinicaDbContext.Entry(cita).State = EntityState.Modified;
            clinicaDbContext.SaveChanges();
            return diagnosticoDTO;
        }
    }
}
