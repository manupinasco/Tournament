using System.ComponentModel.DataAnnotations;
using System;

namespace TP_NT.Models
{
    public enum Posiciones
    {     
      BASE,ESCOLTA,ALERO,ALA_PIVOT,PIVOT
    }
    public class Posicion
    {
        [Key]
         public int idPos{get; set;}
         public Posiciones Pos { get; set; }

    }
}