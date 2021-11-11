using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TP_NT.Models.ViewModel
{ 
    public class DatosFormEquipo
    {  
        public double Presupuesto { get; set; }
        public IEnumerable<SelectListItem> JugadoresBase {get; set; }

        public IEnumerable<SelectListItem> JugadoresEscolta {get; set; }

        public IEnumerable<SelectListItem> JugadoresAlero {get; set; }

        public IEnumerable<SelectListItem> JugadoresAlaPivot {get; set; }

        public IEnumerable<SelectListItem> JugadoresPivot {get; set; }

        [Required(ErrorMessage = "Elegí un equipo")]
        public double BaseTitular { get; set; }

        [Required(ErrorMessage = "Elegí un equipo")]
        public double EscoltaTitular { get; set; }

        [Required(ErrorMessage = "Elegí un equipo")]
        public double AleroTitular { get; set; }

        [Required(ErrorMessage = "Elegí un equipo")]
        public double AlaPivotTitular { get; set; }

        public double PivotTitular { get; set; }

        [Required(ErrorMessage = "Elegí un equipo")]
        public double BaseSuplente { get; set; }

        [Required(ErrorMessage = "Elegí un equipo")]
        public double EscoltaSuplente { get; set; }

        [Required(ErrorMessage = "Elegí un equipo")]
        public double AleroSuplente { get; set; }

        [Required(ErrorMessage = "Elegí un equipo")]
        public double AlaPivotSuplente { get; set; }

        [Required(ErrorMessage = "Elegí un equipo")]
        public double PivotSuplente { get; set; }
        
    }
}