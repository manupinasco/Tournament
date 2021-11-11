using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public double Presupuesto { get; set; }

        public ICollection<Jugador> Jugadores {get; set;}
        
        public ICollection<Torneo> Torneos { get; set; }

    }
}