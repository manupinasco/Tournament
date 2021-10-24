using System;

namespace TP_NT.Models
{
    public class Equipo_Usuario
    {
        public string Id_Equipo_Usuario { get; set; }

        public string Nombre { get; set; }

        public Jugador Base_Titular { get; set; }
        
        public Jugador Escolta_Titular { get; set; }

        public Jugador Alero_Titular { get; set; }

        public Jugador Ala_Pivot_Titular { get; set; }

        public Jugador Pivot_Titular { get; set; }

        public Jugador Base_Suplente { get; set; }

        public Jugador Escolta_Suplente { get; set; }

        public Jugador Alero_Suplente { get; set; }

        public Jugador Ala_Pivot_Suplente { get; set; }

        public string Id_Pivot_Suplente { get; set; }

    }
}
