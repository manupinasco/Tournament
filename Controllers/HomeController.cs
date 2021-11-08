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
           var usuario = _proyectoDbContext.Usuarios.Where(x => x.IdUsuario == 3).FirstOrDefault();
           if(usuario.EquipoUsuario != null) {
                var equipo = usuario.EquipoUsuario;
                var titulares = equipo.Titular.ToList();
                ViewBag.tit = titulares;
                var suplentes = equipo.Suplente.ToList();
                ViewBag.sup = suplentes;
           }
           else {
               ViewBag.tit = null;
               ViewBag.sup = null;
           }
           


            return View();
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
                                Text = x.Nombre,
                                Value = x.ValorContrato.ToString()
                            })
                            .ToList();;
            
            var jugadorese = _proyectoDbContext.Jugadores
                            .Where(x => x.Posicion == Posiciones.ESCOLTA)
                            .Select (x => new SelectListItem {
                                Text = x.Nombre,
                                Value = x.ValorContrato.ToString()
                            })
                            .ToList();;
            
            var jugadoresa = _proyectoDbContext.Jugadores
                            .Where(x => x.Posicion == Posiciones.ALERO)
                            .Select (x => new SelectListItem {
                                Text = x.Nombre,
                                Value = x.ValorContrato.ToString()
                            })
                            .ToList();;
            var jugadoresap = _proyectoDbContext.Jugadores
                            .Where(x => x.Posicion == Posiciones.ALA_PIVOT)
                            .Select (x => new SelectListItem {
                                Text = x.Nombre,
                                Value = x.ValorContrato.ToString()
                            })
                            .ToList();;
            
            var jugadoresp = _proyectoDbContext.Jugadores
                            .Where(x => x.Posicion == Posiciones.PIVOT)
                            .Select (x => new SelectListItem {
                                Text = x.Nombre,
                                Value = x.IdJugador.ToString()
                            })
                            .ToList();;
            
            var datos = new DatosFormEquipo 
            {
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
                _proyectoDbContext.Jugadores.Add(_proyectoDbContext.Jugadores.Where(x => x.IdJugador == equipoUsuario.BaseTitular).FirstOrDefault());
                var equipo = new EquipoUsuario{
                    Titular = new List<Jugador> {
                       _proyectoDbContext.Jugadores.Where(x => x.IdJugador == equipoUsuario.BaseTitular).FirstOrDefault(),
                       _proyectoDbContext.Jugadores.Where(x => x.IdJugador == equipoUsuario.EscoltaTitular).FirstOrDefault(),
                       _proyectoDbContext.Jugadores.Where(x => x.IdJugador == equipoUsuario.AleroTitular).FirstOrDefault(),
                       _proyectoDbContext.Jugadores.Where(x => x.IdJugador == equipoUsuario.AlaPivotTitular).FirstOrDefault(),
                       _proyectoDbContext.Jugadores.Where(x => x.IdJugador == equipoUsuario.PivotTitular).FirstOrDefault()
                    },
                    Suplente = new List<Jugador> {
                        _proyectoDbContext.Jugadores.Where(x => x.IdJugador == equipoUsuario.BaseSuplente).FirstOrDefault(),
                        _proyectoDbContext.Jugadores.Where(x => x.IdJugador == equipoUsuario.EscoltaSuplente).FirstOrDefault(),
                        _proyectoDbContext.Jugadores.Where(x => x.IdJugador == equipoUsuario.AleroSuplente).FirstOrDefault(),
                        _proyectoDbContext.Jugadores.Where(x => x.IdJugador == equipoUsuario.AlaPivotSuplente).FirstOrDefault(),
                        _proyectoDbContext.Jugadores.Where(x => x.IdJugador == equipoUsuario.PivotSuplente).FirstOrDefault()
                    }
                };

                _proyectoDbContext.EquiposUsuario.Add(equipo);
                var usuario = _proyectoDbContext.Usuarios.Where(x => x.IdUsuario == 3).FirstOrDefault();
                var nuevoUsuario = usuario;
                nuevoUsuario.EquipoUsuario = equipo;
                _proyectoDbContext.Entry(usuario).CurrentValues.SetValues(nuevoUsuario);
                _proyectoDbContext.SaveChanges();
                return View("Views/Home/Index.cshtml");
            }
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
