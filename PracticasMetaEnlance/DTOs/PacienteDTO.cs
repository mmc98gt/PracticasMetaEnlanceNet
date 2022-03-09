using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.DTOs
{
    public class PacienteDTO
    {
        public int UsuarioID { get; set; }
        public string Username { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Clave { get; set; }
        public string NSS { get; set; }
        public string NumTarjeta { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public List<int> MedicosID { get; set; }
        public List<int> CitasID { get; set; }
    }
}
