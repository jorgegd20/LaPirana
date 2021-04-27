using Microsoft.AspNetCore.Mvc;

namespace LaPirana.Controllers
{
    public class CompraController: Controller
    {
        public IActionResult Pagar()
        {
            return View("Pagar");
        }
        public IActionResult Resumen()
        {
            return View("Resumen");
        }
    }
}