using System;
using System.ComponentModel.DataAnnotations;

namespace TP_NT.Models
{
    public class Usuario 
    {
        [Key]
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public Equipo_Usuario EquipoUsuario { get; set; }

    }
}