using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinica.Entities;
using Clinica.DTOs;

namespace Clinica.Services
{
    public interface ICitaService
    {
        public List<CitaDTO> GetAll();
        public CitaDTO Get(int id);
        public CitaDTO Put(CitaDTO citaDTO);
        public bool Delete(int id);
    }
}
