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
            var jugadores = _proyectoDbContext.Jugadores.ToList();

            var pos = Enum.GetNames(typeof(Posiciones));
            
            var datos = new DatosFormEquipo 
            {
                Jugadores = jugadores,
                Posicion = pos
            };


            return View(datos);
        }
    
        [HttpPost]
        public IActionResult CrearEquipo(DatosFormEquipo equipoUsuario)
        {
            if (ModelState.IsValid) {
                var equipo = new EquipoUsuario();

                for(int i = 0; i < 10; i++) {
                    if(equipoUsuario.jugsT[i]) {
                        equipo.Titular.Add(_proyectoDbContext.Jugadores.Where(x => x.IdJugador == i).FirstOrDefault());
                    }
                }

                for(int j = 0; j < 10; j++) {
                    if(equipoUsuario.jugsS[j]) {
                         equipo.Suplente.Add(_proyectoDbContext.Jugadores.Where(x => x.IdJugador == j).FirstOrDefault());
                    }
                }

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
