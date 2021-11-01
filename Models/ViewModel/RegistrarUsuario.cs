using System.ComponentModel.DataAnnotations;

namespace TP_NT.Models.ViewModel
{
    public class RegistrarUsuario
    {   
        [Required(ErrorMessage = "Debe ingresar un nombre.")]
        [MaxLength(20, ErrorMessage = "La longitud maxima es 20 caracteres." )]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe ingresar un apellido.")]
        [MaxLength(20, ErrorMessage = "La longitud maxima es 20 caracteres." )]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Debe ingresar una edad.")]
        public int Edad { get; set;}
        [Required(ErrorMessage = "Debe ingresar un email.")]
        [EmailAddress(ErrorMessage = "El email ingresado no es valido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Debe ingresar su password")]
        [StringLength(15, ErrorMessage = "Longitud del password debe ser entre 6 y 15 caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}