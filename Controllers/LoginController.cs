using Microsoft.AspNetCore.Mvc;
using TP_NT.Database;
using TP_NT.Models;
using TP_NT.Models.ViewModel;

namespace TP_NT.Controllers
{
    public class LoginController : Controller
    {
        private ProyectoDbContext _ProyectoDbContext;
        public LoginController(ProyectoDbContext ProyectoDbContext)
        {
            this._ProyectoDbContext = ProyectoDbContext;
        }

        public IActionResult Index(){
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegistrarUsuario altaUsuario)
        {
                var usuario = new Usuario { 
                    Nombre = altaUsuario.Nombre,
                    Apellido = altaUsuario.Apellido,
                    Edad = altaUsuario.Edad,
                    Email = altaUsuario.Email,
                    Password = altaUsuario.Password
                };
                
                _ProyectoDbContext.Usuarios.Add(usuario);
                _ProyectoDbContext.SaveChanges();

                return RedirectToAction("index","Home");
            

        }
        

    }
}