﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace TP_NT.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipos_Usuario",
                columns: table => new
                {
                    IdEquipoUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos_Usuario", x => x.IdEquipoUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Posiciones",
                columns: table => new
                {
                    idPos = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posiciones", x => x.idPos);
                });

            migrationBuilder.CreateTable(
                name: "Partidos",
                columns: table => new
                {
                    IdPartido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdLocal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalId = table.Column<int>(type: "int", nullable: true),
                    IdVisitante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitanteId = table.Column<int>(type: "int", nullable: true),
                    PuntosLocal = table.Column<int>(type: "int", nullable: false),
                    PuntosVisitante = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partidos", x => x.IdPartido);
                    table.ForeignKey(
                        name: "FK_Partidos_Equipos_LocalId",
                        column: x => x.LocalId,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partidos_Equipos_VisitanteId",
                        column: x => x.VisitanteId,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Jugadores",
                columns: table => new
                {
                    IdJugador = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipoId = table.Column<int>(type: "int", nullable: true),
                    PosicionidPos = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugadores", x => x.IdJugador);
                    table.ForeignKey(
                        name: "FK_Jugadores_Equipos_EquipoId",
                        column: x => x.EquipoId,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Jugadores_Posiciones_PosicionidPos",
                        column: x => x.PosicionidPos,
                        principalTable: "Posiciones",
                        principalColumn: "idPos",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stats_Jug_X_Partido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JugadorIdJugador = table.Column<int>(type: "int", nullable: true),
                    PartidoIdPartido = table.Column<int>(type: "int", nullable: true),
                    Puntos = table.Column<int>(type: "int", nullable: false),
                    Asistencias = table.Column<int>(type: "int", nullable: false),
                    Rebotes = table.Column<int>(type: "int", nullable: false),
                    Robos = table.Column<int>(type: "int", nullable: false),
                    Faltas = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats_Jug_X_Partido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stats_Jug_X_Partido_Jugadores_JugadorIdJugador",
                        column: x => x.JugadorIdJugador,
                        principalTable: "Jugadores",
                        principalColumn: "IdJugador",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stats_Jug_X_Partido_Partidos_PartidoIdPartido",
                        column: x => x.PartidoIdPartido,
                        principalTable: "Partidos",
                        principalColumn: "IdPartido",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipoUsuarioIdEquipoUsuario = table.Column<int>(type: "int", nullable: true),
                    TorneoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_Usuarios_Equipos_Usuario_EquipoUsuarioIdEquipoUsuario",
                        column: x => x.EquipoUsuarioIdEquipoUsuario,
                        principalTable: "Equipos_Usuario",
                        principalColumn: "IdEquipoUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Torneos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreadorIdUsuario = table.Column<int>(type: "int", nullable: true),
                    IdCreador = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Torneos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Torneos_Usuarios_CreadorIdUsuario",
                        column: x => x.CreadorIdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jugadores_EquipoId",
                table: "Jugadores",
                column: "EquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadores_PosicionidPos",
                table: "Jugadores",
                column: "PosicionidPos");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_LocalId",
                table: "Partidos",
                column: "LocalId");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_VisitanteId",
                table: "Partidos",
                column: "VisitanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Stats_Jug_X_Partido_JugadorIdJugador",
                table: "Stats_Jug_X_Partido",
                column: "JugadorIdJugador");

            migrationBuilder.CreateIndex(
                name: "IX_Stats_Jug_X_Partido_PartidoIdPartido",
                table: "Stats_Jug_X_Partido",
                column: "PartidoIdPartido");

            migrationBuilder.CreateIndex(
                name: "IX_Torneos_CreadorIdUsuario",
                table: "Torneos",
                column: "CreadorIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_EquipoUsuarioIdEquipoUsuario",
                table: "Usuarios",
                column: "EquipoUsuarioIdEquipoUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_TorneoId",
                table: "Usuarios",
                column: "TorneoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Torneos_TorneoId",
                table: "Usuarios",
                column: "TorneoId",
                principalTable: "Torneos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Torneos_Usuarios_CreadorIdUsuario",
                table: "Torneos");

            migrationBuilder.DropTable(
                name: "Stats_Jug_X_Partido");

            migrationBuilder.DropTable(
                name: "Jugadores");

            migrationBuilder.DropTable(
                name: "Partidos");

            migrationBuilder.DropTable(
                name: "Posiciones");

            migrationBuilder.DropTable(
                name: "Equipos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Equipos_Usuario");

            migrationBuilder.DropTable(
                name: "Torneos");
        }
    }
}