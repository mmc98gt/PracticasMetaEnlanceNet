using System.ComponentModel.DataAnnotations;

namespace PracticasMetaEnlance.Entidades
{
    public class Paciente : Usuario
    {
        public int Id { get; set; }

        [Required]
        public string NSS { get; set; }                         // ID del Paciente

        [Required]
        public string NumTarjeta { get; set; }

        [Required]
        public string Telefono { get; set; }

        [Required]
        public string Direccion { get; set; }

        public List<Medico> Medicos { get; set; }        // relacion 1...* a 1...*

        public List<Cita> Citas { get; set; }            // relacion 1 a 0...*

        public Paciente()
        {
            Medicos = new List<Medico>();
            Citas = new List<Cita>();
        }

    }
}
