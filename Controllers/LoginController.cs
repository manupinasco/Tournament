using System.Linq;
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

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginUsuario usuario)
        {   
            if (ModelState.IsValid){
                {
                    var usuarioBuscado = _ProyectoDbContext.Usuarios
                    .Where(x => x.Email.Equals(usuario.Email) && x.Password.Equals(usuario.Password)).FirstOrDefault();
                    return RedirectToAction("index", "Home");
                }
            }
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
            if (ModelState.IsValid)
            {
                var usuario = new Usuario
                {
                    Nombre = altaUsuario.Nombre,
                    Apellido = altaUsuario.Apellido,
                    Edad = altaUsuario.Edad,
                    Email = altaUsuario.Email,
                    Password = altaUsuario.Password
                };

                _ProyectoDbContext.Usuarios.Add(usuario);
                _ProyectoDbContext.SaveChanges();

                return RedirectToAction("index", "Home");
            }
            return View();
        }
        

    }
}