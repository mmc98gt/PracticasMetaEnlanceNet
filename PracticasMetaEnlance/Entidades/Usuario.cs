using System.ComponentModel.DataAnnotations;

namespace PracticasMetaEnlance.Entidades
{
    public class Usuario : IEntity
    {
        public int Id { get; set; }

        [ScaffoldColumn(false)]
        public int UsuarioID { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellidos { get; set; }

        [Required]
        public string Username { get; set; }        // No puede llamarse igual que la clase Usuario

        [Required]
        public string Clave { get; set; }
    }
}
