using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP_NT.Models
{
    public class Partido
    {
        [Key]
        public int IdPartido { get; set; }
        public Equipo Local { get; set; }

        public Equipo Visitante { get; set; }
        public int PuntosLocal { get; set; }
        public int PuntosVisitante { get; set; }

        public DateTime Fecha { get; set;}

    }
}