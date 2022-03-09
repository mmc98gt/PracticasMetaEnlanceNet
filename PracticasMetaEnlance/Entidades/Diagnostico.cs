namespace PracticasMetaEnlance.Entidades
{
    public class Diagnostico
    {   
        [ScaffoldColumn(false)]
        public int DiagnosticoID { get; set; }

        [Required]
        public string ValoracionEspecialista { get; set; }

        [Required]
        public string Enfermedad { get; set; }

        public int CitaID { get; set; }
        public Cita Cita { get; set; }          // relacion 1 a 1

    }
}
