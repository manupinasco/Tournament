using System.Collections.Generic;
using System.Linq;
using TP_NT.Database;
using TP_NT.Models;
using Microsoft.AspNetCore.Mvc;

namespace TP_NT.Controllers
{
    public class TorneoController : Controller
    {
        private ProyectoDbContext _ProyectoDbContext;
        public TorneoController(ProyectoDbContext ProyectoDbContext)
        {
            this._ProyectoDbContext = ProyectoDbContext;
        }

         public IActionResult Create() {

            var equipos = new List<Equipo> {
                new Equipo { 
                Nombre = "Boca",
            },
                new Equipo { 
                Nombre = "River",
            }
            };

            _ProyectoDbContext.Equipos.AddRange(equipos);
            _ProyectoDbContext.SaveChanges();

            return Json(equipos);
        }

            public IActionResult GetAll() {

            var equiposCompleto = _ProyectoDbContext.Equipos.ToList();
            return Json(equiposCompleto);
        }

    }

}