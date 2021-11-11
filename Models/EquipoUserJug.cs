using System.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP_NT.Models
{
    public class EquipoUserJug
    {
        [Key]
        public int Id {get; set; }

        [ForeignKey(nameof(Usuario))]
        public int IdUsuario{get; set;} 
        public Usuario Usuario {get; set; }

        [ForeignKey(nameof(Jugador))]
        public int IdJugador{get; set;} 
        public Jugador Jugador {get; set; }

        public bool EsTitular { get; set;}
    }
}