using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Clinica.Entities;
using Clinica.DTOs;
using Clinica.Repositories;

namespace Clinica.Services
{
    public class PacienteService : IPacienteService
    {
        private ClinicaDbContext clinicaDbContext;
        protected IMapper autoMapper;
        public PacienteService(ClinicaDbContext dbContext, IMapper autoMapper)
        {
            this.clinicaDbContext = dbContext;
            this.autoMapper = autoMapper;
        }

        public PacienteDTO Get(int id)
        {
            //var medico = MapToDTO(clinicaDbContext.Medicos.Include(m => m.Pacientes).Include(m => m.Citas).Single(m => m.UsuarioID == id));
            var paciente = MapToDTO(clinicaDbContext.Pacientes.Find(id));

            if (paciente is null)
            {
                return null;
            }
            else
            {
                return paciente;
            }
        }

        public List<PacienteDTO> GetAll()
        {
            List<Paciente> pacientes = clinicaDbContext.Pacientes.ToList();

            return pacientes.Select(m => MapToDTO(m)).ToList();
        }

        public bool Delete(int id)
        {
            Paciente paciente = clinicaDbContext.Pacientes.Find(id);
            if (paciente == null)
            {
                return false;
            }
            else
            {
                clinicaDbContext.Remove(paciente);
                clinicaDbContext.SaveChanges();

                return true;
            }
        }

        public PacienteDTO Put(PacienteDTO pacienteDTO)
        {
            Paciente paciente = new()
            {
                NSS = pacienteDTO.NSS,
                NumTarjeta = pacienteDTO.NumTarjeta,
                Telefono = pacienteDTO.Telefono,
                Direccion = pacienteDTO.Direccion,
                UsuarioID = pacienteDTO.UsuarioID,
                Username = pacienteDTO.Username,
                Nombre = pacienteDTO.Nombre,
                Apellidos = pacienteDTO.Apellidos,
                Clave = pacienteDTO.Clave,
                Medicos = new List<Medico>(),
                Citas = new List<Cita>()
            };
            clinicaDbContext.Pacientes.Add(paciente);
            clinicaDbContext.SaveChanges();
            return pacienteDTO;
        }

        private PacienteDTO MapToDTO(Paciente paciente)
        {
            PacienteDTO pacienteDTO = autoMapper.Map<PacienteDTO>(paciente);

            if (paciente.Citas != null)
            {
                pacienteDTO.CitasID = paciente.Citas.Select(c => c.CitaID).ToList();
            }
            else
            {
                Console.WriteLine("No hay ningún paciente con ese ID");
            }

            return pacienteDTO;
        }
    }
}

