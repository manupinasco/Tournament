using System.Collections;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TP_NT.Models;
using TP_NT.Database;
using Microsoft.EntityFrameworkCore;
using TP_NT.Models.ViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using System.Security.Claims;
using System.Globalization;

namespace TP_NT.Controllers
{
    public class HomeController : Controller
    {
        private ProyectoDbContext _proyectoDbContext;
 
        //private readonly ILogger<HomeController> _logger;
 
        public HomeController(ProyectoDbContext ProyectoDbContext)
        {
            this._proyectoDbContext = ProyectoDbContext;
        }

        public IActionResult Create() {
            var equipo = new Equipo {
                    Nombre = "bulls.png" 
                };
            var equipoDos = new Equipo {
                    Nombre = "lakers.png"
                };

            var equipos = new List<Equipo> {
                equipo,
                equipoDos
            };

            CultureInfo culture = new CultureInfo("es-ES");     

            var partido = new Partido {
                Local = equipo,
                Visitante = equipoDos,
                PuntosLocal = 10,
                PuntosVisitante = 20,
                Fecha = Convert.ToDateTime("6/12/2021 12:10:15 PM", culture)
            };

            var partidoDos = new Partido {
                Local = equipoDos,
                Visitante = equipo,
                PuntosLocal = 5,
                PuntosVisitante = 7,
                Fecha = Convert.ToDateTime("7/12/20 12:10:15 PM", culture)
            };

            var partidos = new List<Partido> {
                partido,
                partidoDos
            };
            
            var jugadores = new List<Jugador> {
                new Jugador {
                    Nombre = "Michael",
                    Apellido = "Jordan",
                    Equipo = equipo,
                    Posicion = Posiciones.ESCOLTA,
                    ValorContrato = 100
                },
                new Jugador {
                    Nombre = "Scottie",
                    Apellido = "Pippen",
                    Equipo = equipo,
                    Posicion = Posiciones.ALERO,
                    ValorContrato = 300
                },
                new Jugador {
                    Nombre = "Zach",
                    Apellido = "LaVine",
                    Equipo = equipo,
                    Posicion = Posiciones.ALERO,
                    ValorContrato = 400
                },
                new Jugador {
                    Nombre = "DeMar",
                    Apellido = "DeRozan",
                    Equipo = equipo,
                    Posicion = Posiciones.ESCOLTA,
                    ValorContrato = 200
                },
                new Jugador {
                    Nombre = "Derrick",
                    Apellido = "Rose",
                    Equipo = equipo,
                    Posicion = Posiciones.BASE,
                    ValorContrato = 400
                },
                new Jugador {
                    Nombre = "Lonzo",
                    Apellido = "Ball",
                    Equipo = equipo,
                    Posicion = Posiciones.BASE,
                    ValorContrato = 100
                },
                new Jugador {
                    Nombre = "Dennis",
                    Apellido = "Rodman",
                    Equipo = equipo,
                    Posicion = Posiciones.ALA_PIVOT,
                    ValorContrato = 500
                },
                new Jugador {
                    Nombre = "Lauri",
                    Apellido = "Markkanen",
                    Equipo = equipo,
                    Posicion = Posiciones.ALA_PIVOT,
                    ValorContrato = 1000
                },
                new Jugador {
                    Nombre = "Joakim",
                    Apellido = "Noah",
                    Equipo = equipo,
                    Posicion = Posiciones.PIVOT,
                    ValorContrato = 200
                },
                new Jugador {
                    Nombre = "Horace",
                    Apellido = "Grant",
                    Equipo = equipo,
                    Posicion = Posiciones.PIVOT,
                    ValorContrato = 300
                },
                new Jugador {
                    Nombre = "LeBron",
                    Apellido = "James",
                    Equipo = equipoDos,
                    Posicion = Posiciones.ALERO,
                    ValorContrato = 400
                },
                new Jugador {
                    Nombre = "Talen",
                    Apellido = "Horton-Tucker",
                    Equipo = equipoDos,
                    Posicion = Posiciones.ALERO,
                    ValorContrato = 100
                },
                new Jugador {
                    Nombre = "Carmelo",
                    Apellido = "Anthony",
                    Equipo = equipoDos,
                    Posicion = Posiciones.ALA_PIVOT,
                    ValorContrato = 300
                },
                new Jugador {
                    Nombre = "Anthony",
                    Apellido = "Davis",
                    Equipo = equipoDos,
                    Posicion = Posiciones.ALA_PIVOT,
                    ValorContrato = 400
                },
                new Jugador {
                    Nombre = "Russell",
                    Apellido = "Westbrook",
                    Equipo = equipoDos,
                    Posicion = Posiciones.BASE,
                    ValorContrato = 200
                },
                new Jugador {
                    Nombre = "Malik",
                    Apellido = "Monk",
                    Equipo = equipoDos,
                    Posicion = Posiciones.BASE,
                    ValorContrato = 100
                },
                new Jugador {
                    Nombre = "DeAndre",
                    Apellido = "Jordan",
                    Equipo = equipoDos,
                    Posicion = Posiciones.PIVOT,
                    ValorContrato = 500
                },
                new Jugador {
                    Nombre = "Dwight",
                    Apellido = "Howard",
                    Equipo = equipoDos,
                    Posicion = Posiciones.PIVOT,
                    ValorContrato = 1000
                },
                new Jugador {
                    Nombre = "Austin",
                    Apellido = "Reaves",
                    Equipo = equipoDos,
                    Posicion = Posiciones.ESCOLTA,
                    ValorContrato = 200
                },
                new Jugador {
                    Nombre = "Jay",
                    Apellido = "Huff",
                    Equipo = equipoDos,
                    Posicion = Posiciones.ESCOLTA,
                    ValorContrato = 400
                }
            };

            var estados = new List<StatsJugXPartido> {
                new StatsJugXPartido {
                    Jugador = jugadores[0],
                    Partido = partido,
                    Puntos = 2,
                    Asistencias = 3,
                    Rebotes = 4,
                    Robos = 0,
                    Faltas = 1,
                    Bloqueos = 2
                },
                new StatsJugXPartido {
                    Jugador = jugadores[0],
                    Partido = partidoDos,
                    Puntos = 3,
                    Asistencias = 5,
                    Rebotes = 4,
                    Robos = 1,
                    Faltas = 2,
                    Bloqueos = 0
                },
                new StatsJugXPartido {
                    Jugador = jugadores[1],
                    Partido = partido,
                    Puntos = 0,
                    Asistencias = 3,
                    Rebotes = 10,
                    Robos = 1,
                    Faltas = 0,
                    Bloqueos = 0
                },
                new StatsJugXPartido {
                    Jugador = jugadores[1],
                    Partido = partidoDos,
                    Puntos = 6,
                    Asistencias = 0,
                    Rebotes = 2,
                    Robos = 1,
                    Faltas = 2,
                    Bloqueos = 2
                },
                new StatsJugXPartido {
                    Jugador = jugadores[2],
                    Partido = partido,
                    Puntos = 5,
                    Asistencias = 0,
                    Rebotes = 2,
                    Robos = 1,
                    Faltas = 4,
                    Bloqueos = 2
                },
                new StatsJugXPartido {
                    Jugador = jugadores[2],
                    Partido = partidoDos,
                    Puntos = 4,
                    Asistencias = 3,
                    Rebotes = 1,
                    Robos = 1,
                    Faltas = 6,
                    Bloqueos = 0
                },
                new StatsJugXPartido {
                    Jugador = jugadores[3],
                    Partido = partido,
                    Puntos = 6,
                    Asistencias = 1,
                    Rebotes = 2,
                    Robos = 1,
                    Faltas = 1,
                    Bloqueos = 0
                },
                new StatsJugXPartido {
                    Jugador = jugadores[3],
                    Partido = partidoDos,
                    Puntos = 4,
                    Asistencias = 3,
                    Rebotes = 3,
                    Robos = 1,
                    Faltas = 2,
                    Bloqueos = 0
                },
                new StatsJugXPartido {
                    Jugador = jugadores[4],
                    Partido = partido,
                    Puntos = 10,
                    Asistencias = 3,
                    Rebotes = 3,
                    Robos = 1,
                    Faltas = 2,
                    Bloqueos = 2
                },
                new StatsJugXPartido {
                    Jugador = jugadores[4],
                    Partido = partidoDos,
                    Puntos = 5,
                    Asistencias = 10,
                    Rebotes = 2,
                    Robos = 1,
                    Faltas = 3,
                    Bloqueos = 1
                },
                new StatsJugXPartido {
                    Jugador = jugadores[5],
                    Partido = partido,
                    Puntos = 5,
                    Asistencias = 10,
                    Rebotes = 10,
                    Robos = 1,
                    Faltas = 0,
                    Bloqueos = 0
                },
                new StatsJugXPartido {
                    Jugador = jugadores[5],
                    Partido = partidoDos,
                    Puntos = 0,
                    Asistencias = 4,
                    Rebotes = 3,
                    Robos = 1,
                    Faltas = 2,
                    Bloqueos = 10
                },
                new StatsJugXPartido {
                    Jugador = jugadores[6],
                    Partido = partido,
                    Puntos = 0,
                    Asistencias = 2,
                    Rebotes = 1,
                    Robos = 1,
                    Faltas = 10,
                    Bloqueos = 2
                },
                new StatsJugXPartido {
                    Jugador = jugadores[6],
                    Partido = partidoDos,
                    Puntos = 0,
                    Asistencias = 5,
                    Rebotes = 5,
                    Robos = 1,
                    Faltas = 3,
                    Bloqueos = 0
                },
                new StatsJugXPartido {
                    Jugador = jugadores[7],
                    Partido = partido,
                    Puntos = 3,
                    Asistencias = 2,
                    Rebotes = 3,
                    Robos = 1,
                    Faltas = 1,
                    Bloqueos = 1
                },
                new StatsJugXPartido {
                    Jugador = jugadores[7],
                    Partido = partidoDos,
                    Puntos = 10,
                    Asistencias = 0,
                    Rebotes = 3,
                    Robos = 1,
                    Faltas = 1,
                    Bloqueos = 0
                },
                new StatsJugXPartido {
                    Jugador = jugadores[8],
                    Partido = partido,
                    Puntos = 15,
                    Asistencias = 2,
                    Rebotes = 3,
                    Robos = 1,
                    Faltas = 0,
                    Bloqueos = 0
                },
                new StatsJugXPartido {
                    Jugador = jugadores[8],
                    Partido = partidoDos,
                    Puntos = 10,
                    Asistencias = 6,
                    Rebotes = 5,
                    Robos = 1,
                    Faltas = 0,
                    Bloqueos = 0
                },
                new StatsJugXPartido {
                    Jugador = jugadores[9],
                    Partido = partido,
                    Puntos = 4,
                    Asistencias = 5,
                    Rebotes = 6,
                    Robos = 1,
                    Faltas = 0,
                    Bloqueos = 2
                },
                new StatsJugXPartido {
                    Jugador = jugadores[9],
                    Partido = partidoDos,
                    Puntos = 4,
                    Asistencias = 5,
                    Rebotes = 5,
                    Robos = 1,
                    Faltas = 1,
                    Bloqueos = 1
                },
                new StatsJugXPartido {
                    Jugador = jugadores[10],
                    Partido = partido,
                    Puntos = 2,
                    Asistencias = 3,
                    Rebotes = 5,
                    Robos = 1,
                    Faltas = 0,
                    Bloqueos = 3
                },
                new StatsJugXPartido {
                    Jugador = jugadores[10],
                    Partido = partidoDos,
                    Puntos = 5,
                    Asistencias = 2,
                    Rebotes = 4,
                    Robos = 1,
                    Faltas = 0,
                    Bloqueos = 2
                },
                new StatsJugXPartido {
                    Jugador = jugadores[11],
                    Partido = partido,
                    Puntos = 0,
                    Asistencias = 3,
                    Rebotes = 2,
                    Robos = 1,
                    Faltas = 10,
                    Bloqueos = 2
                },
                new StatsJugXPartido {
                    Jugador = jugadores[11],
                    Partido = partidoDos,
                    Puntos = 0,
                    Asistencias = 4,
                    Rebotes = 2,
                    Robos = 1,
                    Faltas = 8,
                    Bloqueos = 0
                },
                new StatsJugXPartido {
                    Jugador = jugadores[12],
                    Partido = partido,
                    Puntos = 1,
                    Asistencias = 1,
                    Rebotes = 2,
                    Robos = 1,
                    Faltas = 5,
                    Bloqueos = 0
                },
                new StatsJugXPartido {
                    Jugador = jugadores[12],
                    Partido = partidoDos,
                    Puntos = 1,
                    Asistencias = 3,
                    Rebotes = 2,
                    Robos = 1,
                    Faltas = 6,
                    Bloqueos = 0
                },
                new StatsJugXPartido {
                    Jugador = jugadores[13],
                    Partido = partido,
                    Puntos = 0,
                    Asistencias = 0,
                    Rebotes = 2,
                    Robos = 1,
                    Faltas = 2,
                    Bloqueos = 0
                },
                new StatsJugXPartido {
                    Jugador = jugadores[13],
                    Partido = partidoDos,
                    Puntos = 1,
                    Asistencias = 2,
                    Rebotes = 2,
                    Robos = 1,
                    Faltas = 2,
                    Bloqueos = 0
                },
                new StatsJugXPartido {
                    Jugador = jugadores[14],
                    Partido = partido,
                    Puntos = 3,
                    Asistencias = 6,
                    Rebotes = 4,
                    Robos = 1,
                    Faltas = 3,
                    Bloqueos = 5
                },
                new StatsJugXPartido {
                    Jugador = jugadores[14],
                    Partido = partidoDos,
                    Puntos = 4,
                    Asistencias = 5,
                    Rebotes = 0,
                    Robos = 1,
                    Faltas = 2,
                    Bloqueos = 2
                },
                new StatsJugXPartido {
                    Jugador = jugadores[15],
                    Partido = partido,
                    Puntos = 6,
                    Asistencias = 5,
                    Rebotes = 4,
                    Robos = 1,
                    Faltas = 1,
                    Bloqueos = 1
                },
                new StatsJugXPartido {
                    Jugador = jugadores[15],
                    Partido = partidoDos,
                    Puntos = 3,
                    Asistencias = 4,
                    Rebotes = 6,
                    Robos = 1,
                    Faltas = 5,
                    Bloqueos = 10
                },
                new StatsJugXPartido {
                    Jugador = jugadores[16],
                    Partido = partido,
                    Puntos = 6,
                    Asistencias = 4,
                    Rebotes = 3,
                    Robos = 1,
                    Faltas = 1,
                    Bloqueos = 5
                },
                new StatsJugXPartido {
                    Jugador = jugadores[16],
                    Partido = partidoDos,
                    Puntos = 5,
                    Asistencias = 2,
                    Rebotes = 0,
                    Robos = 1,
                    Faltas = 1,
                    Bloqueos = 4
                },
                new StatsJugXPartido {
                    Jugador = jugadores[17],
                    Partido = partido,
                    Puntos = 2,
                    Asistencias = 4,
                    Rebotes = 2,
                    Robos = 1,
                    Faltas = 1,
                    Bloqueos = 0
                },
                new StatsJugXPartido {
                    Jugador = jugadores[17],
                    Partido = partidoDos,
                    Puntos = 3,
                    Asistencias = 5,
                    Rebotes = 4,
                    Robos = 1,
                    Faltas = 1,
                    Bloqueos = 4
                },
                new StatsJugXPartido {
                    Jugador = jugadores[18],
                    Partido = partido,
                    Puntos = 0,
                    Asistencias = 4,
                    Rebotes = 3,
                    Robos = 1,
                    Faltas = 2,
                    Bloqueos = 0
                },
                new StatsJugXPartido {
                    Jugador = jugadores[18],
                    Partido = partidoDos,
                    Puntos = 7,
                    Asistencias = 3,
                    Rebotes = 2,
                    Robos = 1,
                    Faltas = 3,
                    Bloqueos = 7
                },
                new StatsJugXPartido {
                    Jugador = jugadores[19],
                    Partido = partido,
                    Puntos = 4,
                    Asistencias = 3,
                    Rebotes = 2,
                    Robos = 1,
                    Faltas = 1,
                    Bloqueos = 7
                },
                new StatsJugXPartido {
                    Jugador = jugadores[19],
                    Partido = partidoDos,
                    Puntos = 6,
                    Asistencias = 3,
                    Rebotes = 4,
                    Robos = 1,
                    Faltas = 0,
                    Bloqueos = 3
                }
            };

            _proyectoDbContext.Equipos.AddRange(equipos);
            _proyectoDbContext.Partidos.AddRange(partidos);
            _proyectoDbContext.Jugadores.AddRange(jugadores);
            _proyectoDbContext.StatsJugXPartido.AddRange(estados);
            
            _proyectoDbContext.SaveChanges();

            return Json("Ok");
        }


 
        public IActionResult Index(int pagina)
        {
            if(_proyectoDbContext.Jugadores.FirstOrDefault() == null) {
                Create();
            }
           if (User.Identity.IsAuthenticated)
            {
                if(pagina == 0){
                    pagina = 1;
                }
                var usuario = _proyectoDbContext.Usuarios.Where(x => x.IdUsuario == Int32.Parse(@User.FindFirstValue(ClaimTypes.NameIdentifier))).FirstOrDefault();
                List<Jugador> misTitulares = new List<Jugador>();
                List<Jugador> misSuplentes = new List<Jugador>();
                var cantFilas =  _proyectoDbContext.Jugadores.Include(x => x.Equipo).Count();
                var registrosXPagina = 5;
                var incicio = (pagina - 1) * registrosXPagina;
                var cantPaginas = cantFilas / registrosXPagina;
                List<Jugador> jugadores = _proyectoDbContext.Jugadores.Include(x => x.Equipo).OrderBy(x => x.Equipo.Nombre).Skip(incicio).Take(registrosXPagina).ToList();
                List<EquipoUserJug> equiposJugsTit;
                List<EquipoUserJug> equiposJugsSup;
                bool yaHayEquipo = _proyectoDbContext.EquipoUserJugs.Where(x => x.IdUsuario == usuario.IdUsuario).FirstOrDefault() != null;
                if(yaHayEquipo) {
                    equiposJugsTit = _proyectoDbContext.EquipoUserJugs.Where(x => x.IdUsuario == usuario.IdUsuario).Where(x => x.EsTitular).ToList();
                    for(int i = 0; i < equiposJugsTit.Count(); i++) {
                        misTitulares.Add(_proyectoDbContext.Jugadores.Where(x => x.IdJugador == equiposJugsTit[i].IdJugador).FirstOrDefault());
                    };
                    equiposJugsSup = _proyectoDbContext.EquipoUserJugs.Where(x => x.IdUsuario == usuario.IdUsuario).Where(x => !x.EsTitular).ToList();
                    for(int i = 0; i < equiposJugsTit.Count(); i++) {
                        misSuplentes.Add(_proyectoDbContext.Jugadores.Where(x => x.IdJugador == equiposJugsTit[i].IdJugador).FirstOrDefault());
                    };
                }

                var viewmodel = new List<IndexVM> {
                    new IndexVM {
                    Jugadores = jugadores,
                    Titulares = misTitulares,
                    Suplentes = misSuplentes,
                    CantPaginas = cantPaginas,
                    Pagina = pagina
                }};

                return View(viewmodel);
            }
            return RedirectToAction("Index", "Login");
        }

 
        [HttpGet]
        public IActionResult CrearEquipo()
        {
            var jugadoresb = _proyectoDbContext.Jugadores
                            .Where(x => x.Posicion == Posiciones.BASE)
                            .Select (x => new SelectListItem {
                                Text = x.Nombre + " " + x.ValorContrato.ToString() + "$",
                                Value = x.IdJugador.ToString()
                            })
                            .ToList();
           
            var jugadorese = _proyectoDbContext.Jugadores
                            .Where(x => x.Posicion == Posiciones.ESCOLTA)
                            .Select (x => new SelectListItem {
                                Text = x.Nombre + " " + x.ValorContrato.ToString() + "$",
                                Value = x.IdJugador.ToString()
                            })
                            .ToList();
           
            var jugadoresa = _proyectoDbContext.Jugadores
                            .Where(x => x.Posicion == Posiciones.ALERO)
                            .Select (x => new SelectListItem {
                                Text = x.Nombre + " " + x.ValorContrato.ToString() + "$",
                                Value = x.IdJugador.ToString()
                            })
                            .ToList();
            var jugadoresap = _proyectoDbContext.Jugadores
                            .Where(x => x.Posicion == Posiciones.ALA_PIVOT)
                            .Select (x => new SelectListItem {
                                Text = x.Nombre + " " + x.ValorContrato.ToString() + "$",
                                Value = x.IdJugador.ToString()
                            })
                            .ToList();
           
            var jugadoresp = _proyectoDbContext.Jugadores
                            .Where(x => x.Posicion == Posiciones.PIVOT)
                            .Select (x => new SelectListItem {
                                Text = x.Nombre + " " + x.ValorContrato.ToString() + "$",
                                Value = x.IdJugador.ToString()
                            })
                            .ToList();
           
            var hayEquipo = _proyectoDbContext.EquipoUserJugs.Where(x => x.IdUsuario == Int32.Parse(@User.FindFirstValue(ClaimTypes.NameIdentifier))).FirstOrDefault() != null;
       
            var datos = new DatosFormEquipo {
                Presupuesto = _proyectoDbContext.Usuarios.Where(x => x.IdUsuario == Int32.Parse(@User.FindFirstValue(ClaimTypes.NameIdentifier))).FirstOrDefault().Presupuesto,
                JugadoresBase = jugadoresb,
                JugadoresEscolta = jugadorese,
                JugadoresAlero = jugadoresa,
                JugadoresAlaPivot = jugadoresap,
                JugadoresPivot = jugadoresp,
                YaHayEquipo = hayEquipo
            };

 
            return View(datos);
        }
   
        [HttpPost]
        public IActionResult CrearEquipo(DatosFormEquipo equipoUsuario)
        {
                var usuario = _proyectoDbContext.Usuarios.Where(x => x.IdUsuario == Int32.Parse(@User.FindFirstValue(ClaimTypes.NameIdentifier))).FirstOrDefault();

                var yaHayEquipo = _proyectoDbContext.EquipoUserJugs.Where(x => x.IdUsuario == Int32.Parse(@User.FindFirstValue(ClaimTypes.NameIdentifier))).FirstOrDefault() != null;

                List<EquipoUserJug> equiposUsuariosJugadoresViejos;

                if(yaHayEquipo) {
                    equiposUsuariosJugadoresViejos = _proyectoDbContext.EquipoUserJugs.Where(x => x.IdUsuario == usuario.IdUsuario).ToList();
                    foreach(EquipoUserJug e in equiposUsuariosJugadoresViejos) {
                        _proyectoDbContext.EquipoUserJugs.Remove(e);
                    }
                };
 
                var equiposUsuariosJugadores = new List<EquipoUserJug> {
                    new EquipoUserJug {
                        Usuario = usuario,
                        Jugador = _proyectoDbContext.Jugadores.Where(x => x.IdJugador == equipoUsuario.BaseTitular).FirstOrDefault(),
                        EsTitular = true
                    },
                    new EquipoUserJug {
                        Usuario = usuario,
                        Jugador = _proyectoDbContext.Jugadores.Where(x => x.IdJugador == equipoUsuario.EscoltaTitular).FirstOrDefault(),
                        EsTitular = true
                    },
                    new EquipoUserJug {
                        Usuario = usuario,
                        Jugador = _proyectoDbContext.Jugadores.Where(x => x.IdJugador == equipoUsuario.AleroTitular).FirstOrDefault(),
                        EsTitular = true
                    },
                    new EquipoUserJug {
                        Usuario = usuario,
                        Jugador = _proyectoDbContext.Jugadores.Where(x => x.IdJugador == equipoUsuario.AlaPivotTitular).FirstOrDefault(),
                        EsTitular = true
                    },
                    new EquipoUserJug {
                        Usuario = usuario,
                        Jugador = _proyectoDbContext.Jugadores.Where(x => x.IdJugador == equipoUsuario.PivotTitular).FirstOrDefault(),
                        EsTitular = true
                    },
                    new EquipoUserJug {
                        Usuario = usuario,
                        Jugador = _proyectoDbContext.Jugadores.Where(x => x.IdJugador == equipoUsuario.BaseSuplente).FirstOrDefault(),
                        EsTitular = false
                    },
                    new EquipoUserJug {
                        Usuario = usuario,
                        Jugador = _proyectoDbContext.Jugadores.Where(x => x.IdJugador == equipoUsuario.EscoltaSuplente).FirstOrDefault(),
                        EsTitular = false
                    },
                    new EquipoUserJug {
                        Usuario = usuario,
                        Jugador = _proyectoDbContext.Jugadores.Where(x => x.IdJugador == equipoUsuario.AleroSuplente).FirstOrDefault(),
                        EsTitular = false
                    },
                    new EquipoUserJug {
                        Usuario = usuario,
                        Jugador = _proyectoDbContext.Jugadores.Where(x => x.IdJugador == equipoUsuario.AlaPivotSuplente).FirstOrDefault(),
                        EsTitular = false
                    },
                    new EquipoUserJug {
                        Usuario = usuario,
                        Jugador = _proyectoDbContext.Jugadores.Where(x => x.IdJugador == equipoUsuario.PivotSuplente).FirstOrDefault(),
                        EsTitular = false
                    }
                };

                _proyectoDbContext.EquipoUserJugs.AddRange(equiposUsuariosJugadores);     
                
 
                _proyectoDbContext.SaveChanges();
                return RedirectToAction("Index", "Home");
                // Reescribir el viejo equipo
        }
 
        public IActionResult UnirseTorneo()
        {
            var usuario = _proyectoDbContext.Usuarios.Where(x => x.IdUsuario == Int32.Parse(@User.FindFirstValue(ClaimTypes.NameIdentifier))).FirstOrDefault();
            var torneos = _proyectoDbContext.Torneos.ToList();
            var unirseTorneos = new TorneoVM {
                Torneos = new List<TorneoViewModel>()
            };
            foreach(Torneo t in torneos) {
                var torneoUsuario = _proyectoDbContext.TorneoUsuarios.Where(x => x.Torneo == t && x.Usuario == usuario).FirstOrDefault();
                var pertenece = torneoUsuario != null;
                if(!pertenece) {
                    var creador = _proyectoDbContext.TorneoUsuarios.Where(x => x.IdTorneo == t.Id && x.EsCreador).FirstOrDefault();
                    unirseTorneos.Torneos.Add(new TorneoViewModel {
                        Id = t.Id,
                        Nombre = t.Nombre,
                        Creador = _proyectoDbContext.Usuarios.Where(x => x.IdUsuario == creador.IdUsuario).FirstOrDefault()
                    });
                };
            };

            return View(unirseTorneos);
        }

        [Route("Home/UnirseTorneo/{id:int}")]
        public IActionResult UnirseTorneo(int id) {
            var usuario = _proyectoDbContext.Usuarios.Where(x => x.IdUsuario == Int32.Parse(@User.FindFirstValue(ClaimTypes.NameIdentifier))).FirstOrDefault();
            var torneo = _proyectoDbContext.Torneos.Where(x => x.Id == id).FirstOrDefault();

            var torneoUser = new TorneoUsuario {
                Usuario = usuario,
                Torneo = torneo,
                EsCreador = false
            };

            _proyectoDbContext.TorneoUsuarios.Add(torneoUser);
            _proyectoDbContext.SaveChanges();
            
            var torneos = _proyectoDbContext.Torneos.ToList();
            var unirseTorneos = new TorneoVM {
                Torneos = new List<TorneoViewModel>()
            };
            foreach(Torneo t in torneos) {
                var torneoUsuario = _proyectoDbContext.TorneoUsuarios.Where(x => x.Torneo == t && x.Usuario == usuario).FirstOrDefault();
                var pertenece = torneoUsuario != null;
                if(!pertenece) {
                    var creador = _proyectoDbContext.TorneoUsuarios.Where(x => x.IdTorneo == t.Id && x.EsCreador).FirstOrDefault();
                    unirseTorneos.Torneos.Add(new TorneoViewModel {
                        Id = t.Id,
                        Nombre = t.Nombre,
                        Creador = _proyectoDbContext.Usuarios.Where(x => x.IdUsuario == creador.IdUsuario).FirstOrDefault()
                    });
                };
            };

            return View(unirseTorneos);
        }
 
        [HttpGet]
        public IActionResult MisTorneos()
        {
            var usuario = _proyectoDbContext.Usuarios.Where(x => x.IdUsuario == Int32.Parse(@User.FindFirstValue(ClaimTypes.NameIdentifier))).FirstOrDefault();
            var torneos = _proyectoDbContext.Torneos.ToList();
            var misTorneos = new TorneoVM {
                Torneos = new List<TorneoViewModel>()
            };
            foreach(Torneo t in torneos) {
                var torneoUsuario = _proyectoDbContext.TorneoUsuarios.Where(x => x.Torneo == t && x.Usuario == usuario).FirstOrDefault();
                var pertenece = torneoUsuario != null;
                if(pertenece) {
                    if(torneoUsuario.EsCreador) {
                        misTorneos.Torneos.Add(new TorneoViewModel {
                            Id = t.Id,
                            Nombre = t.Nombre,
                            Creador = usuario
                        });
                    };
                    if(!torneoUsuario.EsCreador) {
                        var creador = _proyectoDbContext.TorneoUsuarios.Where(x => x.IdTorneo == t.Id && x.EsCreador).FirstOrDefault();
                        misTorneos.Torneos.Add(new TorneoViewModel {
                            Id = t.Id,
                            Nombre = t.Nombre,
                            Creador = _proyectoDbContext.Usuarios.Where(x => x.IdUsuario == creador.IdUsuario).FirstOrDefault()
                        });
                    };
                };
            };

            return View(misTorneos);
        }

        [HttpPost]
        public IActionResult MisTorneos(TorneoVM torneo)
        {
            if (ModelState.IsValid)
            {
                var t= new Torneo
                {
                    Nombre = torneo.NombreTorneo
 
                };

                var torneoUsuario = new TorneoUsuario {
                    Torneo = t,
                    Usuario = _proyectoDbContext.Usuarios.Where(x => x.IdUsuario == Int32.Parse(@User.FindFirstValue(ClaimTypes.NameIdentifier))).FirstOrDefault(),
                    EsCreador = true
                };
 
                _proyectoDbContext.Torneos.Add(t);
                _proyectoDbContext.TorneoUsuarios.Add(torneoUsuario);
                _proyectoDbContext.SaveChanges();
 
                return RedirectToAction("MisTorneos", "Home");
            }
            return View();
        }
        
 
        public IActionResult Perfil()
        {
            return View();
        }
 
        public IActionResult MostrarEquipos()
        {
            if(User.Identity.IsAuthenticated){
                var claims = User.Claims.ToList();
                Console.WriteLine(claims);
 
            }
            var equipos = _proyectoDbContext.Equipos
                .Select(x => new SelectListItem
                {
                    Text = x.Nombre,
                    Value = x.Id.ToString()
                })
                .ToList();
            var EquipoVm = new RegistrarEquipo
            {
                Equipos = equipos
            };
 
            return View(EquipoVm);
        }
 
        public IActionResult AdministrarTorneo()
        {
           
            return View();
        }
 
        public IActionResult Ranking()
        {
            DateTime dt = DateTime.Now; 
            int diff = (7 + (dt.DayOfWeek - DayOfWeek.Monday)) % 7;
            dt = dt.AddDays(-1 * diff).Date;
            DateTime dt1 = dt.AddDays(7);
 
            var partidos = _proyectoDbContext.Partidos.Where(x => DateTime.Compare(dt, x.Fecha) <= 0 && DateTime.Compare(x.Fecha, dt1) <= 0).ToList();
            var jugsConPuntajes = new Dictionary<int, int>();
            var idJugadores = _proyectoDbContext.Jugadores.ToList();
 
            foreach(Jugador jug in idJugadores) {
                jugsConPuntajes.Add(jug.IdJugador, 0);
            };
 
            foreach(Partido p in partidos) {
                var estadosJugadoresPartido = _proyectoDbContext.StatsJugXPartido.Where(x => x.IdPartido == p.IdPartido).ToList();
                foreach(StatsJugXPartido s in estadosJugadoresPartido) {
                    var puntaje = s.Puntos + s.Asistencias + s.Rebotes + s.Robos - s.Faltas + s.Bloqueos;
                    jugsConPuntajes[s.IdJugador] += puntaje;
                };
            };
 
            var usuarios = _proyectoDbContext.Usuarios.ToList();
            var rankings = new List<Ranking>();
 
            foreach(Usuario u in usuarios) {
                var jugadoresUsuario = _proyectoDbContext.EquipoUserJugs.Where(x => x.IdUsuario == u.IdUsuario).ToList();
                var ranking = new Ranking {
                    NombreUsuario = u.Nombre,
                    Puntaje = 0
                };
                foreach(EquipoUserJug jugUser in jugadoresUsuario) {
                    ranking.Puntaje += jugsConPuntajes[jugUser.IdJugador];
                };
                rankings.Add(ranking);
            };
 
            List<Ranking> rankingOrdenado = rankings.OrderByDescending(o=>o.Puntaje).ToList();
 
            for(int i = 0; i < 3 && i < rankingOrdenado.Count(); i++) {
                var ranking = rankingOrdenado[i];
                var user = _proyectoDbContext.Usuarios.Where(x => x.Nombre == ranking.NombreUsuario).FirstOrDefault();
                var newUser = user;
                newUser.Presupuesto = 3000 + (((i - (i *2)) + 3) * ranking.Puntaje);
                _proyectoDbContext.Entry(user).CurrentValues.SetValues(newUser);
            }
 
            _proyectoDbContext.SaveChanges();
 
            // Conseguir lista de partidos que se dieron entre comienzo y fin de la semana. x
            // Armar un array de dos dimensiones con los id de los jugadores. x
            // Por cada partido, traer todos los StatsJugXPartido que le correspondan a su id y calcular el puntaje. x
            // Meter ese puntaje en la posición del array que le corresponda al id del jugador de ese StatsJugXPartido. x
            // Traer la lista de usuarios. x
            // Por cada usuario, recorrer sus jugadores y calcular el puntaje. Meterlo en una colección de Rankings. x
            // Finalmente, ordenar los elementos de la colección Ranking y ponerles el puesto correspondiente. x
            return View(rankingOrdenado);
        }

        [Route("Home/RankingTorneo/{id:int}")]
        public IActionResult RankingTorneo(int id)
        {
            DateTime dt = DateTime.Now;
            int diff = (7 + (dt.DayOfWeek - DayOfWeek.Monday)) % 7;
            dt = dt.AddDays(-1 * diff).Date;
            DateTime dt1 = dt.AddDays(7);
 
            var partidos = _proyectoDbContext.Partidos.Where(x => DateTime.Compare(dt, x.Fecha) <= 0 && DateTime.Compare(x.Fecha, dt1) <= 0).ToList();
            var jugsConPuntajes = new Dictionary<int, int>();
            var idJugadores = _proyectoDbContext.Jugadores.ToList();
 
            foreach(Jugador jug in idJugadores) {
                jugsConPuntajes.Add(jug.IdJugador, 0);
            };
 
            foreach(Partido p in partidos) {
                var estadosJugadoresPartido = _proyectoDbContext.StatsJugXPartido.Where(x => x.IdPartido == p.IdPartido).ToList();
                foreach(StatsJugXPartido s in estadosJugadoresPartido) {
                    var puntaje = s.Puntos + s.Asistencias + s.Rebotes + s.Robos - s.Faltas + s.Bloqueos;
                    jugsConPuntajes[s.IdJugador] += puntaje;
                };
            };

            var torneoUsuario = _proyectoDbContext.TorneoUsuarios.Where(x => x.IdTorneo == id).ToList();
            var usuarios = new List<Usuario>();
            foreach(TorneoUsuario t in torneoUsuario) {
                usuarios.Add(_proyectoDbContext.Usuarios.Where(x => x.IdUsuario == t.IdUsuario).FirstOrDefault());
            };

            var rankings = new List<Ranking>();
 
            foreach(Usuario u in usuarios) {
                var jugadoresUsuario = _proyectoDbContext.EquipoUserJugs.Where(x => x.IdUsuario == u.IdUsuario).ToList();
                var ranking = new Ranking {
                    NombreUsuario = u.Nombre,
                    Puntaje = 0
                };
                foreach(EquipoUserJug jugUser in jugadoresUsuario) {
                    ranking.Puntaje += jugsConPuntajes[jugUser.IdJugador];
                };
                rankings.Add(ranking);
            };
 
            List<Ranking> rankingOrdenado = rankings.OrderByDescending(o=>o.Puntaje).ToList();
 
            // Conseguir lista de partidos que se dieron entre comienzo y fin de la semana. x
            // Armar un array de dos dimensiones con los id de los jugadores. x
            // Por cada partido, traer todos los StatsJugXPartido que le correspondan a su id y calcular el puntaje. x
            // Meter ese puntaje en la posición del array que le corresponda al id del jugador de ese StatsJugXPartido. x
            // Traer la lista de usuarios. x
            // Por cada usuario, recorrer sus jugadores y calcular el puntaje. Meterlo en una colección de Rankings. x
            // Finalmente, ordenar los elementos de la colección Ranking y ponerles el puesto correspondiente. x
            return View(rankingOrdenado);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
   }
}    


