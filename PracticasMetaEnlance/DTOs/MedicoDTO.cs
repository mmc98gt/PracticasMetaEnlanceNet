using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.DTOs
{
    public class MedicoDTO
    {
        public int UsuarioID { get; set; }
        public string NumColegiado { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Username { get; set; }
        public string Clave { get; set; }
        public List<int> PacientesUsuarioID { get; set; }
        public List<int> CitasID { get; set; }
    }
}
