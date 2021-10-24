using System;
using System.Linq;
using System.Collections.Generic;
using TP_NT.Database;
using TP_NT.Models;
using Microsoft.AspNetCore.Mvc;
using  System.Collections;
using Microsoft.EntityFrameworkCore;

namespace proyectoNT.Controllers 
{

    public class ProyectoController : Controller
    {

        private ProyectoDbContext _proyectoDbContext;

        public ProyectoController(ProyectoDbContext proyectoDbContext) 
        {
            this._proyectoDbContext = proyectoDbContext;
        }

        public IActionResult Create() {
            

            return Json("OK");


        }

        public IActionResult GetAll() {
            
            return Json("OK");
        }

         public IActionResult GetMarvel() {
              return Json("OK");
         }

         public IActionResult SaveOrden() {
            
             return Json("OK");
         }

    }
}