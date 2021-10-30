using System.Globalization;
using System.ComponentModel.DataAnnotations;


namespace TP_NT.Models.ViewModel
{
    public class RegistrarUsuario
    {   
        [Required]
        [MaxLength(20)]
        public string Nombre { get; set; }
        [Required]
        [MaxLength(20)]
        public string Apellido { get; set; }
        public int Edad { get; set;}
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(16)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}