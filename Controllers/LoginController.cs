using System.Linq;
using System.Security.Claims;
using System.Text;
using TP_NT.Database;
using TP_NT.Models;
using TP_NT.Models.ViewModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;


namespace TP_NT.Controllers
{
    public class LoginController : Controller
    {
        private ProyectoDbContext _ProyectoDbContext;
        public LoginController(ProyectoDbContext ProyectoDbContext)
        {
            this._ProyectoDbContext = ProyectoDbContext;
        }

        public static string GetSHA256(string str)
        {
                    SHA256 sha256 = SHA256Managed.Create();
                    ASCIIEncoding encoding = new ASCIIEncoding();
                    byte[] stream = null;
                    StringBuilder sb = new StringBuilder();
                    stream = sha256.ComputeHash(encoding.GetBytes(str));
                    for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
                    return sb.ToString();
        }

       [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginUsuario credenciales)
        {
            if (ModelState.IsValid)
            {
                var username = credenciales.Email;
                var contraseña = GetSHA256(credenciales.Password);
                var user = _ProyectoDbContext.Usuarios.FirstOrDefault(u => u.Email == username && u.Password == contraseña);
                if (user != null)
                {

                        // Creamos los Claims (credencial de acceso con informacion del usuario)
                        ClaimsIdentity identidad = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);

                        // Agregamos a la credencial el nombre de usuario
                        identidad.AddClaim(new Claim(ClaimTypes.Name, username));
                        // Agregamos a la credencial el nombre del estudiante/administrador
                        identidad.AddClaim(new Claim(ClaimTypes.GivenName, user.Nombre));
                        // Agregamos a la credencial el Rol
                        identidad.AddClaim(new Claim(ClaimTypes.Surname, user.Apellido.ToString()));

                        ClaimsPrincipal principal = new ClaimsPrincipal(identidad);

                        // Ejecutamos el Login
                        HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.ErrorEnLogin = "Credenciales invalidas.";
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
                    Password = GetSHA256(altaUsuario.Password)
                };

                _ProyectoDbContext.Usuarios.Add(usuario);
                _ProyectoDbContext.SaveChanges();

                return RedirectToAction("index", "Home");
            }
            return View();
        }
        
        [Authorize]
        [HttpPost]
        public IActionResult Salir()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        public IActionResult AccesoDenegado()
        {
            return View();
        }


    }
}