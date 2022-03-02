namespace PracticasMetaEnlance.Entidades
{
    public class Diagnostico
    {   
        [Key]
        public int diagnosticoID { }
        public string valoracionEspecialista { get; set; }
        public string enfermedad { get; set; }
        public Cita cita { get; set; }

    }
}
