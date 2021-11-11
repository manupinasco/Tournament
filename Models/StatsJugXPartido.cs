using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP_NT.Models
{
    public class StatsJugXPartido
    {
        [Key]
        public int Id {get; set;}

        [ForeignKey(nameof(Jugador))]
        public int IdJugador {get; set; }
        public Jugador Jugador { get; set; }
        
        [ForeignKey(nameof(Partido))]
        public int IdPartido {get; set;}
        public Partido Partido { get; set; }
        public int Puntos { get; set; }
        public int Asistencias { get; set; }
        public int Rebotes { get; set; }
        public int Robos { get; set; }
        public int Faltas { get; set; }
        public int Score { get; set; }

    }
}