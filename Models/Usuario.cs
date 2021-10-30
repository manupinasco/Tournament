using System.ComponentModel.DataAnnotations;

namespace TP_NT.Models
{
    public class Usuario 
    {
        [Key]
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad{ get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public EquipoUsuario EquipoUsuario { get; set; }

    }
}