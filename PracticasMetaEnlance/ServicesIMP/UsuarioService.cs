using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Clinica.Entities;
using Clinica.Repositories;
using Clinica.Services;
using Clinica.DTOs;

namespace Clinica.Services
{
    public class UsuarioService : IUsuarioService
    {
        protected ClinicaDbContext clinicaDbContext;
        protected IMapper autoMapper;
        public UsuarioService(ClinicaDbContext dbContext, IMapper autoMapper)
        {
            this.clinicaDbContext = dbContext;
            this.autoMapper = autoMapper;
        }

        public UsuarioDTO Get(int id)
        {
            var usuario = autoMapper.Map<UsuarioDTO>(clinicaDbContext.Usuarios.Find(id));

            if (usuario is null)
            {
                return null;
            }
            else
            { 
                return usuario; 
            }
        }

        public List<UsuarioDTO> GetAll()
        {
            var usuarios = autoMapper.Map<List<UsuarioDTO>>(clinicaDbContext.Usuarios);

            if (usuarios is null)
            {
                return null;
            }
            else
            {
                return usuarios;
            }
        }

        public UsuarioDTO Put(UsuarioDTO usuarioDTO)
        {
            Usuario usuario = autoMapper.Map<Usuario>(usuarioDTO);
            clinicaDbContext.Usuarios.Add(usuario);
            clinicaDbContext.SaveChanges();
            return usuarioDTO;
        }

        public bool Delete(int usuarioID)
        {
            Usuario usuario = clinicaDbContext.Usuarios.Find(usuarioID);
            if (usuario is null)
            {
                return false;
            }
            else
            {
                clinicaDbContext.Remove(usuario);
                clinicaDbContext.SaveChanges();
                return true;
            }
        }
    }
}
