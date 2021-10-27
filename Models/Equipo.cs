using System;
using System.ComponentModel.DataAnnotations;

namespace TP_NT.Models
{
    public class Equipo 
    {   
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }

    }
}