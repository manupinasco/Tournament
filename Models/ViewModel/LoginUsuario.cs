using System.ComponentModel.DataAnnotations;

namespace TP_NT.Models.ViewModel
{
    public class LoginUsuario
    {
        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}