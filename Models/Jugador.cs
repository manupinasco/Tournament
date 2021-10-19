using System;

namespace TP_NT.Models
{
    public class Jugador 
    {
        public string Id_Jugador { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public Equipo Equipo { get; set; }

        public Posicion Posicion { get; set; }

    }
}