using System;

namespace TP_NT.Models
{
    public class Usuario 
    {
        public string Id_Usuario { get; set; }

        public string Nombre { get; set; }

        public string Contraseña { get; set; }

        public Equipo_Usuario Equipo_Usuario { get; set; }

    }
}