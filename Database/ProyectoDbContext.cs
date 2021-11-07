using Microsoft.EntityFrameworkCore;
using TP_NT.Models;

namespace TP_NT.Database {

    public class ProyectoDbContext : DbContext 
    {
        public ProyectoDbContext(DbContextOptions<ProyectoDbContext> options) : base(options){}

        public DbSet<EquipoUsuario> EquiposUsuario {get; set; }

        public DbSet<Equipo> Equipos {get; set; }

        public DbSet<Jugador> Jugadores {get; set; }

        public DbSet<Partido> Partidos {get; set; }
        
        public DbSet<StatsJugXPartido> StatsJugXPartido {get; set; }

        public DbSet<Usuario> Usuarios {get; set; }

        public DbSet<Torneo> Torneos {get; set; }
}

}