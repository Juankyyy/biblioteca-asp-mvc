using Microsoft.AspNetCore.Mvc;

namespace Mvc.Controllers
{
    public class HistorialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Informe()
        {
            return View();
        }
    }
}