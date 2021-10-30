using System.ComponentModel.DataAnnotations;

namespace TP_NT.Models.ViewModel
{
    public class RegistrarUsuario
    {   
        [Required(ErrorMessage = "Debe ingresar un nombre")]
        [MaxLength(20)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe ingresar un apellido")]
        [MaxLength(20)]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Debe ingresar una edad")]
        public int Edad { get; set;}
        [Required(ErrorMessage = "Debe ingresar un email")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Debe ingresar su password")]
        [MinLength(8)]
        [MaxLength(16)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}