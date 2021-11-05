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

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
           // var equipo = _proyectoDbContext.Usuarios.Where(x => x.IdUsuario == ).Select(x => x.EquipoUsuario);
           // var titulares = equipo.Select(x => x.Titular);
           // var suplentes = equipo.Select(x => x.Suplente);
           // ViewBag.tit = titulares;
           // ViewBag.sup = suplentes;


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
            var jugadores = _proyectoDbContext.Jugadores;
            var pos = _proyectoDbContext.Posiciones.ToArray();
            
            var datos = new DatosFormEquipo 
            {
                Jugadores = jugadores,
                Posicion = pos
            };


            return View(datos);
        }
    
        [HttpPost]
        public IActionResult CrearEquipo(EquipoUsuario equipoUsuario)
        {
            
            if (ModelState.IsValid)
            {
                var equipo = new EquipoUsuario
                {
                    Titular = equipoUsuario.Titular,
                    Suplente = equipoUsuario.Suplente

                };

                _proyectoDbContext.EquiposUsuario.Add(equipo);
                _proyectoDbContext.SaveChanges();

                return RedirectToAction("Index", "Home");
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
