using Microsoft.AspNetCore.Mvc;

namespace LaPirana.Controllers
{
    public class PresentacionController: Controller
    {
        public IActionResult Contacto()
        {
            return View();
        }
        public IActionResult Servicios()
        {
            return View();
        }
        public IActionResult Somos()
        {
            return View();
        }
    }
}