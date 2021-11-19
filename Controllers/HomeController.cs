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
 
        public IActionResult Index()
        {
           if (User.Identity.IsAuthenticated)
            {
                var usuario = _proyectoDbContext.Usuarios.Where(x => x.IdUsuario == Int32.Parse(@User.FindFirstValue(ClaimTypes.NameIdentifier))).FirstOrDefault();
                List<Jugador> misTitulares = new List<Jugador>();
                List<Jugador> misSuplentes = new List<Jugador>();
                List<Jugador> jugadores = _proyectoDbContext.Jugadores.Include(x => x.Equipo).ToList();
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
                    Suplentes = misSuplentes
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


