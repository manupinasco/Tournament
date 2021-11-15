using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TP_NT.Models.ViewModel
{ 
    public class IndexVM
    {  
        public List<Jugador> Jugadores { get; set;}

        public List<Jugador> Titulares { get; set;}

        public List<Jugador> Suplentes { get; set;}
        
    }
}