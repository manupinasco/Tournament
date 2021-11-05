using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace TP_NT.Models.ViewModel
{
    public class DatosFormEquipo
    {   
        public IQueryable<Jugador> Jugadores {get; set; }
        
        public Array Posicion {get; set; }
    }
}