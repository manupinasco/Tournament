using System.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP_NT.Models
{
    public class TorneoUsuario
    {
        [Key]
        public int Id {get; set; }

        [ForeignKey(nameof(Usuario))]
        public int IdUsuario{get; set;} 
        public Usuario Usuario {get; set; }

        [ForeignKey(nameof(Torneo))]
        public int IdTorneo{get; set;} 
        public Torneo Torneo {get; set; }

        public bool EsCreador {get; set; }

    }
}