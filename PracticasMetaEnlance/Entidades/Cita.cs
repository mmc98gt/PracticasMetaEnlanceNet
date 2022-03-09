namespace PracticasMetaEnlance.Entidades
{
    public class Cita
    {
	public class Cita
	{
		[ScaffoldColumn(false)]                         
		public int CitaID { get; set; }

		[Required]
		public DateTime FechaHora { get; set; }

		[Required]
		public string MotivoCita { get; set; }

		[Required]
		public Paciente Paciente { get; set; }         // relacion 0..* a 1 
		public int PacienteID { get; set; }

		[Required]
		public Medico Medico { get; set; }              // relacion 0..* a 1
		public int MedicoID { get; set; }
		public Diagnostico Diagnostico { get; set; }    // relacion 1 a 1
    }
}
