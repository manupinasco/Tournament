using Microsoft.EntityFrameworkCore;
using TP_NT.Models;

namespace TP_NT.Database {

    public class ProyectoDbContext : DbContext 
    {

        public ProyectoDbContext(DbContextOptions<ProyectoDbContext> options) : base(options){}

        public DbSet<Equipo_Usuario> Equipos_Usuario {get; set; }

        public DbSet<Equipo> Equipos {get; set; }

        public DbSet<Jugador> Jugadores {get; set; }

        public DbSet<Partido> Partidos {get; set; }
        
        public DbSet<Stats_Jug_X_Partido> Stats_Jug_X_Partido {get; set; }

        public DbSet<Usuario> Usuarios {get; set; }

        public DbSet<Posicion> Posiciones {get; set; }
}

}