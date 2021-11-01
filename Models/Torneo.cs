using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace TP_NT.Models
{
    public class Torneo
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public ICollection<Usuario> Usuarios { get; set; }

        public Usuario Creador { get; set; }

        public int IdCreador { get; set; }

    }
}