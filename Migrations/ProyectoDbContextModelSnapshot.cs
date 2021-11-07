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

            modelBuilder.Entity("TP_NT.Models.EquipoUsuario", b =>
                {
                    b.Property<int>("IdEquipoUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("IdEquipoUsuario");

                    b.ToTable("EquiposUsuario");
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

                    b.Property<int?>("EquipoUsuarioIdEquipoUsuario")
                        .HasColumnType("int");

                    b.Property<int?>("EquipoUsuarioIdEquipoUsuario1")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Posicion")
                        .HasColumnType("int");

                    b.Property<double>("ValorContrato")
                        .HasColumnType("float");

                    b.HasKey("IdJugador");

                    b.HasIndex("EquipoId");

                    b.HasIndex("EquipoUsuarioIdEquipoUsuario");

                    b.HasIndex("EquipoUsuarioIdEquipoUsuario1");

                    b.ToTable("Jugadores");
                });

            modelBuilder.Entity("TP_NT.Models.Partido", b =>
                {
                    b.Property<int>("IdPartido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IdLocal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdVisitante")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<int>("Faltas")
                        .HasColumnType("int");

                    b.Property<int?>("JugadorIdJugador")
                        .HasColumnType("int");

                    b.Property<int?>("PartidoIdPartido")
                        .HasColumnType("int");

                    b.Property<int>("Puntos")
                        .HasColumnType("int");

                    b.Property<int>("Rebotes")
                        .HasColumnType("int");

                    b.Property<int>("Robos")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("JugadorIdJugador");

                    b.HasIndex("PartidoIdPartido");

                    b.ToTable("StatsJugXPartido");
                });

            modelBuilder.Entity("TP_NT.Models.Torneo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreadorIdUsuario")
                        .HasColumnType("int");

                    b.Property<int>("IdCreador")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreadorIdUsuario");

                    b.ToTable("Torneos");
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

                    b.Property<int?>("EquipoUsuarioIdEquipoUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TorneoId")
                        .HasColumnType("int");

                    b.HasKey("IdUsuario");

                    b.HasIndex("EquipoUsuarioIdEquipoUsuario");

                    b.HasIndex("TorneoId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("TP_NT.Models.Jugador", b =>
                {
                    b.HasOne("TP_NT.Models.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("EquipoId");

                    b.HasOne("TP_NT.Models.EquipoUsuario", null)
                        .WithMany("Suplente")
                        .HasForeignKey("EquipoUsuarioIdEquipoUsuario");

                    b.HasOne("TP_NT.Models.EquipoUsuario", null)
                        .WithMany("Titular")
                        .HasForeignKey("EquipoUsuarioIdEquipoUsuario1");

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
                        .HasForeignKey("JugadorIdJugador");

                    b.HasOne("TP_NT.Models.Partido", "Partido")
                        .WithMany()
                        .HasForeignKey("PartidoIdPartido");

                    b.Navigation("Jugador");

                    b.Navigation("Partido");
                });

            modelBuilder.Entity("TP_NT.Models.Torneo", b =>
                {
                    b.HasOne("TP_NT.Models.Usuario", "Creador")
                        .WithMany()
                        .HasForeignKey("CreadorIdUsuario");

                    b.Navigation("Creador");
                });

            modelBuilder.Entity("TP_NT.Models.Usuario", b =>
                {
                    b.HasOne("TP_NT.Models.EquipoUsuario", "EquipoUsuario")
                        .WithMany()
                        .HasForeignKey("EquipoUsuarioIdEquipoUsuario");

                    b.HasOne("TP_NT.Models.Torneo", null)
                        .WithMany("Usuarios")
                        .HasForeignKey("TorneoId");

                    b.Navigation("EquipoUsuario");
                });

            modelBuilder.Entity("TP_NT.Models.EquipoUsuario", b =>
                {
                    b.Navigation("Suplente");

                    b.Navigation("Titular");
                });

            modelBuilder.Entity("TP_NT.Models.Torneo", b =>
                {
                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
