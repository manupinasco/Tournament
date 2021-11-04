using System.ComponentModel.DataAnnotations;

namespace TP_NT.Models.ViewModel
{
    public class Ranking
    {   
        public string NombreUsuario {get; set;}

        public int Puesto {get; set; }

        public string NombreEquipo { get; set; }

        public int Puntaje {get; set; }

        
    }
}