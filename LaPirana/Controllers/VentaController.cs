using Microsoft.AspNetCore.Mvc;

namespace LaPirana.Controllers
{
    public class VentaController: Controller
    {
        public IActionResult Catalogo()
        {
            return View();
        }
        public IActionResult ProductosDestacados()
        {
            return View();
        }
        public IActionResult Servicios()
        {
            return View();
        }
    }
}