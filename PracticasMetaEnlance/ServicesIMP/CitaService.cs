using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Clinica.Entities;
using Clinica.DTOs;
using Clinica.Repositories;

namespace Clinica.Services
{
    public class CitaService : ICitaService
    {
        private ClinicaDbContext clinicaDbContext;
        protected IMapper autoMapper;
        public CitaService(ClinicaDbContext dbContext, IMapper autoMapper)
        {
            this.clinicaDbContext = dbContext;
            this.autoMapper = autoMapper;
        }

        public CitaDTO Get(int id)
        {
            var cita = autoMapper.Map<CitaDTO>(clinicaDbContext.Citas.Find(id));

            if (cita is null)
            {
                return null;
            }
            else
            {
                return cita;
            }
        }

        public List<CitaDTO> GetAll()
        {
            return autoMapper.Map<List<CitaDTO>>(clinicaDbContext.Citas);
        }

        public bool Delete(int id)
        {
            Cita cita = clinicaDbContext.Citas.Find(id);
            if (cita == null)
            {
                return false;
            }
            else
            {
                clinicaDbContext.Remove(cita);
                clinicaDbContext.SaveChanges();

                return true;
            }
        }

        public CitaDTO Put(CitaDTO citaDTO)
        {
            Medico medico = clinicaDbContext.Medicos.Find(citaDTO.MedicoID);
            Paciente paciente = clinicaDbContext.Pacientes.Find(citaDTO.PacienteID);

            Cita cita = new()
            {
                CitaID = citaDTO.CitaID,
                FechaHora = citaDTO.FechaHora,
                MotivoCita = citaDTO.MotivoCita,
                Medico = medico,
                MedicoID = citaDTO.MedicoID,
                Paciente = paciente,
                PacienteID = citaDTO.PacienteID
            };

            clinicaDbContext.Citas.Add(cita);
            clinicaDbContext.SaveChanges();
            return citaDTO;
        }
    }
}
