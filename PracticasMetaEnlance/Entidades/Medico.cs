namespace PracticasMetaEnlance.Entidades
{
    public class Medico : Usuario
    {
       public string numColegiado { get; set; }
       public ICollection<Paciente> pacientes { get; set; } = new List<Paciente>();
       public ICollection<Cita> citas { get; set; } = new List<Cita>();
    }
}
