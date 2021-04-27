using Microsoft.AspNetCore.Mvc;

namespace LaPirana.Controllers
{
    public class CuentaController: Controller
    {
        public IActionResult Actualizar()
        {
            return View("Actualizar");
        }
        public IActionResult Iniciar()
        {
            return View("Iniciar");
        }
        public IActionResult Registro()
        {
            return View("Registro");
        }
    }
}