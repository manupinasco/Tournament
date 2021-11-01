using System.ComponentModel.DataAnnotations;

namespace TP_NT.Models.ViewModel
{
    public class LoginUsuario
    {   

        [Required(ErrorMessage = "Debe ingresar un email.")]
        [EmailAddress(ErrorMessage = "El email ingresado no es valido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Debe ingresar su password")]
        [StringLength(15, ErrorMessage = "Longitud del password debe ser entre 6 y 15 caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}