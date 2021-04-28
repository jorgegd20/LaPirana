using Microsoft.AspNetCore.Mvc;

namespace LaPirana.Controllers
{
    public class PresentacionController: Controller
    {
        [HttpGet]
        public IActionResult Contacto()
        {
            var mensaje = "Bienvenido a mi página";
            ViewData["Mensaje"] = mensaje;
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