using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TP_NT.Models.ViewModel
{ 
    public class DatosFormEquipo
    {  
        public double Presupuesto { get; set; }
        [Required(ErrorMessage = "Elegí un jugador")]
        public IEnumerable<SelectListItem> JugadoresBase {get; set; }
        [Required(ErrorMessage = "Elegí un jugador")]
        public IEnumerable<SelectListItem> JugadoresEscolta {get; set; }
        [Required(ErrorMessage = "Elegí un jugador")]
        public IEnumerable<SelectListItem> JugadoresAlero {get; set; }
        [Required(ErrorMessage = "Elegí un jugador")]
        public IEnumerable<SelectListItem> JugadoresAlaPivot {get; set; }
        [Required(ErrorMessage = "Elegí un jugador")]
        public IEnumerable<SelectListItem> JugadoresPivot {get; set; }

        [Required(ErrorMessage = "Elegí un jugador")]
        public double BaseTitular { get; set; }

        [Required(ErrorMessage = "Elegí un jugador")]
        public double EscoltaTitular { get; set; }

        [Required(ErrorMessage = "Elegí un jugador")]
        public double AleroTitular { get; set; }

        [Required(ErrorMessage = "Elegí un jugador")]
        public double AlaPivotTitular { get; set; }
        [Required(ErrorMessage = "Elegí un jugador")]
        public double PivotTitular { get; set; }

        [Required(ErrorMessage = "Elegí un jugador")]
        public double BaseSuplente { get; set; }

        [Required(ErrorMessage = "Elegí un jugador")]
        public double EscoltaSuplente { get; set; }

        [Required(ErrorMessage = "Elegí un jugador")]
        public double AleroSuplente { get; set; }

        [Required(ErrorMessage = "Elegí un jugador")]
        public double AlaPivotSuplente { get; set; }

        [Required(ErrorMessage = "Elegí un jugador")]
        public double PivotSuplente { get; set; }
        
    }
}