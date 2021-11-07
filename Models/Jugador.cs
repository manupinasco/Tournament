using System;
using System.ComponentModel.DataAnnotations;

namespace TP_NT.Models
{
    public enum Posiciones
    {     
      BASE,ESCOLTA,ALERO,ALA_PIVOT,PIVOT
    }
    public class Jugador 
    {
        [Key]
        public int IdJugador { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Equipo Equipo { get; set; }
        public Posiciones Posicion { get; set; }

        public double ValorContrato { get; set; }

    }
}