namespace PracticasMetaEnlance.Entidades
{
    public class Cita
    {
        [Key]
        public int citaID { get; set; }
        public DateTime fechaHora { get; set; }
        public string motivoCita { get; set; }
        public Paciente paciente { get; set; }
        public Medico medico { get; set; }
        public Diagnostico diagnostico { get; set; }
    }
}
