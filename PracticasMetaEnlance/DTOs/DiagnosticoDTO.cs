using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.DTOs
{
    public class DiagnosticoDTO
    {
        public int DiagnosticoID { get; set; }
        public string ValoracionEspecialista { get; set; }
        public string Enfermedad { get; set; }
        public int CitaID { get; set; }
    }
}
