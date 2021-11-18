using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TP_NT.Models.ViewModel;

namespace TP_NT.Models
{
    public class TorneoVM
    {

        public string NombreTorneo { get; set; }


        public ICollection<TorneoViewModel> Torneos { get; set; }

       

    }

    public class TorneoViewModel
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public Usuario Creador { get; set; }

       

    }
}