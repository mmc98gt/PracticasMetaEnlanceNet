using System.ComponentModel.DataAnnotations;

namespace PracticasMetaEnlance.Entidades
{
    public class Usuario
    {
        [Key]
        public int UserId { get; set; }
        public string usuario { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string clave { get; set; }

    }
}
