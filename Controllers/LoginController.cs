using Microsoft.AspNetCore.Mvc;

namespace TP_NT.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index(){
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

    }
}