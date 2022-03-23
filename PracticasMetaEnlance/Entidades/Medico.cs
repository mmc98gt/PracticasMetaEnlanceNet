using System.ComponentModel.DataAnnotations;

namespace PracticasMetaEnlance.Entidades
{
    public class Medico : Usuario
    {
        public int Id { get; set; }

        [Required]
        public string NumColegiado { get; set; }                  // ID del médico

        public List<Paciente> Pacientes { get; set; }     // relacion 1..* a 1..*

        public List<Cita> Citas { get; set; }             // relacion 1 a 0..*

        public Medico()
        {
            Pacientes = new List<Paciente>();
            Citas = new List<Cita>();
        }

    }
}
