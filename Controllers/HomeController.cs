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

        private readonly ILogger<HomeController> _logger;

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
                List<Jugador> jugadores = _proyectoDbContext.Jugadores.ToList();
                List<EquipoUserJug> equiposJugsTit;
                List<EquipoUserJug> equiposJugsSup;
               equiposJugsTit = _proyectoDbContext.EquipoUserJugs.Where(x => x.IdUsuario == usuario.IdUsuario).Where(x => x.EsTitular).ToList();
                for(int i = 0; i < equiposJugsTit.Count(); i++) {
                        misTitulares.Add(_proyectoDbContext.Jugadores.Where(x => x.IdJugador == equiposJugsTit[i].IdJugador).FirstOrDefault());
                };
                equiposJugsSup = _proyectoDbContext.EquipoUserJugs.Where(x => x.IdUsuario == usuario.IdUsuario).Where(x => !x.EsTitular).ToList();
                for(int i = 0; i < equiposJugsTit.Count(); i++) {
                        misSuplentes.Add(_proyectoDbContext.Jugadores.Where(x => x.IdJugador == equiposJugsTit[i].IdJugador).FirstOrDefault());
                };

              ViewBag.tit = misTitulares;
              ViewBag.sup = misSuplentes;
              ViewBag.jugadores = jugadores;



                return View();
            }
            return RedirectToAction("Index", "Login");
        }

        [HttpGet]
        public IActionResult CrearTorneo()
        {
            return View();
        }
    
        [HttpPost]
        public IActionResult CrearTorneo(Torneo torneo)
        {
            if (ModelState.IsValid)
            {
                var t= new Torneo
                {
                    Nombre = torneo.Nombre,
                    // Cómo traer al creador en formato Objeto Creador = _proyectoDbContext.Usuarios.Where(x => x.IdUsuario == 1),

                };

                _proyectoDbContext.Torneos.Add(t);
                _proyectoDbContext.SaveChanges();

                return RedirectToAction("CrearTorneo", "Home");
            }
            return View();
        }

        [HttpGet]
        public IActionResult CrearEquipo()
        {
            var jugadoresb = _proyectoDbContext.Jugadores
                            .Where(x => x.Posicion == Posiciones.BASE)
                            .Select (x => new SelectListItem {
                                Text = x.Nombre + " " + x.ValorContrato.ToString(),
                                Value = x.IdJugador.ToString()
                            })
                            .ToList();
            
            var jugadorese = _proyectoDbContext.Jugadores
                            .Where(x => x.Posicion == Posiciones.ESCOLTA)
                            .Select (x => new SelectListItem {
                                Text = x.Nombre + " " + x.ValorContrato.ToString(),
                                Value = x.IdJugador.ToString()
                            })
                            .ToList();
            
            var jugadoresa = _proyectoDbContext.Jugadores
                            .Where(x => x.Posicion == Posiciones.ALERO)
                            .Select (x => new SelectListItem {
                                Text = x.Nombre + " " + x.ValorContrato.ToString(),
                                Value = x.IdJugador.ToString()
                            })
                            .ToList();
            var jugadoresap = _proyectoDbContext.Jugadores
                            .Where(x => x.Posicion == Posiciones.ALA_PIVOT)
                            .Select (x => new SelectListItem {
                                Text = x.Nombre + " " + x.ValorContrato.ToString(),
                                Value = x.IdJugador.ToString()
                            })
                            .ToList();
            
            var jugadoresp = _proyectoDbContext.Jugadores
                            .Where(x => x.Posicion == Posiciones.PIVOT)
                            .Select (x => new SelectListItem {
                                Text = x.Nombre + " " + x.ValorContrato.ToString(),
                                Value = x.IdJugador.ToString()
                            })
                            .ToList();
            
            var datos = new DatosFormEquipo {
                Presupuesto = _proyectoDbContext.Usuarios.Where(x => x.IdUsuario == Int32.Parse(@User.FindFirstValue(ClaimTypes.NameIdentifier))).FirstOrDefault().Presupuesto,
                JugadoresBase = jugadoresb,
                JugadoresEscolta = jugadorese,
                JugadoresAlero = jugadoresa,
                JugadoresAlaPivot = jugadoresap,
                JugadoresPivot = jugadoresp
            };


            return View(datos);
        }
    
        [HttpPost]
        public IActionResult CrearEquipo(DatosFormEquipo equipoUsuario)
        {
            if(ModelState.IsValid) {

                var usuario = _proyectoDbContext.Usuarios.Where(x => x.IdUsuario == Int32.Parse(@User.FindFirstValue(ClaimTypes.NameIdentifier))).FirstOrDefault();

                usuario.Presupuesto = equipoUsuario.Presupuesto;

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
            };
            
            return View();
        } 

        public IActionResult UnirseTorneo()
        {
            return View();
        }

        public IActionResult MisTorneos()
        {
            return View();
        }

        public IActionResult Perfil()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
