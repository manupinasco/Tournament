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
        public IEnumerable<SelectListItem> JugadoresBase {get; set; }

        public IEnumerable<SelectListItem> JugadoresEscolta {get; set; }

        public IEnumerable<SelectListItem> JugadoresAlero {get; set; }

        public IEnumerable<SelectListItem> JugadoresAlaPivot {get; set; }

        public IEnumerable<SelectListItem> JugadoresPivot {get; set; }

        public double BaseTitular { get; set; }

        public double EscoltaTitular { get; set; }

        public double AleroTitular { get; set; }

        public double AlaPivotTitular { get; set; }

        public double PivotTitular { get; set; }

        public double BaseSuplente { get; set; }

        public double EscoltaSuplente { get; set; }

        public double AleroSuplente { get; set; }

        public double AlaPivotSuplente { get; set; }

        public double PivotSuplente { get; set; }
        
    }
}