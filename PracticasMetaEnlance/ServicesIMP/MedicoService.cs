using Clinica.Entities;
using Clinica.DTOs;
using Clinica.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Clinica.Services;

namespace Clinica.Services
{
    public class MedicoService : IMedicoService
    {
        private ClinicaDbContext clinicaDbContext;
        protected IMapper autoMapper;
        public MedicoService(ClinicaDbContext dbContext, IMapper autoMapper)
        {
            this.clinicaDbContext = dbContext;
            this.autoMapper = autoMapper;
        }

        public MedicoDTO Get(int id)
        {
            //var medico = MapToDTO(clinicaDbContext.Medicos.Include(m => m.Pacientes).Include(m => m.Citas).Single(m => m.UsuarioID == id));
            var medico = MapToDTO(clinicaDbContext.Medicos.Find(id));

            if (medico is null)
            {
                return null;
            }
            else
            { 
                return medico; 
            }
        }

        public List<MedicoDTO> GetAll()
        {
            List<Medico> medicos = clinicaDbContext.Medicos.ToList();

            return medicos.Select(m => MapToDTO(m)).ToList();
        }

        public bool Delete(int id)
        {
            Medico medico = clinicaDbContext.Medicos.Find(id);
            if (medico is null) 
            {
                return false;
            }
            else 
            {
                clinicaDbContext.Remove(medico);
                clinicaDbContext.SaveChanges();

                return true;
            }
        }

        public MedicoDTO Put(MedicoDTO medicoDTO)
        {
            Medico medico = new()
            {
                UsuarioID = medicoDTO.UsuarioID,
                Username = medicoDTO.Username,
                Nombre = medicoDTO.Nombre,
                Apellidos = medicoDTO.Apellidos,
                Clave = medicoDTO.Clave,
                NumColegiado = medicoDTO.NumColegiado,
                Citas = new List<Cita>()
            };
            clinicaDbContext.Medicos.Add(medico);
            clinicaDbContext.SaveChanges();
            return medicoDTO;
        }

        private MedicoDTO MapToDTO(Medico medico)
        {
            MedicoDTO medicoDTO = autoMapper.Map<MedicoDTO>(medico);

            if (medico.Pacientes is not null)
            {
                medicoDTO.PacientesUsuarioID = medico.Pacientes.Select(p => p.UsuarioID).ToList();
            }

            if (medico.Citas is not null)
            {
                medicoDTO.CitasID = medico.Citas.Select(c => c.CitaID).ToList();
            }

            return medicoDTO;
        }
    }
}
