using System;
using System.ComponentModel.DataAnnotations;

namespace TP_NT.Models
{
    public class Partido
    {
        [Key]
        public int IdPartido { get; set; }
        public string IdLocal { get; set; }
        public Equipo Local { get; set; }
        public string IdVisitante { get; set; }
        public Equipo Visitante { get; set; }
        public int PuntosLocal { get; set; }
        public int PuntosVisitante { get; set; }

    }
}