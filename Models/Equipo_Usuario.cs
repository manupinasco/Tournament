using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TP_NT.Models
{
    public class Equipo_Usuario
    {
        [Key]
        public int IdEquipoUsuario{get; set;}
        ICollection<Jugador> Titular {get; set;}
        ICollection<Jugador> Suplente {get; set;}
    }
}
