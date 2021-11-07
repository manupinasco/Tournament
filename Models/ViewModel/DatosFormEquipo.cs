using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace TP_NT.Models.ViewModel
{ 
    public class DatosFormEquipo
    {   
        public List<Jugador> Jugadores {get; set; }
        
        public Array Posicion {get; set; }

        public bool[] jugsT = new bool[10];
        public bool[] jugsS = new bool[10];
    }
}