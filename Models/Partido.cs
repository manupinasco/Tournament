using System;

namespace TP_NT.Models
{
    public class Partido
    {
        public string Id_Partido { get; set; }

        public string Id_Local { get; set; }

        public Equipo Local { get; set; }

        public string Id_Visitante { get; set; }

        public Equipo Visitante { get; set; }

        public int Puntos_Local { get; set; }

        public int Puntos_Visitante { get; set; }

    }
}