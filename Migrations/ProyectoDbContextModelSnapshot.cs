﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TP_NT.Database;

namespace TP_NT.Migrations
{
    [DbContext(typeof(ProyectoDbContext))]
    partial class ProyectoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JugadorUsuario", b =>
                {
                    b.Property<int>("JugadoresIdJugador")
                        .HasColumnType("int");

                    b.Property<int>("UsuariosIdUsuario")
                        .HasColumnType("int");

                    b.HasKey("JugadoresIdJugador", "UsuariosIdUsuario");

                    b.HasIndex("UsuariosIdUsuario");

                    b.ToTable("JugadorUsuario");
                });

            modelBuilder.Entity("TP_NT.Models.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("TP_NT.Models.EquipoUserJug", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("EsTitular")
                        .HasColumnType("bit");

                    b.Property<int>("IdJugador")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdJugador");

                    b.HasIndex("IdUsuario");

                    b.ToTable("EquipoUserJugs");
                });

            modelBuilder.Entity("TP_NT.Models.Jugador", b =>
                {
                    b.Property<int>("IdJugador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EquipoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Posicion")
                        .HasColumnType("int");

                    b.Property<double>("ValorContrato")
                        .HasColumnType("float");

                    b.HasKey("IdJugador");

                    b.HasIndex("EquipoId");

                    b.ToTable("Jugadores");
                });

            modelBuilder.Entity("TP_NT.Models.Partido", b =>
                {
                    b.Property<int>("IdPartido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LocalId")
                        .HasColumnType("int");

                    b.Property<int>("PuntosLocal")
                        .HasColumnType("int");

                    b.Property<int>("PuntosVisitante")
                        .HasColumnType("int");

                    b.Property<int?>("VisitanteId")
                        .HasColumnType("int");

                    b.HasKey("IdPartido");

                    b.HasIndex("LocalId");

                    b.HasIndex("VisitanteId");

                    b.ToTable("Partidos");
                });

            modelBuilder.Entity("TP_NT.Models.StatsJugXPartido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Asistencias")
                        .HasColumnType("int");

                    b.Property<int>("Bloqueos")
                        .HasColumnType("int");

                    b.Property<int>("Faltas")
                        .HasColumnType("int");

                    b.Property<int>("IdJugador")
                        .HasColumnType("int");

                    b.Property<int>("IdPartido")
                        .HasColumnType("int");

                    b.Property<int>("Puntos")
                        .HasColumnType("int");

                    b.Property<int>("Rebotes")
                        .HasColumnType("int");

                    b.Property<int>("Robos")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdJugador");

                    b.HasIndex("IdPartido");

                    b.ToTable("StatsJugXPartido");
                });

            modelBuilder.Entity("TP_NT.Models.Torneo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Torneos");
                });

            modelBuilder.Entity("TP_NT.Models.TorneoUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("EsCreador")
                        .HasColumnType("bit");

                    b.Property<int>("IdTorneo")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdTorneo");

                    b.HasIndex("IdUsuario");

                    b.ToTable("TorneoUsuarios");
                });

            modelBuilder.Entity("TP_NT.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Presupuesto")
                        .HasColumnType("float");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("TorneoUsuario", b =>
                {
                    b.Property<int>("TorneosId")
                        .HasColumnType("int");

                    b.Property<int>("UsuariosIdUsuario")
                        .HasColumnType("int");

                    b.HasKey("TorneosId", "UsuariosIdUsuario");

                    b.HasIndex("UsuariosIdUsuario");

                    b.ToTable("TorneoUsuario");
                });

            modelBuilder.Entity("JugadorUsuario", b =>
                {
                    b.HasOne("TP_NT.Models.Jugador", null)
                        .WithMany()
                        .HasForeignKey("JugadoresIdJugador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TP_NT.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UsuariosIdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TP_NT.Models.EquipoUserJug", b =>
                {
                    b.HasOne("TP_NT.Models.Jugador", "Jugador")
                        .WithMany()
                        .HasForeignKey("IdJugador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TP_NT.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Jugador");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("TP_NT.Models.Jugador", b =>
                {
                    b.HasOne("TP_NT.Models.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("EquipoId");

                    b.Navigation("Equipo");
                });

            modelBuilder.Entity("TP_NT.Models.Partido", b =>
                {
                    b.HasOne("TP_NT.Models.Equipo", "Local")
                        .WithMany()
                        .HasForeignKey("LocalId");

                    b.HasOne("TP_NT.Models.Equipo", "Visitante")
                        .WithMany()
                        .HasForeignKey("VisitanteId");

                    b.Navigation("Local");

                    b.Navigation("Visitante");
                });

            modelBuilder.Entity("TP_NT.Models.StatsJugXPartido", b =>
                {
                    b.HasOne("TP_NT.Models.Jugador", "Jugador")
                        .WithMany()
                        .HasForeignKey("IdJugador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TP_NT.Models.Partido", "Partido")
                        .WithMany()
                        .HasForeignKey("IdPartido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Jugador");

                    b.Navigation("Partido");
                });

            modelBuilder.Entity("TP_NT.Models.TorneoUsuario", b =>
                {
                    b.HasOne("TP_NT.Models.Torneo", "Torneo")
                        .WithMany()
                        .HasForeignKey("IdTorneo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TP_NT.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Torneo");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("TorneoUsuario", b =>
                {
                    b.HasOne("TP_NT.Models.Torneo", null)
                        .WithMany()
                        .HasForeignKey("TorneosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TP_NT.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UsuariosIdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
