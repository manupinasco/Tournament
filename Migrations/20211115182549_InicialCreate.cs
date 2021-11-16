using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TP_NT.Migrations
{
    public partial class InicialCreate : Migration
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
                name: "Torneos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Torneos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Presupuesto = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
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
                    Posicion = table.Column<int>(type: "int", nullable: false),
                    ValorContrato = table.Column<double>(type: "float", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "Partidos",
                columns: table => new
                {
                    IdPartido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocalId = table.Column<int>(type: "int", nullable: true),
                    VisitanteId = table.Column<int>(type: "int", nullable: true),
                    PuntosLocal = table.Column<int>(type: "int", nullable: false),
                    PuntosVisitante = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                name: "TorneoUsuario",
                columns: table => new
                {
                    TorneosId = table.Column<int>(type: "int", nullable: false),
                    UsuariosIdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TorneoUsuario", x => new { x.TorneosId, x.UsuariosIdUsuario });
                    table.ForeignKey(
                        name: "FK_TorneoUsuario_Torneos_TorneosId",
                        column: x => x.TorneosId,
                        principalTable: "Torneos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TorneoUsuario_Usuarios_UsuariosIdUsuario",
                        column: x => x.UsuariosIdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipoUserJugs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    IdJugador = table.Column<int>(type: "int", nullable: false),
                    EsTitular = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipoUserJugs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquipoUserJugs_Jugadores_IdJugador",
                        column: x => x.IdJugador,
                        principalTable: "Jugadores",
                        principalColumn: "IdJugador",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipoUserJugs_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JugadorUsuario",
                columns: table => new
                {
                    JugadoresIdJugador = table.Column<int>(type: "int", nullable: false),
                    UsuariosIdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JugadorUsuario", x => new { x.JugadoresIdJugador, x.UsuariosIdUsuario });
                    table.ForeignKey(
                        name: "FK_JugadorUsuario_Jugadores_JugadoresIdJugador",
                        column: x => x.JugadoresIdJugador,
                        principalTable: "Jugadores",
                        principalColumn: "IdJugador",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JugadorUsuario_Usuarios_UsuariosIdUsuario",
                        column: x => x.UsuariosIdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StatsJugXPartido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdJugador = table.Column<int>(type: "int", nullable: false),
                    IdPartido = table.Column<int>(type: "int", nullable: false),
                    Puntos = table.Column<int>(type: "int", nullable: false),
                    Asistencias = table.Column<int>(type: "int", nullable: false),
                    Rebotes = table.Column<int>(type: "int", nullable: false),
                    Robos = table.Column<int>(type: "int", nullable: false),
                    Faltas = table.Column<int>(type: "int", nullable: false),
                    Bloqueos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatsJugXPartido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StatsJugXPartido_Jugadores_IdJugador",
                        column: x => x.IdJugador,
                        principalTable: "Jugadores",
                        principalColumn: "IdJugador",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StatsJugXPartido_Partidos_IdPartido",
                        column: x => x.IdPartido,
                        principalTable: "Partidos",
                        principalColumn: "IdPartido",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EquipoUserJugs_IdJugador",
                table: "EquipoUserJugs",
                column: "IdJugador");

            migrationBuilder.CreateIndex(
                name: "IX_EquipoUserJugs_IdUsuario",
                table: "EquipoUserJugs",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadores_EquipoId",
                table: "Jugadores",
                column: "EquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_JugadorUsuario_UsuariosIdUsuario",
                table: "JugadorUsuario",
                column: "UsuariosIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_LocalId",
                table: "Partidos",
                column: "LocalId");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_VisitanteId",
                table: "Partidos",
                column: "VisitanteId");

            migrationBuilder.CreateIndex(
                name: "IX_StatsJugXPartido_IdJugador",
                table: "StatsJugXPartido",
                column: "IdJugador");

            migrationBuilder.CreateIndex(
                name: "IX_StatsJugXPartido_IdPartido",
                table: "StatsJugXPartido",
                column: "IdPartido");

            migrationBuilder.CreateIndex(
                name: "IX_TorneoUsuario_UsuariosIdUsuario",
                table: "TorneoUsuario",
                column: "UsuariosIdUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipoUserJugs");

            migrationBuilder.DropTable(
                name: "JugadorUsuario");

            migrationBuilder.DropTable(
                name: "StatsJugXPartido");

            migrationBuilder.DropTable(
                name: "TorneoUsuario");

            migrationBuilder.DropTable(
                name: "Jugadores");

            migrationBuilder.DropTable(
                name: "Partidos");

            migrationBuilder.DropTable(
                name: "Torneos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Equipos");
        }
    }
}
